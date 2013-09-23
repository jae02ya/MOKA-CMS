using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MokaCms.Services;
using NUnit.Framework;

namespace MokaCms.Web.UI.Tests
{
	[TestFixture]
	public class AccountServiceTest
	{
		#region SetUp / TearDown

		[SetUp]
		public void Init()
		{ }

		[TearDown]
		public void Dispose()
		{ }

		#endregion

		#region Tests

		[Test]
		[TestCase("robin", "robin", true)]
		[TestCase("patrick", "patrick", true)]
        [TestCase("hayley", "harold", true)]

		public void Login_GivenUsernamePassword_LoginConfirmed(string username, string password, bool result)
		{
			var account = new AccountService();
			var authenticated = account.Authenticate(username, password);

			Assert.AreEqual(result, authenticated);
		}

		#endregion
	}
}
