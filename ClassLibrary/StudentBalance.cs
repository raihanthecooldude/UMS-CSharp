using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class StudentBalance
    {
        private string accountId;
        private string semester;
        private string scholarship;
        private double balance;
        private string validation;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public string Scholarship
        {
            get { return scholarship; }
            set { scholarship = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string Validation
        {
            get { return validation; }
            set { validation = value; }
        }
    }
}
