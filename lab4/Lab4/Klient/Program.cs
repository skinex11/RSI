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

            CallbackHandler mojCallbackHandler = new CallbackHandler();
            InstanceContext instanceContext = new InstanceContext(mojCallbackHandler);
            CallbackKalkulatorClient client2 = new CallbackKalkulatorClient(instanceContext);

            double value1 = 10;
            Console.WriteLine("...wywoluje Silnia({0})...", value1);
            client2.Silnia(value1);
            value1 = 20;
            Console.WriteLine("...wywoluje Silnia({0})...", value1);
            client2.Silnia(value1);

            int value2 = 2;
            Console.WriteLine("...wywoluje obliczenia cosia...");
            client2.ObliczCos(value2);
            Console.WriteLine("...czekam chwile na odbior wynikow");
            Thread.Sleep(5000);

            client2.Close();
            Console.WriteLine("KONIEC KLIENT2");
        }
    }

    public class CallbackHandler : ICallbackKalkulatorCallback
    {
        public void ZwrotObliczCos(string result)
        {
            Console.WriteLine("Obliczenia: {0}", result);
        }

        public void ZwrotSilnia(double result)
        {
            Console.WriteLine("Silnia = {0}", result);
        }
    }
}
