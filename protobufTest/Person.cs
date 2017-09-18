using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace protobufTest
{
    [ProtoContract]
    class Person
    {
        [ProtoMember(1)]
        public int id { get; set; }
        [ProtoMember(2)]
        public string name { get; set; }
        [ProtoMember(3)]
        public string address { get; set; }
    }
}
