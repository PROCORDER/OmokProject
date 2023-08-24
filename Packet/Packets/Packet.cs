using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ProtoBuf;

namespace OmokPacket
{
    public enum PacketType
    {
        LOGIN = 0,
        SIGNUP=1,
        LOBBY=2,
        PLAYGAME=3,
        WAITINGROOM=4,
        SENDMESSAGE=5,
        MAKEFRIEND,
        ERR

    }


    [ProtoContract]
    public class Packet
    {
        [ProtoMember(1)]
        public const int Max = 9999;
        [ProtoMember(2)]
        public int length { get; set; }
        [ProtoMember(3)]
        public PacketType type{get; set;}
        [ProtoMember(4)]
        public UserInfo user { get; set; }
        public Packet()
        {
            this.length = 4096;
            this.type = 0;
        }
        

        //직렬화 함수
        public  static byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);      
            ProtoBuf.Serializer.Serialize<object>(ms,o);
            return ms.ToArray();
        }

        //역직렬화 함수
        public static  object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            object obj = ProtoBuf.Serializer.Deserialize<object>(ms);
            ms.Close();
            return obj;
        }
    }

}
