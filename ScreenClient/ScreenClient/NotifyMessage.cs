using System.Windows.Forms;

namespace ScreenClient
{
    public class NotifyMessage
    {
        private static NotifyIcon notifyMess;

        public NotifyMessage(NotifyIcon notify)
        {
            notifyMess = notify;
        }

        public static void showMessage(string mess,int mode,int timeShowing)
        {
            notifyMess.BalloonTipText = mess;
            switch (mode)
            {
                case 0:
                    {
                        //info
                        notifyMess.BalloonTipIcon = ToolTipIcon.Info;
                        break;
                    }
                case 1:
                    {
                        //warning
                        notifyMess.BalloonTipIcon = ToolTipIcon.Warning;
                        break;
                    }
                case 2:
                    {
                        //error
                        notifyMess.BalloonTipIcon = ToolTipIcon.Error;
                        break;
                    }
            }
            notifyMess.ShowBalloonTip(timeShowing);
        }
    }
}
