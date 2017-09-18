using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace protobufTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                id = 1,
                name = "aa",
                address = "bb"
            };
            //序列化
            //string str = ProtobufHelper.SerializerToString<Person>(person);
            //Console.WriteLine(str);

            //反序列化
            //Person obj = ProtobufHelper.DederializeFromString<Person>(str);
            //Console.WriteLine(obj.id + " " + obj.name + " " + obj.address);

            ProtobufHelper.SerializerToFile<Person>(person, "person.dll");

            Person obj = ProtobufHelper.DederializerFromFile<Person>("person.dll");
            Console.WriteLine(obj.id + " " + obj.name + " " + obj.address);
            Console.ReadKey();
        }
    }
}
