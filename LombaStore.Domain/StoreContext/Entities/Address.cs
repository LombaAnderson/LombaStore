using LombaStore.Domain.StoreContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LombaStore.Domain.StoreContext.Entities
{
    public class Address
    {

        public Address(string street,
            string number,
            string complement,
            string district,
            )
        {

        }



        public string Street { get; private set; }

        public string Number { get; private set; }

        public string Complement { get; private set; }

        public string City { get; private set; }

        public string State { get; private set; }

        public string Country { get; private set; }

        public string ZipCode { get; private set; }

        public EAddressType Type { get; private set; }
    }
}
