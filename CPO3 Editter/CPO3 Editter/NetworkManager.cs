using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPO3_Editter
{
    public class NetworkManager
    {
        private string ip_receiver;
        public string Ip_receiver
        {
            get
            {
                return ip_receiver;
            }

            set
            {
                ip_receiver = value;
            }
        }


        public NetworkManager(string ip_receiver)
        {
            this.Ip_receiver = ip_receiver;
        }
    }
}
