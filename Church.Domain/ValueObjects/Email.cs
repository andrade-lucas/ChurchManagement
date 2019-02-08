using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Church.Domain.ValueObjects
{
    public class Email
    {
        public string Address { get; private set; }

        public Email()
        {
        }

        public Email(string address)
        {
            Address = address;
        }
    }
}
