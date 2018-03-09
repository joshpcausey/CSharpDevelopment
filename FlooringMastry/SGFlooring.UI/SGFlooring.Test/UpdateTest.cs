using NUnit.Framework;
using SGFlooring.BLL;
using SGFlooring.Data;
using SGFlooring.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Test
{
	class UpdateTest
	{
		[TestCase(1, "03/03/2019", "Josh", "IN", 6, "Tile", 250, 3.50, 4.15)]
		public void Update(int orderNumber, string orderDate, string customerName, string state, decimal taxRate, string productType, decimal area, decimal costPerSquareFoot, decimal laborCostPerSquareFoot)
		{
			var manager = new OrderManager(new FileTestRepository(), new FileStateRepository(), new FileProductRepository());

			Order oldOrder = new Order()
			{

				OrderNumber = orderNumber,
				OrderDate = orderDate,
				CustomerName = customerName,
				State = state,
				TaxRate = taxRate,
				ProductType = productType,
				Area = area,
				CostPerSquareFoot = costPerSquareFoot,
				LaborCostPerSquareFoot = laborCostPerSquareFoot
			};

			Order newOrder = new Order()
			{

				OrderNumber = orderNumber,
				OrderDate = orderDate,
				CustomerName = "Bob",
				State = state,
				TaxRate = taxRate,
				ProductType = productType,
				Area = area,
				CostPerSquareFoot = costPerSquareFoot,
				LaborCostPerSquareFoot = laborCostPerSquareFoot
			};
			var saveOrderResponse = manager.AddOrder(oldOrder.OrderDate, oldOrder.CustomerName, oldOrder.State, oldOrder.ProductType, oldOrder.Area.ToString());
			manager.OverRideOrder(newOrder);
			var loadOrderResponse = manager.FindOrder(newOrder.OrderDate, newOrder.OrderNumber.ToString());
			manager.RemoveOrder(newOrder);
			Assert.AreEqual(loadOrderResponse.OriginalOrder.CustomerName, newOrder.CustomerName);
			//Assert.AreEqual(beforeAdd + 1, afterAdd);
		}
	}
}
