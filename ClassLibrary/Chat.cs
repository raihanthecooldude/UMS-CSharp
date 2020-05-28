using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Chat
    {
        private string accountId;
        private string accountName;
        private string msg;

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public string AccountName
        {
            get { return accountName; }
            set { accountName = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
