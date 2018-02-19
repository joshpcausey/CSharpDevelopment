using SGFlooring.Models;
using SGFlooring.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Data
{
	public class FileTestRepository : IOrderRepository
	{
		string path = @"C:\Repos\joshua-causey-individual-work\FlooringMastry\order_";
		public List<Order> EditOrder(string customerName, string state, string productType, int area)
		{
			throw new NotImplementedException();
		}

		public List<Order> FindOrder(string date, int orderNumber)
		{
			List<Order> returnOrders = new List<Order>();
			DateTime dateDT = DateTime.Parse(date);
			string dateString = dateDT.ToString("MMddyyyy");
			string fileName = path + dateString + ".txt";
			if (File.Exists(fileName))
			{
				string[] rows = File.ReadAllLines(path + dateString + ".txt");
				int rowOrderIsAt = int.MinValue;
				for(int i = 0; i < rows.Length; i++)
				{
					if(int.Parse(rows[i].Split(',')[0]) == orderNumber)
					{
						rowOrderIsAt = i;
					}
				}
				if(rowOrderIsAt >= 0)
				{
					Order matchingOrder = new Order();
					string[] rowsOfFile = File.ReadAllLines(path + dateString + ".txt");
					string[] columns = rowsOfFile[rowOrderIsAt].Split(',');
					matchingOrder.OrderNumber = int.Parse(columns[0]);
					matchingOrder.CustomerName = columns[1];
					matchingOrder.State = columns[2];
					matchingOrder.TaxRate = decimal.Parse(columns[3]);
					matchingOrder.ProductType = columns[4];
					matchingOrder.Area = decimal.Parse(columns[5]);
					matchingOrder.CostPerSquareFoot = decimal.Parse(columns[6]);
					matchingOrder.LaborCostPerSquareFoot = decimal.Parse(columns[7]);
					matchingOrder.MaterialCost = decimal.Parse(columns[8]);
					matchingOrder.LaborCost = decimal.Parse(columns[9]);
					matchingOrder.Tax = decimal.Parse(columns[10]);
					matchingOrder.Total = decimal.Parse(columns[11]);
					matchingOrder.OrderDate = date;
					returnOrders.Add(matchingOrder);
				}
				else
				{
					return returnOrders;
				}
			}
			else
			{
				return returnOrders;
			}
			return returnOrders;
		}

		public List<Order> LoadOrder(string date)
		{
			List<Order> returnOrders = new List<Order>();
			DateTime dateDT = DateTime.Parse(date);
			string dateString = dateDT.ToString("MMddyyyy");
			string fileName = path + dateString;
			if (File.Exists(path + dateString + ".txt"))
			{
				string[] rows = File.ReadAllLines(path + dateString + ".txt");
				foreach (var row in rows)
				{
					Order orderToAdd = new Order();
					string[] columns = row.Split(',');
					orderToAdd.OrderNumber = int.Parse(columns[0]);
					orderToAdd.CustomerName = columns[1];
					orderToAdd.State = columns[2];
					orderToAdd.TaxRate = decimal.Parse(columns[3]);
					orderToAdd.ProductType = columns[4];
					orderToAdd.Area = decimal.Parse(columns[5]);
					orderToAdd.CostPerSquareFoot = decimal.Parse(columns[6]);
					orderToAdd.LaborCostPerSquareFoot = decimal.Parse(columns[7]);
					orderToAdd.MaterialCost = decimal.Parse(columns[8]);
					orderToAdd.LaborCost = decimal.Parse(columns[9]);
					orderToAdd.Tax = decimal.Parse(columns[10]);
					orderToAdd.Total = decimal.Parse(columns[11]);
					orderToAdd.OrderDate = date;
					returnOrders.Add(orderToAdd);
				}
				return returnOrders;
			}
			else
			{
				return returnOrders;
			}
		}

		public void OverRideOrder(Order order)
		{
			DateTime dateDT = DateTime.Parse(order.OrderDate);
			string dateString = dateDT.ToString("MMddyyyy");
			string fileName = path + dateString + ".txt";
			string orderToWrite = $"{order.OrderNumber},{order.CustomerName},{order.State},{order.TaxRate},{order.ProductType},{order.Area},{order.CostPerSquareFoot},{order.LaborCostPerSquareFoot}," +
				$"{order.MaterialCost},{order.LaborCost},{order.Tax},{order.Total}";

			string[] rows = File.ReadAllLines(path + dateString + ".txt");
			int lineToEdit = 0;
			foreach (var row in rows)
			{
				string[] columns = row.Split(',');
				if (int.Parse(columns[0]) == order.OrderNumber)
				{
					string[] arrLine = File.ReadAllLines(fileName);
					arrLine[lineToEdit] = orderToWrite;
					File.WriteAllLines(fileName, arrLine);
					break;
				}
				lineToEdit += 1;

			}
		}

		public void RemoveOrder(Order order)
		{
			DateTime dateDT = DateTime.Parse(order.OrderDate);
			string dateString = dateDT.ToString("MMddyyyy");
			string fileName = path + dateString + ".txt";

			string[] rows = File.ReadAllLines(path + dateString + ".txt");
			int rowOrderIsAt = int.MinValue;
			for (int i = 0; i < rows.Length; i++)
			{
				if (int.Parse(rows[i].Split(',')[0]) == order.OrderNumber)
				{
					rowOrderIsAt = i;
				}
			}

			var file = new List<string>(File.ReadAllLines(fileName));
			file.RemoveAt(rowOrderIsAt);
			File.WriteAllLines(fileName, file.ToArray());
		}

		public void SaveOrder(Order order)
		{
			DateTime dateDT = DateTime.Parse(order.OrderDate);
			string dateString = dateDT.ToString("MMddyyyy");
			string fileName = path + dateString;
			string orderToWrite = $"{order.OrderNumber},{order.CustomerName},{order.State},{order.TaxRate},{order.ProductType},{order.Area},{order.CostPerSquareFoot},{order.LaborCostPerSquareFoot}," +
				$"{order.MaterialCost},{order.LaborCost},{order.Tax},{order.Total}";
			string filePath = path + dateString + ".txt";
			using (StreamWriter sw = new StreamWriter(filePath, true))
			{
				sw.WriteLine(orderToWrite);
			}
		}
	}
}
