using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Model.Ticket.Interface
{
    public interface ILocation
    {
        int Id { get; set; }
        string Name { get; set; }
    }
}
