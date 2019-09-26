using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketApp.Model.Account.Interface;

namespace TicketApp.Model.Account.Entity
{
    class User : ObservableObject, IUser
    {
        private int _id;
        private string _accountName;
        private int _accountTypeId;
        private string _password;
        private string _firstName;
        private string _lastName;

        public int Id
        {
            get { return _id; }
            set { Set(ref _id, value); }
        }
        public string AccountName
        {
            get { return _accountName; }
            set { Set(ref _accountName, value); }
        }
        public int AccountTypeId
        {
            get { return _accountTypeId; }
            set { Set(ref _accountTypeId, value); }
        }
        public string Password
        {
            get { return _password; }
            set { Set(ref _password, value); }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { Set(ref _firstName, value); }
        }
        public string LastName
        {
            get { return _lastName; }
            set { Set(ref _lastName, value); }
        }
    }
}
