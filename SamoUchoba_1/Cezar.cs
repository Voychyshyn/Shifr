using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoUchoba_1
{
    public class Cezar
    {
        List<char> bufer = new List<char>();

        public Cezar(int key)
        {
            for (int i = 0; i <= 255; i++) // ctrl + k + d
            {
                var symbol = (char)i;
                if ((symbol >= '0' && symbol <= '9') || (symbol >= 'a' && symbol <= 'z') || (symbol >= 'A' && symbol <= 'Z') || (symbol >= 'А' && symbol <= 'Я') || (symbol >= 'а' && symbol <= 'я'))
                {
                    bufer.Add(symbol);
                }
            }

            Key = key;
        }
        public int Key { get; set; }
        
        public string Code (string s)
        {
            string result = string.Empty;
            var key = Math.Abs(Key);
            for (int i = 0; i < s.Length; i++)
            {
                var index = GetIndex(s[i]);
                if (index != -1)
                {
                    int newIndex = key + index - ((key + index) / bufer.Count) * bufer.Count;
                    result += bufer[newIndex];
                }
                else
                {
                    result += s[i];
                }
            }

            return result;
        }

        private int GetIndex(char c)
        {
            for (int i = 0; i < bufer.Count; i++)
            {
                if (bufer[i] == c)
                {
                    return i;
                }
            }

            return -1;
        }
    }

}
