using Assignment1.Assignments;
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var factorial = Factorial.Calculate(1000);


            var result = StringOperations.ReverseAndUppercase("hello");


            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Display();
            list.Remove(20);
            list.Display();


            Console.WriteLine("Hello World!");
        }
    }
}
