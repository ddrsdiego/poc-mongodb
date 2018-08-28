using System.Threading.Tasks;

namespace Easynvest.poc.Mongodb.Publisher.Domain.CustomerAggregate
{
    public interface ICustomerRepository
    {
        Task Create(Customer customer);

        Task Update(Customer customer);

        Task<Customer> Get(string customerId);
    }
}
