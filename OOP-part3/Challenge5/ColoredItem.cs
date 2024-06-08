using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part3.Challenge5
{
    internal class ColoredItem<T>(T item, ConsoleColor color) where T : class
    {
        public T Item { get; } = item;
        public ConsoleColor Color { get; } = color;

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.Write(Item);
            Console.ResetColor();
        }
    }

    internal class Sword { }
    internal class Axe { }
    internal class Bow { }
   }
