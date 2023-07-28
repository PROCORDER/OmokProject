using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace OmokClient
{
    public enum PacketType
    {
        LOGIN = 0,
        SIGNUP
    }


    [Serializable]
    public class Packet
    {
        public const int Max = 9999;
        public int Length;
        public int Type;
        public Packet()
        {
            this.Length = 0;
            this.Type = 0;
        }

        //직렬화 함수
        public static byte[] Serialize(object o)
        {
            MemoryStream ms = new MemoryStream(1024 * 4);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        //역직렬화 함수
        public static object Desserialize(byte[] bt)
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
