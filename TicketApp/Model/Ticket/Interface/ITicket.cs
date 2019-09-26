using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Model.Ticket.Interface
{
    public interface ITicket
    {
        int Id { get; set; }
        int MatchId { get; set; }
        int LocationId { get; set; }
        int TicketTypeId { get; set; }
        bool IsSelected { get; set; }
        DateTime DateSelected { get; set; }
        bool IsOwned { get; set; }
        int UserId { get; set; }
        DateTime DateOwned { get; set; }
    }
}
