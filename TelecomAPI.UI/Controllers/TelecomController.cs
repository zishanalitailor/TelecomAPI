using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TelecomAPI.Domain.Model.Request;
using TelecomAPI.Services;

namespace TelecomAPI.UI.Controllers
{
    public class TelecomController : ApiController
    {
        private readonly IPhoneApi _phoneApi;
        public TelecomController(IPhoneApi phoneApi)
        {
            this._phoneApi = phoneApi;
        }

        [HttpGet]
        public object GetAllPhoneNumbers()
        {
            return _phoneApi.GetAllPhoneNumbers();
        }

        [HttpGet]
        public object GetCustomerPhoneNumbers(int customerId)
        {
            return _phoneApi.GetCustomerPhoneNumbers(customerId);
        }

        [HttpPost]
        public object ActivateNumber(CustomerRequestModel customerRequestModel)
        {
            return _phoneApi.ActivateCustomerPhoneNumbers(customerRequestModel);
        }
    }
}
