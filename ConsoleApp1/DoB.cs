using System;
using System.Collections.Generic;
using System.Text;

namespace ASM2_AP_Banking
{
    class DoB
    {
        public int day;
        private int month;
        private int year;

        public void set(int d, int m, int y)
        {
            this.day = d;
            this.month = m;
            this.year = y;
        }
        public bool checkDate()
        {
            if (day > 31 || month > 12)
            {
                Console.WriteLine("Invalid date");
                return false;
            }
            else if (year > 2002)
            {
                Console.WriteLine("You must oder than 18 year old");
                return false;
            }
            else
                return true;
        }
        public bool printDate()
        {
            if (checkDate() == true)
            {
                Console.WriteLine("Date is : " + day + "-" + month + "-" + year);
                return false;
            }
            else
                Console.WriteLine("Please enter date again ");
            return true;
        }
    }
}
