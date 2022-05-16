using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Type how many Loan you need: ");
            double loan = Convert.ToDouble(Console.ReadLine());
            while (loan<0)
            {   
                Console.Write("Loan must be positive  number! Type how many Loan you need: ");
                loan = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Type the Percent% for your loan: ");
            double prcnt = Convert.ToDouble(Console.ReadLine()) / 100;
            while (prcnt<0)
            {
                Console.Write("Percents must be positive  number! Type the Percent% for your loan: ");
                prcnt = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Type the repayment Term for loan: ");
            int month = Convert.ToInt16(Console.ReadLine());
            while (month < 0)
            {
                Console.Write("Month must be positive  number! Type the repayment Term for loan: ");
                prcnt = Convert.ToDouble(Console.ReadLine());
            }
            int begMonth = month;
            double averagePerPay = loan / month;
            double fullPay = 0;
            bool checkO = false;

            if (checkO == false) Console.Write("Do you want auto schedule? (Y/N) ");
            string Answ = Console.ReadLine();
            if (Answ == "Y" || Answ == "y")
            {
                while (loan > 0 && month > 0)
                {
                    
                    double averagePayPercent = Math.Round((loan / month) + (loan * (prcnt / 12)), 1);
                    double payment = averagePayPercent;
                    loan += Math.Round(loan * (prcnt / 12), 1);
                    fullPay += payment;
                    loan -= payment;
                    month--;

                    if (checkO == false) { Console.WriteLine("-Month|-----Loan|-MustPay|-Percent|-------Full|"); checkO = true; }
                    Console.Write("  {0, 4}|", month+1);
                    Console.Write("  {0, 7}|", Math.Round(loan, 1));
                    Console.Write("  {0, 6}|", averagePayPercent);
                    Console.Write("  {0, 6}|", Math.Round(loan * (prcnt / 12), 1));
                    Console.WriteLine("  {0, 9}|", fullPay);

                }

                Console.WriteLine("---The End!---");
            }
            else
            {
                while (loan > 0 && month > 0)
                {
                    double averagePayPercent = Math.Round((loan / month) + (loan * (prcnt / 12)), 1);
                    Console.WriteLine("Loan Balance= " + Math.Round(loan, 1));
                    Console.Write("You need to pay: " + averagePayPercent + " - You are pay:");
                    double payment = Convert.ToDouble(Console.ReadLine());
                    while (payment < 0)
                    {
                        Console.Write("You need to pay: " + averagePayPercent + " - You are pay:");
                         payment = Convert.ToDouble(Console.ReadLine());
                    }
                        if (loan-payment<0.3) { loan -= payment; fullPay += payment; month--; break; }
                    loan += Math.Round(loan * (prcnt / 12), 1);
                    loan -= payment;
                    fullPay += payment;
                    month--;
                }
            }
            if (loan>0 && month>0){
                Console.Write("Oh no! You could not pay on time!");
                Console.ReadLine();

            } else { 
            begMonth -= month;
            Console.Write("Success! Your closed the loan, for " + begMonth + " month, and you paid:"+fullPay+"$");
            Console.ReadLine();
            }
        }

    }
}