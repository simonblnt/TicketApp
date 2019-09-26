using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight;
using System;
using TicketApp.Model.Account.Interface;

namespace TicketApp.Model.Account.Entity
{
    public class AccountType : ObservableObject, IAccountType
    {
        private int _id;
        private string _name;
        private bool _isAdmin;


        public int Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }
        public bool IsAdmin
        {
            get { return _isAdmin; }
            set { Set(ref _isAdmin, value); }
        }
    }
}
