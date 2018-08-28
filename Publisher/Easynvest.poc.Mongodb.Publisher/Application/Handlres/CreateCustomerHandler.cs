using Easynvest.poc.Mongodb.Common;
using Easynvest.poc.Mongodb.Publisher.Application.Commands;
using Easynvest.poc.Mongodb.Publisher.Application.Responses;
using Easynvest.poc.Mongodb.Publisher.Domain.CustomerAggregate;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Easynvest.poc.Mongodb.Publisher.Application.Handlres
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerCommand, Response<CreateCustomerResponse>>
    {
        private Customer _customer;

        public CreateCustomerHandler()
        {

        }

        public async Task<Response<CreateCustomerResponse>> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                _customer = new Customer
                {
                    Email = request.Email,
                    Name = request.CustomerName
                };

                //Publicar o Customer

                return Response<CreateCustomerResponse>.Ok(new CreateCustomerResponse());
            });
        }
    }
}