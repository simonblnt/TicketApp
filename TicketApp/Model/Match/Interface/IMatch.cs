using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Model.Match.Interface
{
    public interface IMatch
    {
        int Id { get; set; }
        string TeamHome { get; set; }
        string TeamAway { get; set; }
        int Income { get; set; }
    }
}
