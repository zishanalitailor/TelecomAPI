using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomAPI.Domain.Model.Request
{
    public class CustomerRequestModel
    {
        public int CustomerId { get; set; }
        public string PhoneNumer { get; set; }
    }
}
