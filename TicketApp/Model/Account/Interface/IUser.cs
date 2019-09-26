using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp.Model.Account.Interface
{
    public interface IUser
    {
        int Id { get; set; }
        string AccountName { get; set; }
        int AccountTypeId { get; set; }
        string Password { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
}
