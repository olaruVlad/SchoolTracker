using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make commit  number two on Main branch");
            var studentCount = int.Parse(Console.ReadLine());

            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("Student name:");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student grade:");
                studentGrades[i] = int.Parse (Console.ReadLine());
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
           
        }
    }
}
