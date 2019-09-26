using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Model.Ticket.Interface;

namespace TicketApp.Model.Ticket.Entity
{
    class Ticket : ObservableObject, ITicket
    {
        private int _id;
        private int _matchId;
        private int _locationId;
        private int _ticketTypeId;
        private bool _isSelected;
        private DateTime _dateSelected;
        private bool _isOwned;
        private int _userId;
        private DateTime _dateOwned;

        public int Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
        public int MatchId
        {
            get { return _matchId; }
            set { Set(ref _matchId, value); }
        }
        public int LocationId
        {
            get { return _locationId; }
            set { Set(ref _locationId, value); }
        }
        public int TicketTypeId
        {
            get { return _ticketTypeId; }
            set { Set(ref _ticketTypeId, value); }
        }
        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(ref _isSelected, value); }
        }
        public DateTime DateSelected
        {
            get { return _dateSelected; }
            set { Set(ref _dateSelected, value); }
        }
        public bool IsOwned
        {
            get { return _isOwned; }
            set { Set(ref _isOwned, value); }
        }
        public int UserId
        {
            get { return _userId; }
            set { Set(ref _userId, value); }
        }
        public DateTime DateOwned
        {
            get { return _dateOwned; }
            set { Set(ref _dateOwned, value); }
        }
    }
}
