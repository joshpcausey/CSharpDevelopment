using SGFlooring.BLL;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI.Workflows
{
	public static class LoadOrderWorkflow
	{
		public static void Execute()
		{
			Console.Clear();
			OrderManager orderManager = OrderManagerFactory.Create();


			Console.WriteLine("Enter a date: ");
			string date = Console.ReadLine();
			LoadOrderResponse response = orderManager.LoadOrder(date);
			if (response.Success == false)
			{
				Console.WriteLine(response.Message);
				Console.WriteLine("Press any key to continue...");
				Console.ReadKey();
				return;
			}
			else
			{
				foreach (var order in response.AllOrders)
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
				return;
			}
		}
	}
}
