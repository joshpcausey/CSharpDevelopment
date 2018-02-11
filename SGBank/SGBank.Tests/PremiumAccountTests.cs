using NUnit.Framework;
using SGBank.BLL.DepositRules;
using SGBank.BLL.WithdrawRules;
using SGBank.Models;
using SGBank.Models.Interfaces;
using SGBank.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Tests
{
	public class PremiumAccountTests
	{
		[TestCase("4444", "Premium Account", 100, AccountType.Free, 250, false)]
		[TestCase("4444", "Premium Account", 100, AccountType.Premium, -100, false)]
		[TestCase("4444", "Premium Account", 100, AccountType.Premium, 250, true)]
		public void PremiumAccountDepositRuleTest(string accountNumber, string name, decimal balance, AccountType accountType,
			decimal amount, bool expectedResult)
		{
			Account account = new Account
			{
				AccountNumber = accountNumber,
				Name = name,
				Balance = balance,
				Type = accountType
			};

			NoLimitDepositRule manager = new NoLimitDepositRule();

			AccountDepositResponse response = manager.Deposit(account, amount);
			Assert.AreEqual(expectedResult, response.Success);
		}

		[TestCase("4444", "Premium Account", 1500, AccountType.Premium, -1000, 500, true)]
		[TestCase("4444", "Premium Account", 100, AccountType.Basic, -100, 100, false)]
		[TestCase("4444", "Premium Account", 100, AccountType.Premium, 100, 100, false)]
		[TestCase("4444", "Premium Account", 100, AccountType.Premium, -101, -1, true)]
		public void PremiumAccountWithdrawRuleTest(string accountNumber, string name, decimal balance, AccountType accountType,
			decimal amount, decimal newBalence, bool expectedResult)
		{
			Account account = new Account();
			account.AccountNumber = accountNumber;
			account.Name = name;
			account.Balance = balance;
			account.Type = accountType;

			IWithdraw manager = new PremiumAccountWithdrawRule();

			AccountWithdrawResponse response = manager.Withdraw(account, amount);
			Assert.AreEqual(expectedResult, response.Success);
			if (response.Success)
			{
				Assert.AreEqual(newBalence, account.Balance);
			}
		}
	}
}
