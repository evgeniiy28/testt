using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exam
{
    class BankAccount
    {
        public string fullName;
        public int money;

        public void Transfer(BankAccount acc)
        {
            int sum = Convert.ToInt32(Console.ReadLine());
            if (this.money < sum)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                this.money -= sum;
                acc.money += sum;
            }
        }
         public   void Cut()
        {
            int sum = Convert.ToInt32(Console.ReadLine());
            if (this.money < sum)
            {
                Console.WriteLine("Недостаточно средств для снятия денег");
            }
            else
            {
                this.money -= sum;
                Console.WriteLine("Получено денег наличными:" + sum);
            }
         }
        public BankAccount(string fullName, int money)
        {
            this.money = money;
            this.fullName = fullName;
        }
    }
}
