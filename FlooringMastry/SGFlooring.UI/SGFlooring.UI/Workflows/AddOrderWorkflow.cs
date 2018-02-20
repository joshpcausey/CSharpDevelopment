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

			string date = ConsoleIO.GetDate();

			string name = ConsoleIO.GetName();

			string state = ConsoleIO.GetState();

			string productType = ConsoleIO.GetProductType();

			string area = ConsoleIO.GetArea();

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
