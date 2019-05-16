using Klient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace CallbackContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerSession)]
    public class mojCallbackKalkulator : ICallbackKalkulator
    {
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

        double result;
        ICallbackHandler callback = null;

        public mojCallbackKalkulator()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICallbackHandler>();
        }

        public void ObliczCos(int sek)
        {
            Console.WriteLine("...wywolano Oblicz({0})", sek);
            if (sek < 10)
                Thread.Sleep(sek * 1000);
            else
                Thread.Sleep(1000);
            callback.ZwrotObliczCos("Obliczenia trwaly " +
                (sek + 1) +
                " sekund(y)");
        }

        public void Silnia(double n)
        {
            Console.WriteLine("...wywolano Silnia({0})", n);
            Thread.Sleep(1000);
            result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            callback.ZwrotSilnia(result);
        }
    }
}
