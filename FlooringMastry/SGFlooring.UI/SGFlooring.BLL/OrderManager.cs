using SGFlooring.Data;
using SGFlooring.Models;
using SGFlooring.Models.Interfaces;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.BLL
{
	public class OrderManager
	{
		private IOrderRepository _orderRepository;
		private IStateRepository _stateRepository;
		private IProductRepository _productRepository;

		public OrderManager(IOrderRepository orderRepository, IStateRepository stateRepository, IProductRepository productRepository)
		{
			_orderRepository = orderRepository;
			_stateRepository = stateRepository;
			_productRepository = productRepository;
		}

		public AddOrderResponse AddOrder(string date, string name, string state, string productType, string area)
		{
			AddOrderResponse response = new AddOrderResponse();

			if (DateTime.Parse(date) <= DateTime.Today)
			{
				response.Success = false;
				response.Message = "Date must be in the correct format (mm/dd/yyyy) and must be after today.";
				return response;
			}

			if (name == "")
			{
				response.Success = false;
				response.Message = "Name can not be blank";
				return response;
			}

			List<Tax> allTaxForValidation = new List<Tax>();
			allTaxForValidation = _stateRepository.GetEveryState();
			bool isValidState = false;
			foreach(var currentTax in allTaxForValidation)
			{
				if(state == currentTax.StateAbbreviation || state == currentTax.StateName)
				{
					isValidState = true;
				}
			}
			if (!isValidState)
			{
				response.Success = false;
				response.Message = "The customers state must be a valid state we have operations in.";
				return response;
			}

			List<Product> allProductsForValidation = new List<Product>();
			allProductsForValidation = _productRepository.GetAllProducts();
			bool isValidProduct = false;
			foreach(var currentProduct in allProductsForValidation)
			{
				if(productType == currentProduct.ProductType)
				{
					isValidProduct = true;
				}
			}
			if (!isValidProduct)
			{
				response.Success = false;
				response.Message = "The input product must be a product we stock";
				return response;
			}

			if ((decimal.TryParse(area, out decimal areaDecimal) && decimal.Parse(area) <= 0M))
			{
				response.Success = false;
				response.Message = "Area must be greater than zero";
				return response;
			}

			Tax stateForTaxRate = allTaxForValidation.Single(tax => tax.StateName == state || tax.StateAbbreviation == state);
			decimal taxRate = stateForTaxRate.TaxRate;

			Product productForCost = allProductsForValidation.Single(p => p.ProductType == productType);
			decimal costPerSquareFoot = productForCost.CostPerSquareFoot;

			decimal laborCostPerSquareFoot = productForCost.LaborCostPerSquareFoot;

			int orderNumberToInsert = 1;
			if (_orderRepository.LoadOrder(date).Count > 0)
			{
				orderNumberToInsert = _orderRepository.LoadOrder(date).Max(o => o.OrderNumber) + 1;
			}
			Order currentOrder = new Order
			{
				OrderDate = date,
				OrderNumber = orderNumberToInsert,
				CustomerName = name,
				State = state,
				TaxRate = taxRate,
				ProductType = productType,
				Area = areaDecimal,
				CostPerSquareFoot = costPerSquareFoot,
				LaborCostPerSquareFoot = laborCostPerSquareFoot,
			};

			currentOrder.MaterialCost = currentOrder.Area * currentOrder.CostPerSquareFoot;
			currentOrder.LaborCost = currentOrder.Area * currentOrder.LaborCostPerSquareFoot;
			currentOrder.Tax = currentOrder.LaborCost + currentOrder.MaterialCost * (taxRate / 100M);
			currentOrder.Total = currentOrder.MaterialCost + currentOrder.LaborCost + currentOrder.Tax;

			_orderRepository.SaveOrder(currentOrder);
			response.Success = true;
			response.Message = "Added Order";
			return response;
		}

		public FindOrderResponse FindOrder(string date, string orderNumber)
		{
			FindOrderResponse response = new FindOrderResponse();
			DateTime dateParsed;
			int orderNumberParsed = int.MinValue;

			if (!DateTime.TryParse(date, out dateParsed))
			{
				response.Message = $"Not a valid date. Must be in mm/dd/yyyy format. You typed {date}";
				response.Success = false;
				return response;
			}

			else if(!int.TryParse(orderNumber, out orderNumberParsed))
			{
				response.Message = $"Not a valid number. You typed {orderNumber}";
				response.Success = false;
				return response;
			}

			List<Order> allOrdersThatMatch = new List<Order>();

			allOrdersThatMatch = _orderRepository.FindOrder(date, orderNumberParsed);
			if(allOrdersThatMatch.Count() < 1)
			{
				response.Success = false;
				response.Message = "Could not find that order";
				return response;
			}

			Order originalOrder = allOrdersThatMatch[0];
			Order copyOrder = new Order(originalOrder);

			response.OriginalOrder = originalOrder;
			response.CopyOrder = copyOrder;
			response.Success = true;
			response.Message = "Found Order";
			return response;
		}

		public LoadOrderResponse LoadOrder(string date)
		{
			LoadOrderResponse response = new LoadOrderResponse();
			DateTime dateParsed;
			if (!DateTime.TryParse(date, out dateParsed))
			{
				response.Message = $"Not a valid date. Must be in mm/dd/yyyy format. You typed {date}";
				response.Success = false;
				return response;
			}

			List<Order> allOrders = _orderRepository.LoadOrder(date);

			if (allOrders == null)
			{
				response.Success = false;
				response.Message = "No orders for that date";
				return response;
			}

			foreach (var order in allOrders)
			{
				Console.WriteLine();
				Console.WriteLine($"{order.OrderNumber} | {order.OrderDate}");
				Console.WriteLine(order.CustomerName);
				Console.WriteLine(order.State);
				Console.WriteLine(order.ProductType);
				Console.WriteLine(order.MaterialCost);
				Console.WriteLine(order.LaborCost);
				Console.WriteLine(order.Tax);
				Console.WriteLine(order.Total);
				Console.WriteLine();
			}

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
			response.Success = true;
			response.Message = "Displayed Orders";
			return response;
		}

		public void OverRideOrder(Order order)
		{
			_orderRepository.OverRideOrder(order);
		}

		public void RemoveOrder(Order order)
		{
			_orderRepository.RemoveOrder(order);
		}
	}
}
