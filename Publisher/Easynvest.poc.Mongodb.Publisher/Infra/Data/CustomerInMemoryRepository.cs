using Easynvest.poc.Mongodb.Publisher.Domain.CustomerAggregate;
using System;
using System.Threading.Tasks;

namespace Easynvest.poc.Mongodb.Publisher.Infra.Data
{
    public class CustomerInMemoryRepository : ICustomerRepository
    {
        public CustomerInMemoryRepository()
        {

        }

        public Task Create(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Get(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
