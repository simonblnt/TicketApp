using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Model.Account.Interface
{
    interface IAccountType
    {
        int Id { get; set; }
        string Name { get; set; }
        bool IsAdmin { get; set; }
    }
}
