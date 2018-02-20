using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.UI
{
	public class ConsoleIO
	{
		public static string GetDate()
		{
			Console.Write("Enter an Order Date: ");
			return Console.ReadLine();
		}

		public static string GetName()
		{
			Console.Write("Enter a Customer Name: ");
			return Console.ReadLine();
		}

		public static string GetProductType()
		{
			Console.Write("Enter a Product Type: ");
			return Console.ReadLine();
		}

		public static string GetArea()
		{
			Console.Write("Enter an Area: ");
			return Console.ReadLine();
		}

		public static string GetState()
		{
			Console.Write("Enter a Sate: ");
			return Console.ReadLine();
		}
	}
}
