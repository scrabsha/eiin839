using System;

namespace Soap_Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = new MathOperations.MathsOperationsClient();
            Console.WriteLine(client.Add(41, 1));

            Console.ReadLine();
        }
    }
}
