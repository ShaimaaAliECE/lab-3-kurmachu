using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(string name, int score) : base(name, score) {}

        public override void Display() => Console.WriteLine($"Diamond {Description} is displayed");
    }
}
