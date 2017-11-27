using System.Net.Sockets;
using System.Threading;

namespace ScreenCameraServer
{
    public class ClientThread
    {
        private Thread tuyenClient;

        private ReiceverManager receiver;
        private SendManager sender;

        public ClientThread(Socket client,Camera camera)
        {
            receiver = new ReiceverManager(client,camera);
            sender = new SendManager(camera,client);

            // tạo luồng giao tiếp riêng với client
            tuyenClient = new Thread(Communication);
            tuyenClient.Start();
        }

        private void Communication()
        {
            receiver.ReceiveData();
            sender.DeleteEventOfClient();
        }
    }
}
