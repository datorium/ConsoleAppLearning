using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Human> persons = new List<Human>();
            persons.Add(new Human("Jenifer", "Lopez", 25, "Brown"));
            persons.Add(new Human("Anna", "Liepa", 16, "Blue"));
            persons.Add(new Human("Michael", "Johnson", 14, "Green"));
            persons.Add(new Human("Agnese", "Egle", 19, "Gray"));

            //persons[1].SetAge(15);

            foreach(var person in persons)
            {
                person.Introduce();
            }

            //create some accounts here
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new BankAccount("Jenifer", 200, "EUR"));  
            accounts.Add(new BankAccount("Anna", 5000, "EUR"));  
            accounts.Add(new BankAccount("Michael", 30, "EUR"));

            foreach (var account in accounts)
            {
                account.PrintInfo();
            }
        }
    }
}
