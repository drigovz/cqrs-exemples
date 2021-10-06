using MediatR;

namespace Ecommerce.Application.Commands.Clients
{
    public class ClientRemoveCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
