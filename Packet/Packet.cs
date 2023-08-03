using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OmokPacket
{
    public enum PacketType
    {
        LOGIN = 0,
        SIGNUP,
        LOBBY,
        PLAYGAME

    }


    [Serializable]
    public class Packet
    {
        public const int Max = 9999;
        public int length { get; set; }
        public int type{get; set;}
        public Packet()
        {
            this.length = 0;
            this.type = 0;
        }
        

        //직렬화 함수
        public  byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
    

            return ms.ToArray();
        }

        //역직렬화 함수
        public static  object Desserialize(byte[] bt)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            foreach (byte b in bt)
            {
                ms.WriteByte(b);
            }

            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(ms);
            ms.Close();
            return obj;
        }
    }

}
