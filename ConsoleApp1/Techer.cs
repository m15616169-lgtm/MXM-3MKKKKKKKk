using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Techer : Person
    {
        private string SP;
        private string ID_t;
        public void add(int id, string name, string age,string SP, string ID_t)
        {
            base.add(id, name, age);
            this.SP = SP;
            this.ID_t = ID_t;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("The SP is :" +SP);
            Console.WriteLine("The ID techer is :" + ID_t);
        }
    }

}
