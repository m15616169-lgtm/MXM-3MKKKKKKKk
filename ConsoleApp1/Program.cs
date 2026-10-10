using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UNV x = new UNV();
            x.Add("SVU", "Program", 10);
            x.Print_UNV();
            UNV y = new UNV();
            y.Add("BAIC", "INT", 10);
            y.Print_UNV();
        }
    }
}
