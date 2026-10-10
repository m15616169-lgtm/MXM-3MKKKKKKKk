using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hall
    {
        public Techer TE1 = new Techer();
        public Student[] all_stu;
        public int Count_Stu;
        public string Name;
        bool test = false;
        
        public void UI()
        {
            while (true)
            {
                if (test==false)
                {
                    Console.WriteLine("1- Add Stu\n2- Add Techer\n3- Exit");
                }
                else
                {
                    Console.WriteLine("1- Add Stu\n2- Edit Techer\n3- Exit");
                }

                switch (Console.ReadLine())
                {
                    case "1":
                        Add_Stu();
                        break;
                    case "2":
                        Add_TE1();
                        break;
                    case "3":
                        return;
                }


            }

        }
        public void Add(string Name, int Cont)
        {
            this.Name = Name;
            all_stu = new Student[Cont];
            TE1 = new Techer();
            UI();
        }

        void Add_Stu() 
        {
            for (int i = 0; i < all_stu.Length; i++)
            {
                if (all_stu[i] == null)
                {
                    all_stu[i] = new Student();
                    Console.WriteLine("Id name :");
                    int ID = i +1;
                    Console.WriteLine("Neam Stu :");
                    string naem = Console.ReadLine();
                    Console.WriteLine("Add age :");
                    string age = Console.ReadLine();
                    Console.WriteLine("Add ID Unvirsty :");
                    int ID_UN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add Year :");
                    int year = int.Parse(Console.ReadLine());
                    all_stu[i].add(ID,naem, age, ID_UN,year);
                    Console.WriteLine("Do you want exit :");
                    if (Console.ReadLine() == "Y")
                    {
                        break;
                    }

                }
            }
            
        }
        void Add_TE1()
        {
            Console.WriteLine("Id name :");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Neam Techer :");
            string naem = Console.ReadLine();
            Console.WriteLine("Age Techer :");
            string age = Console.ReadLine();
            Console.WriteLine("The SP :");
            string SP = Console.ReadLine();
            Console.WriteLine("The ID :");
            string ID_t = Console.ReadLine();
            TE1.add(ID,naem,age,SP,ID_t);
            test = true;
        }
        public void Print()
        {
            Console.WriteLine($"Name hall : {Name}");
            Console.WriteLine($"Count stu is : {all_stu.Length}");
            TE1.Print();
            for (int i = 0; i < all_stu.Length; i++)
            {
                if (all_stu[i] != null)
                {
                    all_stu[i].Print();
                }
            }
        }
      
    }
    
}
