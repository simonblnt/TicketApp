using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Model.Ticket.Interface;

namespace TicketApp.Model.Ticket.Entity
{
    class Location : ObservableObject, ILocation
    {
        private int _id;
        private string _name;

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
    }
}
