﻿using SGBank.BLL;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.UI.Workflows
{
	public class DepositWorkflow
	{
		public void Execute()
		{
			Console.Clear();
			AccountManager accountManager = AccountManagerFactory.Create();

			Console.Write("Enter an account number: ");
			string accountNumber = Console.ReadLine();

			bool parsedDecimal = true;
			decimal amount;
			do
			{
				Console.Write("Enter a deposit withdraw: ");
				decimal result;
				bool parsed = decimal.TryParse(Console.ReadLine(), out result);
				if (parsed)
				{
					parsedDecimal = false;
				}
				amount = result;
			} while (parsedDecimal);

			AccountDepositResponse response = accountManager.Deposit(accountNumber, amount);

			if (response.Success)
			{
				Console.WriteLine("Deposit completed!");
				Console.WriteLine($"Account Number: {response.Account.AccountNumber}");
				Console.WriteLine($"Old balance: {response.OldBalance:c}");
				Console.WriteLine($"Amount Deposited: {response.Amount:c}");
				Console.WriteLine($"New balance: {response.Account.Balance:c}");
			}
			else
			{
				Console.WriteLine("An error occurred: ");
				Console.WriteLine(response.Message);
			}

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();

		}
	}
}
