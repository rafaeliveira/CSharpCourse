using System;
using System.Collections.Generic;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = null;
            HashSet<int> courseB = null;
            HashSet<int> courseC = null;

            courseA = GetHashSet("A");
            courseB = GetHashSet("B");
            courseC = GetHashSet("C");

            courseA.UnionWith(courseB);
            courseA.UnionWith(courseC);

            Console.WriteLine("Total of students: "+ courseA.Count);
            
            /*
            Exemplos ex = new Exemplos();
            ex.Exemplo();
            */
        }

        public static HashSet<int> GetHashSet(string courseName)
        {
            int iNumStudents = 0;

            HashSet<int> course = new HashSet<int>();

            Console.Write("How many students have course "+courseName+"? ");
            iNumStudents = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the students code of the course " + courseName + ": ");

            for (int i = 0; i < iNumStudents; i++)
            {
                course.Add(int.Parse(Console.ReadLine()));
            }

            return course;
        }
    }
}
