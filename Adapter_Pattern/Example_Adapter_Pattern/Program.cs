using Example_Adapter_Pattern.Exisitng_Code;
using Example_Adapter_Pattern.New_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = null;
            List<string> studentList = null;
            /*Old code*/
            StudentManager studentManager = new StudentManager();
            result = studentManager.GetAllSelectedSujects();
            Console.WriteLine("Old code without using Adapter class");
            DisplayResult(result);
            studentList = studentManager.GetStudentList();
            Console.WriteLine();
            Console.WriteLine("GetStudentList() Method in StudentManager Class accessing using StudentManager class");
            DisplayStudents(studentList);
            Console.WriteLine();

            /*New code*/
            StudentAdapter student = new StudentAdapter();
            result = student.GetAllSelectedSujects();
            Console.WriteLine("New code with using Adapter class");
            DisplayResult(result);
            studentList = student.GetStudentList();
            Console.WriteLine();
            Console.WriteLine("GetStudentList() Method in StudentManager Class accessing using Adapter class");
            DisplayStudents(studentList);
            Console.ReadLine();
        }

        static void DisplayResult(Dictionary<string, string> result)
        {
            foreach (KeyValuePair<string, string> re in result)
            {
                Console.WriteLine("Key : " + re.Key+" Value : " +re.Value);
            }
        }

        static void DisplayStudents(List<string> studentList)
        {
            foreach (string student in studentList)
            {
                Console.WriteLine(student);
            }
        }
    }
}
