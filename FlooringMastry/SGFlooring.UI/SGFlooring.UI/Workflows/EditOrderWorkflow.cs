using SGFlooring.BLL;
using SGFlooring.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI.Workflows
{
	public class EditOrderWorkflow
	{
		public static void Execute()
		{
			Console.Clear();
			OrderManager orderManager = OrderManagerFactory.Create();
			EditOrderResponse responseEdit = new EditOrderResponse();
			FindOrderResponse responseFind = new FindOrderResponse();

			Console.Write("Enter an order date: ");
			string date = Console.ReadLine();
		
			Console.Write("Enter an order number: ");
			string orderNumber = Console.ReadLine();

			responseFind = orderManager.FindOrder(date, orderNumber);

			if(responseFind.Success == false)
			{
				Console.WriteLine(responseFind.Message);
				Console.WriteLine("Press any key to contine...");
				Console.ReadKey();
				return;
			}

			Console.Write($"{responseFind.OriginalOrder.CustomerName}: ");
			string editedName = Console.ReadLine();
			Console.Write($"{responseFind.OriginalOrder.State}: ");
			string editedState = Console.ReadLine();
			Console.Write($"{responseFind.OriginalOrder.ProductType}: ");
			string editedProductType = Console.ReadLine();
			Console.Write($"{responseFind.OriginalOrder.Area}: ");
			string editedAreaString = Console.ReadLine();

			if(!int.TryParse(editedAreaString, out int editedArea))
			{
				Console.WriteLine($"Not a valid Area. You typed {editedAreaString}");
				Console.WriteLine("Press any key to contine...");
				Console.ReadKey();
				return;
			}

			//else if(!Enum.IsDefined(typeof(State), editedState))
			//{
			//	Console.WriteLine($"Not a valid State. You typed {editedState}");
			//	Console.WriteLine("Press any key to contine...");
			//	Console.ReadKey();
			//	return;
			//}

			//else if(!Enum.IsDefined(typeof(Product), editedProductType))
			//{
			//	Console.WriteLine($"Not a valid Product. You typed {editedProductType}");
			//	Console.WriteLine("Press any key to contine...");
			//	Console.ReadKey();
			//	return;
			//}
			decimal taxRate;
			switch (editedState)
			{
				case "OH":
					taxRate = 6.25M;
					break;
				case "PA":
					taxRate = 6.75M;
					break;
				case "MI":
					taxRate = 5.75M;
					break;
				default:
					taxRate = 6.00M;
					break;
			}

			decimal costPerSquareFoot = decimal.MinValue;
			switch (editedProductType)
			{
				case "Carpet":
					costPerSquareFoot = 2.25M;
					break;
				case "Laminate":
					costPerSquareFoot = 1.75M;
					break;
				case "Tile":
					costPerSquareFoot = 3.50M;
					break;
				case "Wood":
					costPerSquareFoot = 5.15M;
					break;
			}

			decimal laborCostPerSquareFoot = decimal.MinValue;
			switch (editedProductType)
			{
				case "Carpet":
					laborCostPerSquareFoot = 2.10M;
					break;
				case "Laminate":
					laborCostPerSquareFoot = 2.10M;
					break;
				case "Tile":
					laborCostPerSquareFoot = 4.15M;
					break;
				case "Wood":
					laborCostPerSquareFoot = 4.75M;
					break;
			}

			responseFind.CopyOrder.CustomerName = editedName;
			responseFind.CopyOrder.State = editedState;
			responseFind.CopyOrder.TaxRate = taxRate;
			responseFind.CopyOrder.ProductType = editedProductType;
			responseFind.CopyOrder.Area = editedArea;
			responseFind.CopyOrder.CostPerSquareFoot = costPerSquareFoot;
			responseFind.CopyOrder.LaborCostPerSquareFoot = laborCostPerSquareFoot;
			responseFind.CopyOrder.MaterialCost = responseFind.CopyOrder.Area * responseFind.CopyOrder.CostPerSquareFoot;
			responseFind.CopyOrder.LaborCost = responseFind.CopyOrder.Area * responseFind.CopyOrder.LaborCostPerSquareFoot;
			responseFind.CopyOrder.Tax = responseFind.CopyOrder.LaborCost + responseFind.CopyOrder.MaterialCost * (responseFind.CopyOrder.TaxRate / 100M);
			responseFind.CopyOrder.Total = responseFind.CopyOrder.MaterialCost + responseFind.CopyOrder.LaborCost + responseFind.CopyOrder.Tax;

			Console.Clear();

			Console.WriteLine("ORIGINAL ORDER");
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

			Console.WriteLine("EDITED ORDER");
			Console.WriteLine("===================");
			Console.WriteLine($"{responseFind.CopyOrder.OrderNumber} | {responseFind.CopyOrder.OrderDate}");
			Console.WriteLine(responseFind.CopyOrder.CustomerName);
			Console.WriteLine(responseFind.CopyOrder.State);
			Console.WriteLine(responseFind.CopyOrder.ProductType);
			Console.WriteLine(responseFind.CopyOrder.MaterialCost);
			Console.WriteLine(responseFind.CopyOrder.LaborCost);
			Console.WriteLine(responseFind.CopyOrder.Tax);
			Console.WriteLine(responseFind.CopyOrder.Total);
			Console.WriteLine();


			bool overRide = false;		
			do
			{
				Console.WriteLine("Are you sure you want to override? Type 'y' for yes or 'n' for no");
				string userInputOverride = Console.ReadLine();
				if (userInputOverride == "y")
				{
					overRide = true;
					break;
				}
				else if (userInputOverride == "n")
				{
					break;
				}
			} while (true);

			if (!overRide)
			{
				return;
			}

			orderManager.OverRideOrder(responseFind.CopyOrder);
		}
	}
}
