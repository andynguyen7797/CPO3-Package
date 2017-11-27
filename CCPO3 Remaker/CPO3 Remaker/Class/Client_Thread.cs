using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace CPO3_Remaker
{
    public class Client_Thread
    {
        private Thread tuyen_client; // tuyến client

        private Receiver_Manager receiver_mana;
        private Send_Manager send_mana;
     
        public Client_Thread(TcpClient client,StreamReader receiverStream,Player_Control player)
        {
            receiver_mana = new Receiver_Manager(client,receiverStream,player);
            send_mana = new Send_Manager(client,player);
            // tạo luồng giao tiếp riêng với client
            tuyen_client = new Thread(new ThreadStart(ReceiveData));
            tuyen_client.Start();
        }

        private void ReceiveData()
        {
          receiver_mana.Receive();
          send_mana.Delete_Event_Of_Old_Client();
        }

    }
}
