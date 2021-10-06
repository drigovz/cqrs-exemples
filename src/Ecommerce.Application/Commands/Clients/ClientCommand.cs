using Ecommerce.Application.Clients.Commands;
using MediatR;

namespace Ecommerce.Application.Commands.Clients
{
    public abstract class ClientCommand : IRequest<ResponseCommand>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
