using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Adapter_Pattern.Exisitng_Code
{
    public class Student
    {
        public Student(string studentId, string name, List<string> subjects)
        {
            this.StudentId = studentId;
            this.Name = name;
            this.Subjects = subjects;
        }

        private List<string> subjects = null;

        public string StudentId { get; set; }

        public string Name { get; set; }

        public List<string> Subjects
        {
            get
            {
                return this.subjects;
            }

            set
            {
                this.subjects = value;
            }
        }

        public override string ToString()
        {
            string subjects = string.Empty;
            foreach (string sub in Subjects)
            {
                subjects = subjects + sub +" ";
            }
            return "Student Name : " + this.Name + "; Subjects : " + subjects + ";";
        }
    }
}
