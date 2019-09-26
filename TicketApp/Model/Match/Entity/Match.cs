using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Model.Match.Interface;

namespace TicketApp.Model.Match.Entity
{
    class Match : ObservableObject, IMatch
    {
        private int _id;
        private string _teamHome;
        private string _teamAway;
        private int _income;

        public int Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
        public string TeamHome
        {
            get { return _teamHome; }
            set { Set(ref _teamHome, value); }
        }
        public string TeamAway
        {
            get { return _teamAway; }
            set { Set(ref _teamAway, value); }
        }
        public int Income
        {
            get { return _income; }
            set { Set(ref _income, value); }
        }
    }
}
