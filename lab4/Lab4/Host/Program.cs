using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibrary1;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            Uri baseAddress1 = new Uri("http://localhost:10000/mojhost");
            ServiceHost mojHost1 = new ServiceHost(typeof(MojSerwis),
                baseAddress1);
            try
            {
                ServiceEndpoint endpoint1 = mojHost1.AddServiceEndpoint(typeof(IService1),
                    new WSHttpBinding(),
                    "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //Metadane:
                smb.HttpGetEnabled = true;
                mojHost1.Description.Behaviors.Add(smb);
                mojHost1.Open();
                Console.WriteLine("-->MojSerwis jest uruchomiony");
                Console.WriteLine("-->Nacisinij <ENTER> aby zakonczyc.\n");
                Console.ReadLine(); //czekam na zamkniecie
                mojHost1.Close();
                Console.WriteLine("-->Serwis zakonczyl dzialanie.");
            }
            catch(CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost1.Abort();
            }

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
