﻿using Example_Adapter_Pattern.Exisitng_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Adapter_Pattern.New_Code
{
    public class StudentAdapter : StudentManager, IStudent
    {
        /*
        * Output :
        * {[S1, Student Name : Murali; Subjects : Maths Physics Chemistry ; Tution Fee : 6000;]}
        * {[S2, Student Name : krishna; Subjects : Physics Chemistry ; Tution Fee : 4000;]}
       */
        public override Dictionary<string, string> GetAllSelectedSujects()
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            List<Student> students = base.students;
            foreach (Student student in students)
            {
                result.Add(student.StudentId,student.ToString() + " Tution Fee : "+(student.Subjects.Count * 2000));
            }
            return result;
        }
    }
}
