using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount person1 = new BankAccount("Марат", 20000);
            BankAccount person2 = new BankAccount("Денис", 30000);
            person1.Transfer(person2);
            Console.WriteLine(person2.money);
            person2.Cut();
            Console.WriteLine(person2.money);
        }
    }
}
