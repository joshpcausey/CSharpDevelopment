using SGFlooring.Models;
using SGFlooring.Models.Interfaces;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Data
{
	public class MemoryTestRepository : IOrderRepository
	{
		static List<Order> AllOrders = new List<Order>();

		public List<Order> EditOrder(string customerName, string state, string productType, int area)
		{

			throw new NotImplementedException();
		}

		public List<Order> FindOrder(string date, int orderNumber)
		{
			List<Order> returnOrder = new List<Order>();

			returnOrder = AllOrders.Select(o => o).Where(o => o.OrderDate == date & o.OrderNumber == orderNumber).ToList();
			return returnOrder;
		}

		public List<Order> LoadOrder(string date)
		{
			List<Order> returnOrders = new List<Order>();
			var orders = AllOrders.Where(o => o.OrderDate == date);
			returnOrders.AddRange(orders);
			return returnOrders;
		}

		public void OverRideOrder(Order order)
		{
			foreach(var o in AllOrders)
			{
				if(o.OrderNumber == order.OrderNumber && o.OrderDate == order.OrderDate)
				{
					o.CustomerName = order.CustomerName;
					o.State = order.State;
					o.TaxRate = order.TaxRate;
					o.ProductType = order.ProductType;
					o.Area = order.Area;
					o.CostPerSquareFoot = order.CostPerSquareFoot;
					o.LaborCostPerSquareFoot = order.LaborCostPerSquareFoot;
					o.MaterialCost = order.MaterialCost;
					o.LaborCost = order.LaborCost;
					o.Tax = order.Tax;
					o.Total = order.Total;
					return;
				}
			}
		}

		public void SaveOrder(Order order)
		{
			AllOrders.Add(order);
		}
	}
}
