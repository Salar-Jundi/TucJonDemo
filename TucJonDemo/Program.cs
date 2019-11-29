using System;

namespace TucJonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej");
            Console.WriteLine("Vad heter du?");
            Console.Write("svar: ");
            string name = Console.ReadLine();
            Console.Write("du heter" + name);
        }
    }
}
