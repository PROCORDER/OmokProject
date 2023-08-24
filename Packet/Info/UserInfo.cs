using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokPacket
{
    public class UserInfo
    {
        public string MyId { get; set; }
        public string MyName { get; set; }
        public string MyPw { get; set; }
        public string[] History { get; set; }
        public List<string> friendList { get; set; }
        public string NowRoomCode { get; set; }
        public Guid clientId { get; set; }
        public UserInfo()
        {
            History = new string[2];
        }
    }
}
