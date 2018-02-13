using SGFlooring.BLL;
using SGFlooring.Models;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI.Workflows
{
	public static class AddOrderWorkflow
	{
		public static void Execute()
		{
			Console.Clear();
			OrderManager orderManager = OrderManagerFactory.Create();

			Console.Write("Enter an Order Date: ");
			string date = Console.ReadLine();

			Console.Write("Enter a Customer Name: ");
			string name = Console.ReadLine();

			Console.Write("Enter a State: ");
			string state = Console.ReadLine();

			Console.Write("Enter a Product Type: ");
			string productType = Console.ReadLine();

			Console.Write("Enter an Area: ");
			decimal area = decimal.Parse(Console.ReadLine());

			AddOrderResponse response = orderManager.AddOrder(date, name, state, productType, area);

			if (response.Success)
			{
				Console.WriteLine(response.Message);
			}
			else
			{
				Console.WriteLine(response.Message);
			}

			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
		}
	}
}
