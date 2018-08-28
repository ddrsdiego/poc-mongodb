using System;
using System.Collections.Generic;

namespace Easynvest.poc.Mongodb.Publisher.Domain.CustomerAggregate
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}
