using System;

namespace Assignment_2_Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account InTouch = new Account("Inn", 25);
            Console.WriteLine(InTouch.CheckBalance());
            Console.WriteLine(InTouch.DepositMoney(10));
        }
    }
}
