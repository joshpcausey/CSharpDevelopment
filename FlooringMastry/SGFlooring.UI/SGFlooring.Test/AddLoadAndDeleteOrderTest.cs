﻿using NUnit.Framework;
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
	public class AddLoadAndDeleteOrderTest
	{
		[TestCase(1, "03/03/2019", "Josh", "IN", 6, "Tile", 250, 3.50, 4.15)]
		public void AddLoadAndDelete(int orderNumber, string orderDate, string customerName, string state, decimal taxRate, string productType, decimal area, decimal costPerSquareFoot, decimal laborCostPerSquareFoot)
		{
			var manager = new OrderManager(new FileTestRepository(), new FileStateRepository(), new FileProductRepository());

			Order orderVariable = new Order()
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
			var loadOrderResponse = manager.LoadOrder(orderVariable.OrderDate);
			int beforeAdd = loadOrderResponse.AllOrders.Count();
			var saveOrderResponse = manager.AddOrder(orderVariable.OrderDate, orderVariable.CustomerName, orderVariable.State, orderVariable.ProductType, orderVariable.Area.ToString());
			var afterAddResponse = manager.LoadOrder(orderVariable.OrderDate);
			var afterAdd = afterAddResponse.AllOrders.Count();
			manager.RemoveOrder(orderVariable);

			Assert.AreEqual(beforeAdd + 1, afterAdd);
		}
	}
}
