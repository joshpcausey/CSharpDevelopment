using NUnit.Framework;
using SGBank.BLL;
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
	[TestFixture]
	public class FreeAccountTests
	{
		[Test]
		public void CanLoadFreeAccountTestData()
		{
			AccountManager manager = AccountManagerFactory.Create();

			AccountLookupResponse response = manager.LookupAccount("12345");

			Assert.IsNotNull(response.Account);
			Assert.IsTrue(response.Success);
			Assert.AreEqual("12345", response.Account.AccountNumber);
		}

		[TestCase("12345", "Free Account", 100, AccountType.Free, 250, false)]
		[TestCase("12345", "Free Account", 100, AccountType.Free, -100, false)]
		[TestCase("12345", "Free Account", 100, AccountType.Basic, 50, false)]
		[TestCase("12345", "Free Account", 100, AccountType.Free, 50, true)]
		public void FreeAccountDepositRuleTest(string accountNumber, string name, decimal balance, AccountType accountType,
			decimal amount, bool expectedResult)
		{
			Account account = new Account();
			account.AccountNumber = accountNumber;
			account.Name = name;
			account.Balance = balance;
			account.Type = accountType;

			FreeAccountDepositRule manager = new FreeAccountDepositRule();

			AccountDepositResponse response = manager.Deposit(account, amount);
			Assert.AreEqual(expectedResult, response.Success);
		}

		[TestCase("33333", "Free Account", 100, AccountType.Free, -100, 0, true)]
		[TestCase("33333", "Free Account", 200, AccountType.Free, 100, 200, false)]
		[TestCase("33333", "Basic Account", 150, AccountType.Basic, -50, 150, false)]
		[TestCase("33333", "Free Account", 100, AccountType.Free, -150, 100, false)]
		public void FreeAccountWithdrawRuleTest(string accountNumber, string name, decimal balance, AccountType accountType, decimal amount, decimal expectedBalance, bool expectedResult)
		{

			Account account = new Account()
			{

				AccountNumber = accountNumber,
				Name = name,
				Balance = balance,
				Type = accountType

			};

			IWithdraw withdrawResponse = new FreeAccountWithdrawRule();

			AccountWithdrawResponse response = withdrawResponse.Withdraw(account, amount);
			Assert.AreEqual(expectedResult, response.Success);
			if (response.Success)
			{
				Assert.AreEqual(expectedBalance, response.Account.Balance);
			}
		}
	}
}
