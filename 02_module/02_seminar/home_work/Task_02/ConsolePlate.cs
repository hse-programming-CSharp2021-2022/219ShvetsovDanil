using System;

namespace Task_02
{
    public class ConsolePlate
    {
        private char _plateChar;
        public char PlateChar
        {
            get => _plateChar;
            set => _plateChar = (value < 65 || value > 90) ? 'A' : value;
        }
        
        private ConsoleColor _plateColor = ConsoleColor.White;
        public ConsoleColor PlateColor
        { 
            get => _plateColor;
            set => _plateColor = value;
        }
        
        public ConsolePlate()
        {
            _plateChar = 'A';
        }

        private ConsoleColor _backgroundColor;

        public ConsoleColor BackgroundColor
        {
            get => _backgroundColor;
            set => _backgroundColor = (value != _plateColor) ? 
                value : throw new ArgumentException("Цвета совпадают!");
        }

        public ConsolePlate(char plateChar, ConsoleColor plateColor, ConsoleColor backgroundColor)
        {
            PlateChar = plateChar;
            PlateColor = plateColor;
            BackgroundColor = backgroundColor;
        }
    }
} 