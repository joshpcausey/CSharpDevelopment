using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Models
{
	public class Order
	{
		public Order() { }

		public Order(Order that)
		{
			OrderDate = that.OrderDate;
			OrderNumber = that.OrderNumber;
			CustomerName = that.CustomerName;
			State = that.State;
			TaxRate = that.TaxRate;
			ProductType = that.ProductType;
			Area = that.Area;
			CostPerSquareFoot = that.CostPerSquareFoot;
			LaborCostPerSquareFoot = that.LaborCostPerSquareFoot;
			MaterialCost = that.MaterialCost;
			LaborCost = that.LaborCost;
			Tax = that.Tax;
			Total = that.Total;
		}

		public string OrderDate { get; set; }
		public int OrderNumber { get; set; }
		public string CustomerName { get; set; }
		public string State { get; set; }
		public decimal TaxRate { get; set; }
		public string ProductType { get; set; }
		public decimal Area { get; set; }
		public decimal CostPerSquareFoot { get; set; }
		public decimal LaborCostPerSquareFoot { get; set; }
		public decimal MaterialCost { get; set; }
		public decimal LaborCost { get; set; }
		public decimal Tax { get; set; }
		public decimal Total { get; set; }
	}
}
