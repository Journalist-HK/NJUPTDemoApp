using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJUPTDemoApp.Services
{
    class XamlAttachingCoding
    {
        public static async void ShowMessage(string message)
        {
            var msgDialog = new Windows.UI.Popups.MessageDialog(message);
            await msgDialog.ShowAsync();
        }

        public static bool bolNum(string temp)
        {
            for (int o = 0; o < temp.Length; o++)
            {
                byte tempByte = Convert.ToByte(temp[o]);
                if (tempByte < 48 || tempByte > 57)
                    return false;
            }
            return true;
        }
    }
}
