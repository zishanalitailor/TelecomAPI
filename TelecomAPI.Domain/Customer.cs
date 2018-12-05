using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelecomAPI.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public List<CustomerPhoneNumber> PhoneNumbers { get; set; }
    }
}
