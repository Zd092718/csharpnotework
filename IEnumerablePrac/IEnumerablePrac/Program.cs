using System;
using System.Collections;

namespace IEnumerablePrac
{
    class Wallet : IEnumerable
    {
        Money[] bills = null;
        int openIndex = 0;

        public Wallet()
        {
            bills = new Money[100];
        }

        public void Add(Money bill)
        {
            bills[openIndex] = bill;
            openIndex++;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Money bill in bills)
            {
                if(bill == null)
                {
                    break;
                }
                yield return bill;
            }
        }
    }


    class Money
    {
        public int amount;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wallet wallet = new Wallet();
            wallet.Add(new Money() { amount = 1 });
            wallet.Add(new Money() { amount = 5 });
            wallet.Add(new Money() { amount = 10 });
            wallet.Add(new Money() { amount = 20 });
            wallet.Add(new Money() { amount = 50 });
            wallet.Add(new Money() { amount = 100 });

            foreach (Money money in wallet)
            {
                Console.WriteLine(money.amount);
            }
        }
    }
}
