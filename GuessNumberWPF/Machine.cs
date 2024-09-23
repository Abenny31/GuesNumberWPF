using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumberWPF
{
    public class Machine
    {
        public int rand { get; set; }
        public int WinCount { get; set; }
        

        public void Getrandom()
        {
            Random r = new Random();
            this.rand = r.Next(0, 5);

        }

    }
}
