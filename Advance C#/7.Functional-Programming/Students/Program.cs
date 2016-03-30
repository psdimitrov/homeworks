using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            ReadStudents(students);
            PrintStudentsGroupTwo(students);
            PrintStudentsFirstNameBeforeLast(students);
            PrintStudentsAgeBetween(students);
            PrintSortedStudents(students);
            FilterStudentsByEmail(students);
            PrintStudentFromSofia(students);
            PrintExcellentStudents(students);
            PrintWeakStudents(students);
            
        }

        private static void PrintWeakStudents(List<Student> students)
        {
            var weakstudents = students.Where(x => x.Marks.Count(y => y == 2) == 2);

            foreach (var student in weakstudents)
            {
                Console.WriteLine("{0} {1}- {2}",student.FirstName, student.LastName, string.Join(", ",student.Marks));
            }
        }

        

        private static void ReadStudents(List<Student> students)
        {
            StreamReader reader = new StreamReader("..\\..\\Students-data.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] tokens = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstName = tokens[1];
                    string lastName = tokens[2];
                    int age = int.Parse(tokens[5]);
                    long facNumber = long.Parse(tokens[6]);
                    string phone = tokens[4];
                    string email = tokens[3];
                    int groupNumber = int.Parse(tokens[0]);
                    List<int> marks = new List<int>();
                    for (int i = 7; i < tokens.Length; i++)
                    {
                        marks.Add(int.Parse(tokens[i]));
                    }
                    students.Add(new Student(firstName, lastName, age, facNumber, phone, email, marks, groupNumber));
                }
            }
        }

        private static void PrintExcellentStudents(List<Student> students)
        {
            var excellentStudents = from student in students
                                    where student.Marks.Contains(6)
                                    select new { Fullname = student.FirstName + " " + student.LastName, student.Marks };
            Console.WriteLine("Excellent students:\n");
            foreach (var excellentStudent in excellentStudents)
            {
                Console.WriteLine("{0} - {1}", excellentStudent.Fullname, string.Join(", ",excellentStudent.Marks));
            }
        }

        private static void PrintStudentFromSofia(List<Student> students)
        {
            var sofiaStudents = students.Where(s => s.Phone.StartsWith("02") 
                                                || s.Phone.StartsWith("+3592")
                                                || s.Phone.StartsWith("+359 2"));

            Console.WriteLine("Students with phone numbers from Sofia");                   
            foreach (var student in sofiaStudents)
            {
                Console.WriteLine("{0} {1} - {2}", student.FirstName, student.LastName, student.Phone);
            }
            Console.WriteLine();
        }

        private static void FilterStudentsByEmail(List<Student> students)
        {
            var studentsABVemail = from student in students
                                   where student.Email.EndsWith("@abv.bg")
                                   select student;
            Console.WriteLine("Students with ABV email:");
            foreach (var student in studentsABVemail)   
            {
                Console.WriteLine("{0} {1} - {2}",student.FirstName, student.LastName, student.Email);
                
            }
        }

        private static void PrintSortedStudents(List<Student> students)
        {
            var sortedStudents = from student in students
                                 orderby student.LastName descending
                                 orderby student.FirstName descending
                                 select student;
                                 
            //students.OrderByDescending(a => a.FirstName).ThenByDescending(b => b.LastName);
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}",student.FirstName,student.LastName);
            }
            Console.WriteLine();
        }

        private static void PrintStudentsGroupTwo(List<Student> students)
        {
            var studentsFromGroupTwo = from student in students
                                       where student.GroupNumber == 2
                                       orderby student.FirstName
                                       select student;
            Console.WriteLine("Students in Group 2:");
            foreach (var student in studentsFromGroupTwo)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
        }
        private static void PrintStudentsFirstNameBeforeLast(List<Student> students)
        {
            var studentsFirstNameBeforeLast = from student in students
                                       where student.FirstName.CompareTo(student.LastName) < 0                                       
                                       select student;
            Console.WriteLine("Students whose first name is before their last name alphabetically:");
            foreach (var student in studentsFirstNameBeforeLast)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine();
        }
        private static void PrintStudentsAgeBetween(List<Student> students)
        {
            var studentsAgeBetween = from student in students
                                     where student.Age >= 18 && student.Age <= 24
                                     select (new { student.FirstName, student.LastName, student.Age });
            Console.WriteLine("Students whose age is between 18 and 24:");
            foreach (var student in studentsAgeBetween)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine();
        }
    }
}
