using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2_AP_Banking
{
    public static class Menu
    {
        public static void Run()
        {
            BankAccount moki = new BankAccount();
            bool check = true;
            while (check)
            {
                Console.WriteLine("WELCOME TO MOKI BANK");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login Exist Account");
                Console.WriteLine("3. Exit");
                int Choice = int.Parse(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        moki.OpenAccount();
                        break;
                    case 2:
                        Console.WriteLine("Please enter your username: ");
                        string username = Convert.ToString(Console.ReadLine());
                        moki.Login(username);
                        break;
                    case 3:
                        check = false;
                        break;
                }
            }
        }
    }
}
