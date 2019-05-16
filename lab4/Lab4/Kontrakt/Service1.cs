using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kontrakt
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MojStrumien : IStrumien
    {
        public Stream GetStream(string nazwa)
        {
            FileStream myFile;
            Console.WriteLine("-->Wywolano getStream");
            string filePath = Path.Combine(System.Environment.CurrentDirectory,
                ".\\image.jpg");
            //wyjatek na wypadek bledu otwarcia pliku
            try
            {
                myFile = File.OpenRead(filePath);
            }
            catch(IOException ex)
            {
                Console.WriteLine(String.Format("Wyjatek otwarcia pliku {0} :",
                    filePath));
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            return myFile;
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
