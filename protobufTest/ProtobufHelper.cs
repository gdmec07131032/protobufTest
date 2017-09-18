using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using System.IO;

namespace protobufTest
{
    class ProtobufHelper
    {
        //将对象序列化为字符串
        public static string SerializerToString<T>(T t)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Serializer.Serialize(ms, t);
                return ASCIIEncoding.UTF8.GetString(ms.ToArray());
            }
        }
        //将对象序列化到文件
        public static void SerializerToFile<T>(T t, string filePath)
        {
            using (var file = File.Create(filePath))
            {
                Serializer.Serialize(file, t);
            }
        }
        //将文件数据转化为对象
        public static T DederializeFromString<T>(string str)
        {
            using (MemoryStream ms = new MemoryStream(ASCIIEncoding.UTF8.GetBytes(str)))
            {
                T obj = Serializer.Deserialize<T>(ms);
                return obj;
            }
        }
        public static T DederializerFromFile<T>(string filepath)
        {
            using (var file = File.OpenRead(filepath))
            {
                T obj = Serializer.Deserialize<T>(file);
                return obj;
            }
        }

    }
}
