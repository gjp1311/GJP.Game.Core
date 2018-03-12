using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GJP.Game.Core.Text
{
    public static class Reader
    {
        public static int Read()
        {
            return Console.Read();
        }

        public static string ReadLine(string text = "",bool breakLine = false)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Writer.Write(text);
            }
            if (breakLine)
            {
                Console.WriteLine();
            }

            return Console.ReadLine();
        }

        public static List<string> ReadWords(string text = "", bool breakLine = false)
        {
            var result = ReadLine(text, breakLine).Split(' ');
            return result.ToList();
        }
    }
}
