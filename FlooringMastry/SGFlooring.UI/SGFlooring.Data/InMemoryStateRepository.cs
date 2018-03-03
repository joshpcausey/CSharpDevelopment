using SGFlooring.Models;
using SGFlooring.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Data
{
	public class InMemoryStateRepository : IStateRepository
	{
		///OH, PA, MI, IN
		static List<Tax> allTaxAndState = new List<Tax>
		{
			new Tax
			{
				StateAbbreviation = "OH",
				StateName = "Ohio",
				TaxRate = 6.25M
			},

			new Tax
			{
				StateAbbreviation = "PA",
				StateName = "Pennsylvania",
				TaxRate = 6.75M
			},

			new Tax
			{
				StateAbbreviation = "MI",
				StateName = "Michigan",
				TaxRate = 5.75M
			},

			new Tax
			{
				StateAbbreviation = "IN",
				StateName = "Indiana",
				TaxRate = 6.00M
			}
		};

		public List<Tax> GetEveryState()
		{
			return allTaxAndState;
		}
	}
}
