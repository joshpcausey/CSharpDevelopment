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
		}
	}
}
