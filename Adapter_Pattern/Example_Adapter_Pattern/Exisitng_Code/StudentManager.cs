using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Adapter_Pattern.Exisitng_Code
{
    public class StudentManager
    {
        public List<Student> students = new List<Student>();
        public StudentManager()
        {
            students.Add(new Student("S1","Murali",new List<string> { "Maths", "Physics", "Chemistry" }));
            students.Add(new Student("S2", "krishna", new List<string> { "Physics", "Chemistry" }));
        }
        /*
         * Output :
         * {[S1, Student Name : Murali; Subjects : MathsPhysicsChemistry;; Count : 3;]}
         * {[S2, Student Name : krishna; Subjects : PhysicsChemistry;; Count : 2;]}
        */
        public virtual Dictionary<string,string> GetAllSelectedSujects()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            foreach (Student student in students)
            {
                result.Add(student.StudentId, student.ToString()+ " Count : "+ student.Subjects.Count().ToString()+";");
            }
            return result;
        }
    }
}
