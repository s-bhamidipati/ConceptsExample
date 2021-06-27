using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConceptsExample
{
    class StudentClassforExcep
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
    }
    public class ExcepProgramResult
    {
        public static void Main()   
        {
            StudentClassforExcep sc = new StudentClassforExcep();
            sc.StudentName = "Srinivas";
            ValidateStudent("srini123_-");//call directily

        }

        /// <summary>
        /// static Method no need of any object creation 
        /// </summary>
        /// <param name="std"></param>
        public static void ValidateStudent(string std)
        {
            Regex regex = new Regex(@"^[A-Za-z]\w{0,14}$");
            if (regex.IsMatch(std.ToString()))
            {
                Console.WriteLine("mg");
            }
            else
            {
                throw new CustomExceptionExample(std.ToString());
            }
        }

    }
}
