using System;

namespace Task5
{
    public class ConsolePlate
    {
        private char _plateChar;
        ConsoleColor _plateColor;
        ConsoleColor _backgroundColor;
        /* ConsoleColor ForegroundColor = ConsoleColor.Red;*/
        public ConsolePlate()
        {
            _plateChar = 'A';
            _plateColor = ConsoleColor.White;
            _backgroundColor = ConsoleColor.Black;
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor backgroundColor)
        {
            if (plateChar < 'A' || plateChar > 'Z')
                _plateChar = 'A';
            else _plateChar = plateChar;
            _plateColor = plateColor;
            _backgroundColor = backgroundColor;
        }
        public char PlateChar
        {
            get { return _plateChar; }
        }

        public ConsoleColor PlateColor
        {
            get { return _plateColor; }
        }
        public ConsoleColor BackgroundColor
        {
            get { return _backgroundColor; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePlate[] consolePlates =
            {
                new ConsolePlate(),
                new ConsolePlate('X', ConsoleColor.White, ConsoleColor.Red),
                new ConsolePlate('O', ConsoleColor.White, ConsoleColor.Magenta)
            };
            foreach (ConsolePlate consolePlate in consolePlates)
            {
                Console.ForegroundColor = consolePlate.PlateColor;
                Console.BackgroundColor = consolePlate.BackgroundColor;
                Console.Write(consolePlate.PlateChar);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
