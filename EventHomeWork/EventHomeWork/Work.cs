using System;
using System.Collections.Generic;
using System.Text;

namespace EventHomeWork
{
    class Work
    {
        public event EventHandler<char> OnKeyPressed;
        public void Run() {
            char symbol = ' ';
            OnKeyPressed += Print;
            while (!symbol.Equals('c') && !symbol.Equals('с')) {
                symbol = Console.ReadKey().KeyChar;
                OnKeyPressed?.Invoke(this, symbol);
            }
        }
        public void Print(object o,char symbol)
        {
            Console.WriteLine(symbol);
        }
    }
}
