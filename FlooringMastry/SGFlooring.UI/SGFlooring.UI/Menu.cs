using SGFlooring.UI.Workflows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI
{
	class Menu
	{
		public static void Run()
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Make a Selection");
				Console.WriteLine("1. Display Orders");
				Console.WriteLine("2. Add an Order");
				Console.WriteLine("3. Edit an Order");

				string userInput = Console.ReadLine();

				switch (userInput)
				{
					case "1":
						LoadOrderWorkflow.Execute();
						break;
					case "2":
						AddOrderWorkflow.Execute();
						break;
					case "3":
						EditOrderWorkflow.Execute();
						break;
					case "4":
						RemoveOrderWorkflow.Execute():
						break;
				}
			}
		}
	}
}
