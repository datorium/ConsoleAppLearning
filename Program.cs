using System;

namespace ConsoleAppLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person = new Human("Jenifer", "Lopez", 25, "Brown");
            person.Introduce();

            person.AddNumbers(3.14, 5.55);

        }
    }
}
