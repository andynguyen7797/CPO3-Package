using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CPO3_Editter
{
    public class Send_Manager : Network_Manager
    {
        #region Const
        private const char ANSWER_SIGN = '#';
        private const char ALARM_SIGN = '@';
        private const char SCREEN_REVIEW_SIGN = '/';
        private const string DESTROY_CLIENT = "Y2K";
        private const char NAME_PLAYER_SIGN = '*';
        #endregion

        #region Methods
        public void Send_Answer_Content(string content)
        {
            //thêm kí hiệu đầu cho câu trả lời để server có thể nhận ra nó
            content += ANSWER_SIGN.ToString();
            try
            {
                //create stream 
                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;

                //send answer content
                writer.WriteLine(content);
            } catch (Exception ex)
            {
                MessageBox.Show("Gửi câu trả lời thất bại : " + ex.Message);
            }

        }

        public void Send_Alarm()
        {
            try
            {
                //create stream 
                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;

                //send answer content
                writer.WriteLine(ALARM_SIGN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gửi chuông thất bại : " + ex.Message);
            }
        }

        public void Send_Name_Of_Player(string name)
        {
            try
            {
                //create stream 
                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;

                //send answer content
                writer.WriteLine(name + NAME_PLAYER_SIGN.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tên thất bại : " + ex.Message);
            }
        }

        public void SendIndexofUser()
        {
            try
            {
                var writer = new StreamWriter(Client.GetStream());
                writer.AutoFlush = true;

                writer.WriteLine("INDEX " + Index);
            }catch(Exception ex)
            {
                MessageBox.Show("bla bla : " + ex.Message);
            }
        }

        #endregion
    }
}
