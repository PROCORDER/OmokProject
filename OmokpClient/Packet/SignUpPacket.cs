using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmokClient
{
    class SignUpPacket
    {
        string signUpID;
        string signUpPW;
        bool signUpCheck;
        public SignUpPacket()
        {
            this.signUpID = null;
            this.signUpPW = null;
            this.signUpCheck = false;

        }
    }
}
