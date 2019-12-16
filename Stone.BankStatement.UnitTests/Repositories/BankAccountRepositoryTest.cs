using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stone.BankStatement.Repository.Implemations;

namespace Stone.BankStatement.UnitTests.Repositories
{
    [TestClass]
    public class BankAccountRepositoryTest
    {
        [TestMethod]
        public void Should_Return_Success_When_Exists_Banks()
        {
            var repository = new BankAccountRepository();
            var banksAccounts = repository.GetByDate(DateTime.Now, DateTime.Now);

            Assert.IsTrue(banksAccounts.Result.Count > 0);
        }

        [TestMethod]
        public void Should_Return_Success_When_Not_Exists_Banks()
        {
            var repository = new BankAccountRepository();
            var banksAccounts = repository.GetByDate(DateTime.Now.AddDays(1), DateTime.Now.AddDays(1));

            Assert.IsTrue(banksAccounts.Result.Count == 0);
        }
    }
}
