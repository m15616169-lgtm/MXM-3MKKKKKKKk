using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class UNV
    {
        string Name;
        string TY;
        Hall[]Halls;
        public void Add(string name , string Ty ,int Count)
        {
            Name = name;
            TY = Ty;
            Halls = new Hall[Count];
            Add_Hall();
        }
        public void Add_Hall() 
        {
            for (int i = 0; i < Halls.Length; i++)
            {
                if (Halls[i] == null)
                {
                    Halls[i] = new Hall();
                    Console.WriteLine("Enter Name Hall :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Stu Cont :");
                    int count = int.Parse(Console.ReadLine());
                    Halls[i].Add(name, count);
                    Console.WriteLine("Do you want exit :");
                    if(Console.ReadLine()=="Y")
                    {
                        break;
                    }
                }
            }
        }
        public void Print_UNV()
        {
            Console.WriteLine($"Name hall : {Name}");
            Console.WriteLine($"Name Ty {TY}");
            Console.WriteLine($"Count stu is : {Halls.Length}");
            for (int i = 0; i < Halls.Length; i++)
            {
                if (Halls[i] != null)
                {
                    Halls[i].Print();
                }
            }
        }
    }
}
