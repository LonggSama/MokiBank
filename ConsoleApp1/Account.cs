using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2_AP_Banking
{
    public class Account
    {
        List<double> DepositList = new List<double>();
        List<double> WithdrawList = new List<double>();
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public Account(string username, string password, double balance)
        {
            this.Username = username;
            this.Password = password;
            this.Balance = balance;
            Console.WriteLine("Username: {0}, Balance: {1}", username, Balance);
            Console.WriteLine("----------------------------------------------");
            AccountMenu();
        }
        public void AccountMenu()
        {
            double balance = Balance;
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw History");
            Console.WriteLine("4. Deposit History");
            Console.WriteLine("5. Logout");
            Console.WriteLine("-------------------");
            Console.WriteLine("Please enter your choice: ");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Withdraw();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    WithdrawHistory();
                    break;
                case 4:
                    DepositHistory();
                    break;
                case 5:
                    Logout();
                    break;
            }
        }
        public void Withdraw()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Available Balance: {0}", Balance);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("How much would you like to withdraw?: ");
                double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
                if (Balance < WithdrawAmount)
                {
                    Console.WriteLine("Can withdraw insufficient funds");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (WithdrawAmount <= 0)
                {
                    Console.WriteLine("Can withdraw invalid withdraw amount");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    WithdrawList.Add(WithdrawAmount);
                    Balance = Balance -= WithdrawAmount;
                    Console.WriteLine("Available Balance: {0}", Balance);
                    Console.ReadLine();
                    Console.Clear();
                    AccountMenu();
                }
            }
        }
        public void Deposit()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Available Balance: {0}", Balance);
                Console.WriteLine("-------------------------------");
                Console.WriteLine("How much would you like to deposit");
                double DepositAmount = Convert.ToDouble(Console.ReadLine());
                if (DepositAmount <= 0)
                {
                    Console.WriteLine("Can desposit, invalid deposit amount");
                    Console.ReadLine();
                    Console.Clear();
                }
                DepositList.Add(DepositAmount);
                Balance = Balance -= DepositAmount;
                Console.WriteLine("Available Balance: {0}", Balance);
                Console.ReadLine();
                Console.Clear();
                AccountMenu();
            }
        }
        public void Logout()
        {
            Console.WriteLine("Goodbye: " + Username);
            Console.ReadKey();
            Console.Clear();
            Menu.Run();
        }
        public void DepositHistory()
        {
            Console.WriteLine("Deposit History: ");
            Console.WriteLine("-------------------------------");
            int id = 1;
            foreach (double i in DepositList)
            {
                Console.WriteLine("ID: " + id + "|Amount: " + i);
                id++;
            }
            Console.ReadLine();
            Console.Clear();
            AccountMenu();
        }
        public void WithdrawHistory()
        {
            Console.WriteLine("Withdraw History: ");
            Console.WriteLine("-------------------------------");
            int id = 1;
            foreach (double i in WithdrawList)
            {
                Console.WriteLine("ID: " + id + "|Amount: " + i);
                id++;
            }
            Console.ReadLine();
            Console.Clear();
            AccountMenu();
        }
    }
}
