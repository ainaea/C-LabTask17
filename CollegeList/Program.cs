using System;
using System.Linq;

namespace CollegeList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            CollegeEmployee colEmp1 = new CollegeEmployee("James", "Stuart", "Avenue B, Lane 5", "245678", "+0112456879", "456-879-10", 2000M, "Physics");
            CollegeEmployee colEmp2 = new CollegeEmployee("Janet", "Wallace", "Avenue C, Lane 9", "246578", "+0252456879", "+456-879-10", 1850M, "Geography");

            Faculty facEmp1 = new Faculty("Judas", "Brown", "Avenue D, Lane 7", "554488", "+245621137", "225-456-44", 2105M, "Economics", false);
            Faculty facEmp2 = new Faculty("Esther", "Easter", "Avenue E, Lane 8", "550088", "+195621137", "330-456-44", 2105M, "Economics", false);

            Student student1 = new Student("Mike", "Hanger", "Avenue F, Lane 12", "214990", "+11265422", "Yoruba", 2.31M);
            Student student2 = new Student("Ruth", "Hover", "Avenue G, Lane 10", "255990", "+11999422", "French", 3.67M);

            Person[] members = new Person[]{colEmp1, colEmp2, facEmp1, facEmp2, student1, student2};

            foreach (Person member in members)
            {
                if (member is Student)
                {
                    var modStudent = (Student)member;
                    modStudent.Field = "Computer Science";
                }
                Console.WriteLine(member + "\n");
            }

            // Console.WriteLine(members[4].);

        }
    }
}
