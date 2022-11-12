using System;
namespace Bank
{
    class BankAccount
    {
        public double AccountNumber = 12345678;
        public String Name = "Indra";
        public double bankbalance = 133333434;
        public void data()
        {
            Console.WriteLine("Accountnumber={0}\nAccountHolder={1}\nBankbalace={2}", AccountNumber, Name, bankbalance);
        }
        public void deposit(double money)
        {
            if (money > 0)
            {
                bankbalance = bankbalance + money;
                Console.WriteLine("Bank Balance=" + bankbalance);

            }
            else
            {
                Console.WriteLine("enter correct value of amount");

            }
            Console.WriteLine("Bank Balance=" + bankbalance);
        }
        public void withdraw(double amount)
        {
            if (amount < bankbalance)
            {
                bankbalance -= amount;
            }
            else if (amount > bankbalance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Console.WriteLine("select correct choice");
            }
            Console.WriteLine("Bank Balance=" + bankbalance);



        }
        public void balance()
        {
            Console.WriteLine("bank balance=" + bankbalance);
        }



    }
    class ICICIBankAccount : BankAccount
    {
        public void withdraw(double amount)
        {
            if (amount < bankbalance)
            {
                bankbalance -= amount;
            }




        }
    }
}