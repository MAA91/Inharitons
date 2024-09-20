using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName {  get; set; }
        public string FirstName {  get; set; }
        public uint Age {  get; set; }

        public Human(string lastName, string firstName, uint age)
        {
            LastName = lastName;
            FirstName = firstName;
            Age = age;
            Console.WriteLine($"HContructor:\t{GetHashCode()}");
        }
        public Human(Human other)
        {
            LastName = other.LastName;
            FirstName = other.FirstName;
            Age = other.Age;
            Console.WriteLine($"HCopyConstructor:\t{GetHashCode()}");
        }
        ~Human()
        {
            Console.WriteLine($"HDistructor:\t{GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $": {LastName} {FirstName} {Age} y/o";
        }
    }
}
