using Easynvest.poc.Mongodb.Publisher.Domain.CustomerAggregate;
using Easynvest.poc.Mongodb.Publisher.Infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Easynvest.poc.Mongodb.Publisher.Infra.IoC
{
    public static class PublisherServicesContainerEx
    {
        public static IServiceCollection AddPublisherServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerInMemoryRepository>();
            return services;
        }
    }
}