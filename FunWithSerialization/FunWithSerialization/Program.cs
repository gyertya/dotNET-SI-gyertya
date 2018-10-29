using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSerialization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const string fileNameSoap = "MyDataSoap.dat";
            SerializeAnObject(new SoapFormatter(), fileNameSoap);
            DeserializeAnObject(new SoapFormatter(), fileNameSoap);
                
            const string fileNameBinary = "MyDataBinary.dat";
            SerializeAnObject(new BinaryFormatter(), fileNameBinary);
            DeserializeAnObject(new BinaryFormatter(), fileNameBinary);
        }

        private static void DeserializeAnObject(IFormatter formatter, string fileName)
        {
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            MyObject obj = (MyObject)formatter.Deserialize(stream);
            stream.Close();
            Console.WriteLine(obj.ToString());
        }


        private static void SerializeAnObject(IFormatter formatter, string fileName)
        {
            MyObject myObject = new MyObject();
            myObject.n1 = 10;
            myObject.n2 = 20;
            myObject.s1 = "Some string";

            Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, myObject);
            stream.Close();
        }
    }
}
