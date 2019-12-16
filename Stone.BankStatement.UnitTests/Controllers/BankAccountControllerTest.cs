using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stone.BankStatement.Domain.Enums;
using Stone.BankStatement.Repository.Implemations;
using Stone.BankStatement.WebApi.Models;

namespace Stone.BankStatement.UnitTests.Controllers
{
    [TestClass]
    public class BankAccountControllerTest
    {
        [TestMethod]
        public void Should_Return_Success_When_Valid_Address_Model()
        {
            var address = new AddressModel();
            address.City = "Rio de Janeiro";
            address.Country = "Brasil";
            address.Neighborhood = "Campo Grande";
            address.Number = 55;
            address.Street = "Rua Argoin";

            var context = new ValidationContext(address, null, null);
            var results = new List<ValidationResult>();
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(AddressModel), typeof(AddressModel)), typeof(AddressModel));

            var isModelStateValid = Validator.TryValidateObject(address, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void Should_Return_Success_When_Valid_Client_Model()
        {
            var client = new ClientModel();
            client.Name = "Marlon";
            client.LastName = "Graciano Machado de Amorim";
            client.Type = (KindPerson)1;

            var context = new ValidationContext(client, null, null);
            var results = new List<ValidationResult>();
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(ClientModel), typeof(ClientModel)), typeof(ClientModel));

            var isModelStateValid = Validator.TryValidateObject(client, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }

        [TestMethod]
        public void Should_Return_Success_When_Valid_Bank_Model()
        {
            var client = new ClientModel();
            client.Name = "Marlon";
            client.LastName = "Graciano Machado de Amorim";
            client.Type = (KindPerson)1;

            var address = new AddressModel();
            address.City = "Rio de Janeiro";
            address.Country = "Brasil";
            address.Neighborhood = "Campo Grande";
            address.Number = 55;
            address.Street = "Rua Argoin";

            var bankAccount = new BankAccountModel();
            bankAccount.AccountNumber = 12345;
            bankAccount.AgencyNumber = 1234;
            bankAccount.Type = (BankAccountType)1;
            bankAccount.Owner = client;
            bankAccount.Address = address;

            var context = new ValidationContext(bankAccount, null, null);
            var results = new List<ValidationResult>();
            TypeDescriptor.AddProviderTransparent(new AssociatedMetadataTypeTypeDescriptionProvider(typeof(BankAccountModel), typeof(BankAccountModel)), typeof(BankAccountModel));

            var isModelStateValid = Validator.TryValidateObject(bankAccount, context, results, true);

            Assert.IsTrue(isModelStateValid);
        }
    }
}
