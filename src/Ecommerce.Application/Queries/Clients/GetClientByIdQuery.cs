using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Queries.Clients
{
    public class GetClientByIdQuery : IRequest<Client>
    {
        public int Id { get; set; }
    }
}
