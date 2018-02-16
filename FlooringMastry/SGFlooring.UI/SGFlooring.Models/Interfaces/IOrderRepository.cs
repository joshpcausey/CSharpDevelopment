using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Models.Interfaces
{
	public interface IOrderRepository
	{
		List<Order> LoadOrder(string date);
		void SaveOrder(Order order);
		List<Order> EditOrder(string customerName, string state, string productType, int area);
		List<Order> FindOrder(string date, int orderNumber);
	}
}
