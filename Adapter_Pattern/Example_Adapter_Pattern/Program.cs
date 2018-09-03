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
            /*Old code*/
            StudentManager studentManager = new StudentManager();
            result = studentManager.GetAllSelectedSujects();
            Console.WriteLine("Old code without using Adapter class");
            DisplayResult(result);

            Console.WriteLine();

            /*New code*/
            IStudent student = new StudentAdapter();
            result = student.GetAllSelectedSujects();
            Console.WriteLine("New code with using Adapter class");
            DisplayResult(result);

            Console.ReadLine();
        }

        static void DisplayResult(Dictionary<string, string> result)
        {
            foreach (KeyValuePair<string, string> re in result)
            {
                Console.WriteLine("Key : " + re.Key+" Value : " +re.Value);
            }
        }
    }
}
