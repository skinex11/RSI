using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class MojSerwis : IService1
    {
        public void Funkcja1(string s1)
        {
            Console.WriteLine("...{0}: funkcja1 - start", s1);
            Thread.Sleep(3000);
            Console.WriteLine("...{0}: funkcja1 - stop", s1);
            return;
        }

        public void Funkcja2(string s2)
        {
            Console.WriteLine("...{0}: funkcja1 - start", s2);
            Thread.Sleep(3000);
            Console.WriteLine("...{0}: funkcja1 - stop", s2);
            return;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
