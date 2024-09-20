//#define INHERRITANCE_1
//#define INHERRITANCE_2
#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if INHERRITANCE_1
            Human human = new Human("Vercetty", "Tommy", 30);
            Student student = new Student("Pinkman", "Jessie", 22, "Chemestry", "WW_220", 95, 96);
            Teacher teacher = new Teacher("White", "Walter", 50, "Chemestry", 25);
            Console.WriteLine(human);
            Console.WriteLine(student);
            Console.WriteLine(teacher);
#endif

#if INHERRITANCE_2
            Human tommy = new Human("Vercetty", "Tommy", 30);
            Student student_tommy = new Student(tommy, "Therft", "Vice", 95, 98);
            Console.WriteLine(tommy);
            Console.WriteLine(student_tommy);

            Human ricardo = new Human("Diaz", "Ricardo", 50);
            Teacher teacher_ricardo = new Teacher(ricardo, "Weapons destribution", 20);
            Console.WriteLine(ricardo);
            Console.WriteLine(teacher_ricardo);

            Student shredor = new Student("Shredor", "Hank", 40, "Criminalistic", "OBN", 80, 90);
            Graduate shredor_graduate = new Graduate(shredor, "How to catch Hesinberg");
            Console.WriteLine(shredor);
            Console.WriteLine(shredor_graduate);
#endif

            Human[] group =
                {
                new Student("Pinkman", "Jessy", 22, "Chemystry", "WW_220", 45, 26),
                new Teacher("White", "Wolter", 50, "Chemystry", 35),
                new Graduate("Shredor", "Hank", 40, "Criminalistic", "OBN", 80, 90, "How to catch Hesinberg"),
                new Student("Vercetty", "Tommy", 30, "Theft", "Vice", 97, 98),
                new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 20)
            };
            foreach (Human i in group)
            {
                Console.WriteLine(i);
            }

#if WRITE_TO_FILE
            StreamWriter sw = new StreamWriter("Group.txt");
            foreach (Human i in group)
            {
                sw.WriteLine(i);
            }
            Process.Start("notepad", "Group.txt");
            sw.Close(); 
#endif
        }
    }
}
