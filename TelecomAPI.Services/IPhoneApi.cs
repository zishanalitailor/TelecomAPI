using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TelecomAPI.Domain;
using TelecomAPI.Domain.Model.Request;
using TelecomAPI.Domain.Model.Response;

namespace TelecomAPI.Services
{
    public interface IPhoneApi
    {
        List<string> GetAllPhoneNumbers();
        List<string> GetCustomerPhoneNumbers(int customerId);
        CustomerResponseModel ActivateCustomerPhoneNumbers(CustomerRequestModel customerRequestModel);

    }
}
