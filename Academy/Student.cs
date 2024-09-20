using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Student:Human
    {
        public string Specialyty { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }
        
        public Student
            (
                string lastName, string firstName, uint age,
                string specialyty, string group, double rating, double attendance
            ):base(lastName, firstName, age)
        {
            Specialyty = specialyty;
            Group = group;
            Rating = rating;
            Attendance = attendance;
            Console.WriteLine($"SConstructor:\t{GetHashCode()}");
        }
        public Student
            (
                Human human,
                string specialyty, string group, double rating, double attendance
            ):base(human)
        {
            Specialyty= specialyty;
            Group = group;  
            Rating = rating;
            Attendance = attendance;
        }
        public Student(Student other):base(other.LastName, other.FirstName, other.Age)
        {
            Specialyty = other.Specialyty;
            Group = other.Group;    
            Rating = other.Rating;
            Attendance = other.Attendance;
            Console.WriteLine($"SCopyConstructor:\t{GetHashCode()}");
        }
        ~Student()
        {
            Console.WriteLine($"SDistructor:\t{GetHashCode()}");
        }

        public override string ToString()
        {
            return base.ToString() + $" {Specialyty} {Group} {Rating} {Attendance}";
        }
    }
}
