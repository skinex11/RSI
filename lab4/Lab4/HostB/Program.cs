using Kontrakt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace HostB
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:10000/");
            ServiceHost mojHost = new ServiceHost(typeof(MojStrumien),
                baseAdress);
            BasicHttpBinding b = new BasicHttpBinding();
            b.TransferMode = TransferMode.Streamed;
            b.MaxReceivedMessageSize = 1000000000;
            b.MaxBufferSize = 8192;

            try
            {
                ServiceEndpoint endpoint = mojHost.AddServiceEndpoint(typeof(IStrumien),
                    b,
                    baseAdress);
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();

                smb.HttpGetEnabled = true;
                mojHost.Description.Behaviors.Add(smb);
                mojHost.Open();
                Console.WriteLine("-->Moj strumien jest uruchomiony");
                Console.ReadLine();
                mojHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("Wystapil wyjatek: {0}", ce.Message);
                mojHost.Abort();
            }
        }
    }
}
