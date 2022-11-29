using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    { // Class

        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool Graduated = true;

        public Student(string name, string surname, string group, byte point, bool graduated) : this(point, graduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }

        public Student(byte Point, bool graduated) : this(graduated)
        {
            this.Point = Point;
        }

        public Student(bool graduated)
        {
            Graduated = graduated;
        }

        public void name_surname()
        {
            Console.WriteLine(Name + " " + Surname);
        }


        public void all_information()
        {
            Console.Write(Name + " " + Surname + " " + Group + " " + Point + " =>");
            
        }

        public void second_chance()
        {
            if(Point>80)
            {
                Console.WriteLine("You have a second chance");
            }
            else
            {
                Console.WriteLine("Sorry , You don't get a second chance :/");
            }
        }
    }
}
 