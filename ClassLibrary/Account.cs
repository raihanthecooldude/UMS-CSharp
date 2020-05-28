using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Account
    {
        private string accountId;
        private string password;
        private string name;
        private string dob;
        private string bloodGroup;
        private string gender;
        private string address;
        private string accountType;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string BloodGroup
        {
            get { return bloodGroup; }
            set { bloodGroup = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

    }
}
