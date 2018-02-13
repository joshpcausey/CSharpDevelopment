using SGFlooring.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.BLL
{
	public static class OrderManagerFactory
	{
		public static OrderManager Create()
		{
			string mode = ConfigurationManager.AppSettings["Mode"].ToString();

			switch (mode)
			{
				case "Memory":
					return new OrderManager(new MemoryTestRepository());
			}
			throw new NotImplementedException();
		}
	}
}
