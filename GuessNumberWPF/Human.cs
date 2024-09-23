using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumberWPF
{
    public class Human
    {
        internal string Name { get; }
        internal int WinCount { get; set; }
        internal bool WannaPlay { get; set; }

        internal int Guess { get; set; }

        public Human() { }
        public Human(string name)
        {
            Name = name;
        }
        
        
    }
}
