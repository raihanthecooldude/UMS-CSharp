using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher
    {
        private string accountId;
        private int weekHour;
        private string status;
        private double salary;


        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public int WeekHour
        {
            get { return weekHour; }
            set { weekHour = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
