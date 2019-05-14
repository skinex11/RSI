using Klient.ServiceReference1;
using Klient.ServiceReference2;
using System;
using System.ServiceModel;
using System.Threading;


namespace Klient
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            Service1Client client1 = new Service1Client("WSHttpBinding_IService1");

            Console.WriteLine("...wywoluje funkcja1:");
            client1.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 1");

            Console.WriteLine("...wywoluje funkcja2:");
            client1.Funkcja2("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 2");

            Console.WriteLine("...wywoluje funkcja1:");
            client1.Funkcja1("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("...kontynuacja po funkcji 1");

            client1.Close();

            Console.WriteLine("\nKLIENT2:");
            
            

                       

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
