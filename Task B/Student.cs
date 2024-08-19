using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Student : IComparable
    {
        // Stores the student's age.
        private int age;
        // Stores the student's name.
        private string name; 

        public int Age
        {
            // Sets the student's age.
            set { age = value; }
            // Gets the student's age.
            get { return age; } 
        }
        public string Name
        {
            // Sets the student's name.
            set { name = value; }
            // Gets the student's name.
            get { return name; } 
        }

        public Student(String name)
        {
            // Initializes a student with a name.
            this.name = name; 
        }
        public Student(int age)
        {
            // Initializes a student with an age.
            this.age = age; 
        }
        public Student(String name, int age)
        {
            // Initializes a student with a name and age.
            this.name = name; 
            this.age = age;
        }
        // Implements CompareTo for IComparable.
        public int CompareTo(Object obj) 
        {
            // Casts the object to a Student.
            Student other = (Student)obj;
            // Compares names alphabetically.
            return Name.CompareTo(other.Name); 
        }
    }

}
