using SGFlooring.Models;
using SGFlooring.Models.Interfaces;
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
		public List<Order> LoadOrder(string date)
		{
			List<Order> returnOrders = new List<Order>();
			var orders = AllOrders.Where(o => o.OrderDate == date);
			returnOrders.AddRange(orders);
			return returnOrders;
		}

		public void SaveOrder(Order order)
		{
			AllOrders.Add(order);
		}
	}
}
