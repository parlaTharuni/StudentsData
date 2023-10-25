using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\\New folder\\students_data.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

               Console.WriteLine("Students Data:");
                Console.WriteLine();
                Console.WriteLine("ID\tName\tGrade");

                foreach (string line in lines.Skip(1)) // Skip the header line
                {
                    string[] parts = line.Split(',');
                    int ID = int.Parse(parts[0]);
                    string name = parts[1];
                    string grade = parts[2];

                    Console.WriteLine($"{ID}\t{name}\t{grade}");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("File not found: student_data.txt");
                Console.ReadLine();
            }
            
            Console.ReadLine();
        }
    }
}

