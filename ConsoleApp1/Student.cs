using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        private int ID_UN;
        private int Year;
        public  void add(int id, string name, string age ,int ID_UN ,int Year) 
        {
            base.add(id, name,age);
            this .ID_UN = ID_UN;
            this .Year = Year;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine("The number unvercity is :" + ID_UN);
            Console.WriteLine("The year number unvercity is :" + Year);
        }
    }
}
