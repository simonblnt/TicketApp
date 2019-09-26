using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Model.Ticket.Interface;

namespace TicketApp.Model.Ticket.Entity
{
    public class TicketType : ObservableObject, ITicketType
    {
        private int _id;
        private string _name;
        private int _price;

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
        public int Price
        {
            get { return _price; }
            set { Set(ref _price, value); }
        }
    }
}
