using SGBank.Models;
using SGBank.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Data
{
	public class FileAccountTestRepository : IAccountRepository
	{
		string path = @"C:\Repos\joshua-causey-individual-work\SGBank\Accounts.txt";
		public Account LoadAccount(string AccountNumber)
		{
			Account returnAccount = new Account();
			string[] rows = File.ReadAllLines(path);

			foreach (var row in rows)
			{
				string[] columns = row.Split(',');
				if (columns[0] == AccountNumber)
				{
					returnAccount.AccountNumber = columns[0];
					returnAccount.Name = columns[1];
					returnAccount.Balance = int.Parse(columns[2]);
					switch (columns[3])
					{
						case "F":
							returnAccount.Type = AccountType.Free;
							break;
						case "B":
							returnAccount.Type = AccountType.Basic;
							break;
						case "P":
							returnAccount.Type = AccountType.Premium;
							break;
					}
				}
			}
			if (returnAccount.AccountNumber != AccountNumber)
			{
				return null;
			}
			else
			{
				return returnAccount;
			}
		}

		public void SaveAccount(Account account)
		{
			string line = $"{account.AccountNumber},{account.Name},{account.Balance},{account.Type.ToString()[0]}";
			string[] everyLine = File.ReadAllLines(path);

			using (StreamWriter writer = new StreamWriter(path))
			{
				foreach (var fileline in everyLine)
				{
					string[] columns = fileline.Split(',');

					if (account.AccountNumber == columns[0])
					{
						writer.WriteLine(line);
					}
					else
					{
						writer.WriteLine(fileline);
					}
				}
			}
		}
	}
}
