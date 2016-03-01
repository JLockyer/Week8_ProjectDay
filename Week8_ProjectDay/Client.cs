using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_ProjectDay
{
    class Client
    {
        //Fields
        public string name;
        public int accountNum;

        //Constructors
        public Client(string fullname, int accountNum)
        {
            this.name = fullname;
            this.accountNum = accountNum;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNum; }
            set { this.accountNum = value; }
        }

        //Methods
        public void ClientInfo()
        {
            Random rand = new Random();
            for (int number = 1; number <= 1; number++)
            {
                int randomNum = rand.Next(100000000, 1000000000);
            }

            StringBuilder info = new StringBuilder();

        }

    }
}
