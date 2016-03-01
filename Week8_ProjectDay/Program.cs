using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week8_ProjectDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            List<string> Menu1 = new List<string>() { "\n\t1. Client Info", "\n\t2. View Account Balance", "\n\t3. Deposit", "\n\t4. Withdraw", "\n\t5. Exit"};
            string[] menu = Menu1.ToArray();
            
            Console.WriteLine("********** Bank Account System **********");
            Console.WriteLine("*****Please choose one of the following \"Menu Items\"*****");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine("\t" + menu[i]);
            }
            Clients client = new Clients();
            Account account = new Account();
            string optionMenu = Console.ReadLine().ToLower();
            switch (optionMenu)
            {
                case "1":
                case "client info":
                    Console.Clear();
                    client.ClientInfo();
                    Menu();
                    break;
                case "2":
                case "view account balance":
                    Console.Clear();
                    account.AccountBal();
                    Menu();
                    break;
                case "3":
                case "deposit":
                    Console.Clear();
                    account.Deposit();
                    Menu();
                    break;
                case "4":
                case "withdraw":
                    Console.Clear();
                    account.Withdraw();
                    Menu();
                    break;
                case "5":
                case "exit":
                    Console.Clear();
                    Exit();
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }

        }

        static void Exit()
        {
            Console.WriteLine("Thank you for banking with, MMM Bank. Have a wonderful day!");
            Console.ReadKey();
        }
    }

    class Clients
    {
        //Fields
        public string name = "Bob Jones";
        public int accountNum = AccountGen();

        //Constructors
        public Clients()
        {
            Name = name;
            AccountNum = accountNum;
        }

        // Properties
        public string Name { get; set; }
        public int AccountNum { get; set; }

        public static int AccountGen()
        {
            Random rand = new Random();
            int randAcc = rand.Next(100000000, 1000000000);
            return randAcc;
        }

        //Methods
        public void ClientInfo()
        {
            StreamWriter clInfo = new StreamWriter("AccountSummary.txt", true);
            using (clInfo)
            {
                clInfo.WriteLine(this.name);
                clInfo.WriteLine(this.accountNum);
                clInfo.Close();
            }
            Console.WriteLine("Account Name: " + this.name);
            Console.WriteLine("Account Number: " + this.accountNum);
        }

    }

    class Account
    {
        // Fields
        public double balance = 100;
        public double newBal;

        // Properties
        public double AccBal { get; set; }
        public double NewAccBal { get; set; }

        //Methods
        public void Deposit()
        {
            Console.WriteLine("Enter amount to deposit: ");
            double putIN = double.Parse(Console.ReadLine());
            double newBalance = this.balance + putIN;
            Console.WriteLine("Current Balance: " + newBalance);

            StringBuilder depos = new StringBuilder();
            StreamWriter depo = new StreamWriter("AccountSummary.txt", true);
            using (depo)
            {
                DateTime realTime = DateTime.Now;
                depo.WriteLine(realTime + "\t+" + "\t$" + putIN + "\t" + "\t $" + newBalance);
                depo.Close();
            }
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter amount to withdraw: ");
            double takeOut = double.Parse(Console.ReadLine());
            this.newBal = NewAccBal;
            this.newBal = this.balance - takeOut;
            Console.WriteLine("Current Balance: " + this.newBal);

            StreamWriter with = new StreamWriter("AccountSummary.txt", true);
            using (with)
            {
                DateTime realTime = DateTime.Now;
                with.WriteLine(realTime + "\t-" + "\t$" + takeOut + "\t" + "\t $" + this.newBal);
            }
        }

        public void AccountBal()
        {
            Console.WriteLine("Acount Balance: $" + this.balance);
        }

        // Constructor
        public Account()
        {
            AccBal = balance;
            NewAccBal = newBal;
        }
    }
}


