using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializzObject
{
    class Program
    {
        /// <summary>
        /// serilization is used to tranfer objects into binary system 
        /// deserilization is used to transfer binary system into object
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ////Serialize:
            //Person p = new Person();
            //p.Name = "Tom";
            //p.Age = 10;
            //using (FileStream fsWrite = new FileStream(@"C:\Users\qtt1563\Desktop\target.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("serialization successful");
            //Console.ReadKey();
            ////Deserialize:
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\qtt1563\Desktop\target.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p=(Person) bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }
        [Serializable]
        public class Person { 
            public string Name
            {
                get;
                set;
            }
            public int Age
            {
                get;
                set;
            }
        }
    }
}
