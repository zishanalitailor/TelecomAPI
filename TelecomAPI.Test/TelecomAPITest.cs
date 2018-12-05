using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelecomAPI.Business;
using TelecomAPI.Domain.Model.Request;
using TelecomAPI.Domain.Model.Response;

namespace TelecomAPI.Test
{
    [TestClass]
    public class TelecomAPITest
    {
        [TestMethod]
        public void GetAllNumbers()
        {
            // Arrange
            List<string> expectedList = GetAllNumbersTest().ToList();

            // Act
            List<string> actualList = new Repository().GetAllPhoneNumbers().ToList();

            // Assert
            Assert.AreEqual(expectedList.Count, actualList.Count);
        }
        [TestMethod]
        public void GetCustomerPhoneNumbers()
        {
            // Arrange
            int customerId = 2;
            List<string> expectedList = GetCustomerPhoneNumbersTest().ToList();

            // Act
            List<string> actualList = new Repository().GetCustomerPhoneNumbers(customerId).ToList();

            // Assert
            Assert.AreEqual(expectedList.Count, actualList.Count);
        }
        [TestMethod]
        public void ActivateNumber()
        {
            // Arrange
            CustomerRequestModel requestModel = new CustomerRequestModel();
            requestModel.CustomerId = 2;
            requestModel.PhoneNumer = "9898989898";
            bool expectedFlag = true;

            // Act
            CustomerResponseModel responseModel = new Repository().ActivateNumber(requestModel);

            // Assert
            Assert.AreEqual(expectedFlag, responseModel.isActivated);

        }

        public List<string> GetAllNumbersTest()
        {
            List<string> list = new List<String>();
            list.Add("112345671");
            list.Add("123456761");
            list.Add("112345778"); 
            list.Add("312345671");
            list.Add("323456761");
            list.Add("312345778");
            list.Add("323456364");
            return list;
        }
        public List<string> GetCustomerPhoneNumbersTest()
        {
            List<string> list = new List<String>();
            list.Add("312345671");
            list.Add("323456761");
            list.Add("312345778");
            list.Add("323456364");
            return list;
        }
    }
}
