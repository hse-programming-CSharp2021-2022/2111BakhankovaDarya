using System;

namespace Task5
{
    public class ConsolePlate
    {
        char _plateChar;
        ConsoleColor _plateColor = ConsoleColor.White;
       /* ConsoleColor ForegroundColor = ConsoleColor.Red;*/
        public ConsolePlate()
        {
            _plateChar = 'A';
        }
        public ConsolePlate(char plateChar, ConsoleColor plateColor)
        {
            if ((int)plateChar <= 90 && (int)plateChar >= 65)
                this._plateChar = plateChar;
            else this.PlateChar = 'A';
            this._plateColor = plateColor;
        }
        public char PlateChar
        {
            set
            {
                if ((int)_plateChar <= 90 && (int)_plateChar >= 65)
                    _plateChar = value;
                else
                    _plateChar = 'A';
            }
            get { return _plateChar; }
        }

        public ConsoleColor PlateColor
        {
            set { _plateColor = value; }
            get { return _plateColor; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            ConsolePlate cp = new ConsolePlate();
            ConsolePlate[] somePlates =
            {
                new ConsolePlate('*', ConsoleColor.Red),
                cp,
                new ConsolePlate ((char)70, ConsoleColor.Green)
            };
            foreach (ConsolePlate conP1 in somePlates)
            {
                Console.ForegroundColor = conP1.PlateColor;
                Console.Write(conP1.PlateChar);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
    }
}
