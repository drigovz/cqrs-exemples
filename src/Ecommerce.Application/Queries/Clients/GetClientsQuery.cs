using Ecommerce.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace Ecommerce.Application.Queries.Clients
{
    public class GetClientsQuery : IRequest<IEnumerable<Client>>
    { }
}
