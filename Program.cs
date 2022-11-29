using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { //Program.cs Main

            Console.WriteLine("Did he/she graduated ?");
            string graduated = Console.ReadLine();
            Console.WriteLine("Please enter information: ");

            if (graduated=="yes" || graduated == "Yes" || graduated == "YES")
            {
                Student student_info = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToByte(Console.ReadLine()) , true);

                student_info.name_surname();
                student_info.all_information();
                Console.WriteLine("This student has graduated");
                student_info.second_chance();
            }

            else
            {
                Student student_info = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Convert.ToByte( Console.ReadLine() ) , false );

                student_info.name_surname();
                student_info.all_information();
                Console.WriteLine(" This student didn`t graduate");
                student_info.second_chance();
            }
            





        }
    }
}
