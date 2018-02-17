using SGFlooring.BLL;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI
{
	public class RemoveOrderWorkflow
	{
		public static void Execute()
		{
			Console.Clear();
			OrderManager orderManager = OrderManagerFactory.Create();
			RemoveOrderResponse responseRemove = new RemoveOrderResponse();
			FindOrderResponse responseFind = new FindOrderResponse();

			Console.Write("Enter an order date: ");
			string date = Console.ReadLine();

			Console.Write("Enter an order number: ");
			string orderNumber = Console.ReadLine();

			responseFind = orderManager.FindOrder(date, orderNumber);
			if (responseFind.Success == false)
			{
				Console.WriteLine(responseFind.Message);
				Console.WriteLine("Press any key to contine...");
				Console.ReadKey();
				return;
			}

			Console.WriteLine("fOUND ORDER");
			Console.WriteLine("===================");
			Console.WriteLine($"{responseFind.OriginalOrder.OrderNumber} | {responseFind.OriginalOrder.OrderDate}");
			Console.WriteLine(responseFind.OriginalOrder.CustomerName);
			Console.WriteLine(responseFind.OriginalOrder.State);
			Console.WriteLine(responseFind.OriginalOrder.ProductType);
			Console.WriteLine(responseFind.OriginalOrder.MaterialCost);
			Console.WriteLine(responseFind.OriginalOrder.LaborCost);
			Console.WriteLine(responseFind.OriginalOrder.Tax);
			Console.WriteLine(responseFind.OriginalOrder.Total);
			Console.WriteLine();

			bool remove = false;
			do
			{
				Console.WriteLine("Are you sure you want to remove? Type 'y' for yes or 'n' for no");
				string userInputRemove = Console.ReadLine();
				if (userInputRemove == "y")
				{
					remove = true;
					break;
				}
				else if (userInputRemove == "n")
				{
					break;
				}
			} while (true);

			if (!remove)
			{
				return;
			}

			orderManager.RemoveOrder(responseFind.OriginalOrder);
			return;
		}
	}
}
