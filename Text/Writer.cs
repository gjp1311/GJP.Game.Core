using ScreenReaderAPIWrapper;
using System;

namespace GJP.Game.Core.Text
{
    public static class Writer
    {
        private static ScreenReader _screenReader = new ScreenReader();

        public static void Write(string text)
        {
            _screenReader.SayString(text);
            Console.Write(text);
        }

        public static void WriteLine(string text)
        {
            Write(text);
            Console.WriteLine();
        }
    }
}
