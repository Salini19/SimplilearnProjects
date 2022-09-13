using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseAssignmnets
{
    internal class Problem
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            Student s1 = new Student() { Name = "Salini", ClassAndSection = "x A" };
            Student s2 = new Student() { Name = "Sameer", ClassAndSection = "x A" };
            Student s3 = new Student() { Name = "Shivaani", ClassAndSection = "XI D" };
            Student s4 = new Student() { Name = "Thashwanth", ClassAndSection = "V B" };
            Student s5 = new Student() { Name = "Rubini", ClassAndSection = "XI C" };
            Student s6 = new Student() { Name = "sruthika", ClassAndSection = "XI D" };
            Student s7 = new Student() { Name = "Vishnu", ClassAndSection = "IV C" };
            Student s8 = new Student() { Name = "Varshita", ClassAndSection = "XII A" };
           

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);

            List<Subject> subjects = new List<Subject>();
            
            Subject sub1 = new Subject() { Name= "Ms Rani", SubjectCode = "Phy-R123", ClassAndSection = "IV C", SubjectName = "Physis" };
            Subject sub2 = new Subject() { Name = "Mrs HemaMazhini", SubjectCode = "Sst-M102", ClassAndSection = "XII A", SubjectName = "Social Science" };
            Subject sub3 = new Subject() { Name = "Mr Thilagar", SubjectCode = "Mat-U203", ClassAndSection = "XI D", SubjectName = "Maths" };
            Subject sub4 = new Subject() { Name = "Ms Kanimozhi", SubjectCode = "Che-R123", ClassAndSection = "V B", SubjectName = "Chemistry" };
            Subject sub5 = new Subject() { Name = "Mr SivaPraksam", SubjectCode = "Skt-M102", ClassAndSection = "XI C", SubjectName = "Sanskrit" };
            Subject sub6 = new Subject() { Name = "Mrs VanajaRanjan", SubjectCode = "Sci-U203", ClassAndSection = "XI D", SubjectName = "Science" };
            Subject sub7 = new Subject() { Name = "Ms Revathi", SubjectCode = "Tam-T203", ClassAndSection = "X A", SubjectName = "Tamil" };

            subjects.Add(sub1);
            subjects.Add(sub2);
            subjects.Add(sub3);
            subjects.Add(sub4);
            subjects.Add(sub5);
            subjects.Add(sub6);
            subjects.Add(sub7);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Displaying the data:");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Students in a class");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
  
            foreach (Student s in students)
            {
                Console.WriteLine("Student Name      : " + s.Name);
                Console.WriteLine("Class And Section : " + s.ClassAndSection);           
                Console.WriteLine();
            }
            // Console.WriteLine(s.DisplayInfo());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Subjects Taught By Teacher");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            foreach (Subject s in subjects)
            {
                Console.WriteLine("Teacher Name      : " + s.Name);
                Console.WriteLine("Subject Code      : " + s.SubjectCode);
                Console.WriteLine("Class and Section : " + s.ClassAndSection);
                Console.WriteLine("Subject Name      : " + s.SubjectName);
                Console.WriteLine();

            }
                //Console.WriteLine(s.DisplayInfo());

            Console.ReadLine();
        }
    }
}
