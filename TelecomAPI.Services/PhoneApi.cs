using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelecomAPI.Domain;
using TelecomAPI.Business;
using TelecomAPI.Domain.Model.Request;
using TelecomAPI.Domain.Model.Response;

namespace TelecomAPI.Services
{
    public class PhoneApi : IPhoneApi
    {
        Repository r = new Repository();
        public PhoneApi()
        {

        }
        public List<string> GetAllPhoneNumbers()
        {
            return r.GetAllPhoneNumbers();
        }

        public List<string> GetCustomerPhoneNumbers(int customerId)
        {
            return r.GetCustomerPhoneNumbers(customerId);
        }

        public CustomerResponseModel ActivateCustomerPhoneNumbers(CustomerRequestModel customerRequestModel)
        {
            return r.ActivateNumber(customerRequestModel);
        }
    }
}
