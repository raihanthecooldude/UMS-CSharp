using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Semester
    {
        private string semesterId;
        private string name;
        private string registrationStatus;

        public string SemesterId 
        {
            get { return semesterId; }
            set { semesterId = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public string RegistrationStatus
        {
            get { return registrationStatus; }
            set { registrationStatus = value; }
        }
    }
}
