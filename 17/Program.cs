using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Account<int> account = new Account<int>(575257, 5645451054.78, "Иванов Иван Иванович");

            account.Print<int>();
            Account<string> account2 = new Account<string>("54534534534", 5635054.78, "Петров Петр Петрович");

            account.Print<string>();

        }
    }
    class Account<T>
    {
        private T accNumber;
        private double balance;
        private string name;
        public T Accnumber { get { return accNumber; } }
        public double Balance { get { return balance;} }
        public string Name { get { return name; } }
        public Account(T accNumber, double balance, string name)
        {

            this.accNumber = accNumber;
            this.balance = balance;
            this.name = name;
        }
        internal void Print<T>()
        {
            Console.WriteLine(accNumber);
            Console.WriteLine(balance);
            Console.WriteLine(name);
        }
    }
    }
