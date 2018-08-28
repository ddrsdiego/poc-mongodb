using Easynvest.poc.Mongodb.Common;
using Easynvest.poc.Mongodb.Publisher.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace Easynvest.poc.Mongodb.Publisher.Application.Commands
{
    public class CreateCustomerCommand : IRequest<Response<CreateCustomerResponse>>
    {
        public CreateCustomerCommand(string requestId, string customerName, string email, IEnumerable<CreateCustomerAddress> addresses)
        {
            RequestId = requestId;
            CustomerName = customerName;
            Email = email;
            Addresses = addresses;
        }

        public string RequestId { get; }
        public string CustomerName { get; }
        public string Email { get; }
        public IEnumerable<CreateCustomerAddress> Addresses { get; }
    }

    public class CreateCustomerAddress
    {
        public string Address { get; set; }
        public string Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
