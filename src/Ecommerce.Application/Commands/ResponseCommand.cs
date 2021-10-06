using Ecommerce.Application.Notifications;
using System.Collections.Generic;

namespace Ecommerce.Application.Clients.Commands
{
    public class ResponseCommand
    {
        public dynamic Result { get; set; } = default;

        public IEnumerable<Notification> Notifications { get; set; }
    }
}