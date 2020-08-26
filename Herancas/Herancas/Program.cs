using System;
using System.Xml.Linq;
using Herancas.Entities;

namespace Herancas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            BusinessAccount account = new BusinessAccount(8010, "Angelina", 100.00, 500.00);
            Console.WriteLine(account.Balance);
            account.Deposit(200.00);
            Console.WriteLine(account.Balance);
            account.Loan(400.00);
            Console.WriteLine(account.Balance);
            account.WithDraw(600);
            Console.WriteLine(account.Balance);*/
            /*
            Account acc = new Account(8010, "Antonia", 300.00);
            BusinessAccount bacc = new BusinessAccount(8788, "Evelyn", 8000.00, 1000.00);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1522, "Anna", 0.0, 300);
            Account acc3 = new SavingsAccount(0025, "Mary", 2000, 150);

            //DOWN CASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;

            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }
            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("UpdateBalance");
            }*/

            Account acc1 = new Account(0258, "Dailton", 500.0);
            Account acc2 = new SavingsAccount(0003, "Martha", 500.0, 0.01);

            acc1.WithDraw(10.00);
            acc2.WithDraw(10.00);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);








        }
    }
}
