using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NJUPTDemoApp.Helpers
{
    public class Encryption
    {
        public static string Encrypt(string m, string key)
        {
            string result = "";
            int i, incoding, orderInput, orderKey;
            char[] arrayInput, arrayKey;

            arrayInput = m.ToCharArray();
            arrayKey = key.ToCharArray();
            int k = arrayKey[0];
            for (i = 0; i < m.Length; i++)
            {
                orderInput = arrayInput[i] - 31;
                orderKey = k - 31;

                if (orderInput + orderKey > 95)
                {
                    incoding = orderInput + orderKey - 95 + 31;
                }
                else
                {
                    incoding = orderInput + orderKey + 31;
                }

                arrayInput[i] = Convert.ToChar(incoding);
            }

            for (i = 0; i < arrayInput.Length; i++)
            {
                result += arrayInput[i];
            }
            return result;
        }

        public static string Decrypt(string c, string key)
        {
            string result = "";
            int i, incoding, orderInput, orderKey;
            char[] arrayInput, arrayKey;

            arrayInput = c.ToCharArray();
            arrayKey = key.ToCharArray();
            int k = arrayKey[0];

            for (i = 0; i < c.Length; i++)
            {
                orderInput = arrayInput[i] - 31;
                orderKey = k - 31;

                if (orderInput <= orderKey)
                {
                    incoding = 95 + orderInput - orderKey + 31;
                }
                else
                {
                    incoding = orderInput - orderKey + 31;
                }

                arrayInput[i] = Convert.ToChar(incoding);
            }

            for (i = 0; i < arrayInput.Length; i++)
            {
                result += arrayInput[i];
            }
            return result;
        }
    }
}
