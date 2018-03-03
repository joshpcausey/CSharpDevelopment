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
	public class FileStateRepository : IStateRepository
	{
		string path = @"C:\Repos\joshua-causey-individual-work\FlooringMastry\Taxes.txt";
		public List<Tax> GetEveryState()
		{
			List<Tax> allTaxes = new List<Tax>();
			string[] rows = File.ReadAllLines(path);
			for(var i = 1; i < rows.Length; i++)
			{
				Tax singleTax = new Tax();
				string[] columns = rows[i].Split(',');
				singleTax.StateAbbreviation = columns[0];
				singleTax.StateName = columns[1];
				singleTax.TaxRate = decimal.Parse(columns[2]);
				allTaxes.Add(singleTax);
			}
			return allTaxes;
		}
	}
}
