using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASM2_AP_Banking
{
    public class BankAccount
    {
        public string[] accUsername = new string[10];
        public string[] accPassword = new string[10];
        public string[] accName = new string[10];
        public string[] accDoB = new string[10];
        public string[] accBalance = new string[10];
        public int id = 0;
        DoB dob = new DoB();
        public void ShowInfo(string username)
        {
            int id;
            if (accUsername.Contains(username))
            {
                id = Array.IndexOf(accUsername, username);
                Console.WriteLine("Your account details: ");
                Console.WriteLine("----------------------");
                Console.WriteLine("Username: " + accUsername[id]);
                Console.WriteLine("Password: " + accPassword[id]);
                Console.WriteLine("Name: " + accName[id]);
                Console.WriteLine("DoB: " + accDoB[id]);
                Console.WriteLine("Balance: " + accBalance[id]);
            }
        }
        public void OpenAccount()
        {
            string username;
            string password;
            string name;
            int d, m, y;
            double balance;
            bool check = true;

            Console.WriteLine("Please enter your username: ");
            username = Convert.ToString(Console.ReadLine());
            accUsername[id] = username;
            Console.WriteLine("Please enter your password: ");
            password = Convert.ToString(Console.ReadLine());
            accPassword[id] = password;
            Console.WriteLine("Please enter your name: ");
            name = Convert.ToString(Console.ReadLine());
            accName[id] = name;
            while (check == true)
            {
                Console.WriteLine("Enter date: ");
                d = Convert.ToInt32(Console.ReadLine());
                m = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                dob.set(d, m, y);
                if (dob.printDate() == false)
                {
                    accDoB[id] = Convert.ToString(d + "-" + m + "-" + y);
                    check = false;
                }
                else check = true;
            }
            Console.WriteLine("Add Money: ");
            balance = Convert.ToDouble(Console.ReadLine());
            accBalance[id] = Convert.ToString(balance);
            Console.WriteLine(" Create account succesfully.....");
            Console.Clear();
            ShowInfo(username);
        }
        public void Login(string username)
        {
            int id;
            if (accUsername.Contains(username))
            {
                id = Array.IndexOf(accUsername, username);
                Console.WriteLine("Please enter your password: ");
                string pass = Convert.ToString(Console.ReadLine());
                double balance = Convert.ToDouble(accBalance[id]);
                if (pass == accPassword[id])
                {
                    Account session = new Account(username, pass, balance);
                    Console.Clear();
                    session.AccountMenu();
                }
                else Console.WriteLine("Wrong Password");
            }
            else Console.WriteLine("Username doesnt exit.");
        }
    }
}
