using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;

namespace SerializedNetworkClasses
{
    [ProtoContract]
    public class SerializeExample
    {
        [ProtoMember(1)]
        public string exampleString;

        [ProtoMember(2)]
        public float exampleFloat;
    }
}
