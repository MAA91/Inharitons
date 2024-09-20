using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string Specialyty {  get; set; }
        public uint Experianse { get; set; }

        public Teacher(
                        string lastName, string firstName, uint age,
                        string specialyty, uint experianse
                      ):base(lastName, firstName, age)
        {
            Specialyty = specialyty;
            Experianse = experianse;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }
        public Teacher
            (
                Human human,
                string specialyty, uint experianse
            ):base(human)
        {
            Specialyty = specialyty;
            Experianse = experianse;
            Console.WriteLine($"TConstructor:\t{GetHashCode()}");
        }

        ~Teacher()
        {
            Console.WriteLine($"TDistructor:\t{GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {Specialyty} {Experianse}";
        }

    }
}
