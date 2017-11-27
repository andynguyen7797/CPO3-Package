using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public class ScreenSettingsLog
    {
        private static List<string> log_data;
        public static List<string> Log_data
        {
            get
            {
                return log_data;
            }

            set
            {
                log_data = value;
            }
        }
     
        private RichTextBox textbox;
        public RichTextBox Textbox
        {
            get
            {
                return textbox;
            }

            set
            {
                textbox = value;
            }
        }

        public ScreenSettingsLog(RichTextBox textbox)
        {
            if(Log_data == null)
            {
                Log_data = new List<string>();
            }       
            this.Textbox = textbox;
        }

        public void WriteLog_toTextBox(string data)
        {
            this.Textbox.AppendText(data + "\n");
            Log_data.Add(data);
        }

        public static void ReShow_Log_Data(RichTextBox textbox)
        {
            if (Log_data == null) return;
            for(int i = 0; i < Log_data.Count; i++)
            {
                textbox.AppendText(Log_data[i] + "\n");
            }
        }

    }
}
