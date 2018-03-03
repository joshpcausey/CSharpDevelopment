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
	public class FileProductRepository : IProductRepository
	{
		string path = @"C:\Repos\joshua-causey-individual-work\FlooringMastry\Products.txt";
		public List<Product> GetAllProducts()
		{
			List<Product> allProducts = new List<Product>();
			string[] rows = File.ReadAllLines(path);
			for(int i = 1; i < rows.Length; i++)
			{
				Product singleProduct = new Product();
				string[] columns = rows[i].Split(',');
				singleProduct.ProductType = columns[0];
				singleProduct.CostPerSquareFoot = decimal.Parse(columns[1]);
				singleProduct.LaborCostPerSquareFoot = decimal.Parse(columns[2]);
				allProducts.Add(singleProduct);
			}
			return allProducts;
		}
	}
}
