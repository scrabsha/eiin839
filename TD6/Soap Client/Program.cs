using System;

namespace Soap_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MathOperations.MathsOperationsClient();
            Console.WriteLine(client.Add(41, 1));
            Console.WriteLine(client.Sub(43, 1));
            Console.WriteLine(client.Mul(21, 2));
            Console.WriteLine(client.Div(84, 2));

            // We don't want the terminal to close instantly, so we wait for
            // the `return` key to be pressed before stopping the program.
            Console.ReadLine();
        }
    }
}
