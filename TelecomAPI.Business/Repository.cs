using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelecomAPI.Domain;
using TelecomAPI.Domain.Model.Request;
using TelecomAPI.Domain.Model.Response;

namespace TelecomAPI.Business
{
    public class Repository
    {
        private List<Customer> customerList = new List<Customer>()
        {
            new Customer()
            {
                CustomerId = 1,
                PhoneNumbers = new List<CustomerPhoneNumber>()
                {
                    new CustomerPhoneNumber() { PhoneNumber = "112345671"  },
                    new CustomerPhoneNumber() { PhoneNumber = "123456761"  },
                    new CustomerPhoneNumber() { PhoneNumber = "112345778"  }
                }
            },
            new Customer()
            {
                CustomerId = 2,
                PhoneNumbers = new List<CustomerPhoneNumber>()
                {
                    new CustomerPhoneNumber() { PhoneNumber = "312345671"},
                    new CustomerPhoneNumber() { PhoneNumber = "323456761"},
                    new CustomerPhoneNumber() { PhoneNumber = "312345778" },
                    new CustomerPhoneNumber() { PhoneNumber = "323456364"}
                }
            }
        };

        public Repository()
        {

        }

        public List<string> GetAllPhoneNumbers()
        {
            var customers = customerList.SelectMany(x => x.PhoneNumbers).Distinct();
            return customers.Select(r => r.PhoneNumber).ToList();
        }

        public List<string> GetCustomerPhoneNumbers(int customerId)
        {
            var customer = customerList.Where(x => x.CustomerId == customerId).SelectMany(r => r.PhoneNumbers);
            return customer.Select(r => r.PhoneNumber).ToList();
        }

        public CustomerResponseModel ActivateNumber(CustomerRequestModel customerRequestModel)
        {
            CustomerResponseModel model = new CustomerResponseModel();
            try
            {
                Customer customer = customerList.FirstOrDefault(r => r.CustomerId == customerRequestModel.CustomerId);
                List<CustomerPhoneNumber> phoneNumberList = customer.PhoneNumbers.ToList();
                phoneNumberList.Add(new CustomerPhoneNumber { PhoneNumber = customerRequestModel.PhoneNumer });

                customerList.Remove(customer);
                customerList.Add(new Customer { CustomerId = customerRequestModel.CustomerId, PhoneNumbers = phoneNumberList });

                model.CustomerId = customerRequestModel.CustomerId;
                model.PhoneNumbers = phoneNumberList;
                model.isActivated = true;
            }
            catch (Exception ex)
            {
                model.isActivated = false;
            }

            return model;
        }
    }
}
