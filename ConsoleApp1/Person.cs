using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person 
    {
        private int Id;
        private string Name;
        private string Age;
        protected  void add(int id ,string name ,string age) 
        {
            Id = id;
            Name = name;
            Age = age;
        }
        protected  void Print()
        {
            Console.WriteLine($"Natural Number : {Id}");
            Console.WriteLine($"The name is : {Name}");
            Console.WriteLine($"The age is : {Age}");
        
        }
    }
   
}

