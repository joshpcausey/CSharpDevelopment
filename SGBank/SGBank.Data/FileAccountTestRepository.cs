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
			string accountTypeToWrite = "Error";
			switch (account.Type)
			{
				case AccountType.Free:
					accountTypeToWrite = "F";
					break;
				case AccountType.Basic:
					accountTypeToWrite = "B";
					break;
				case AccountType.Premium:
					accountTypeToWrite = "P";
					break;
			}
			string[] rows = File.ReadAllLines(path);
			int lineToEdit = 0;
			foreach (var row in rows)
			{
				string[] columns = row.Split(',');
				if (columns[0] == account.AccountNumber)
				{
					string[] arrLine = File.ReadAllLines(path);
					arrLine[lineToEdit] = $"{account.AccountNumber},{account.Name},{account.Balance},{accountTypeToWrite}";
					File.WriteAllLines(path, arrLine);
					break;
				}
				lineToEdit += 1;
				
			}
		}
	}
}
