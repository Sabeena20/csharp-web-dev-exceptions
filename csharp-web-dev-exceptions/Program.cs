using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (y <= 0)
            {
                throw new ArgumentOutOfRangeException("Value of Y is zero");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            int point = 0;
            if (fileName == null || fileName == "")
            {
                throw new ArgumentNullException("File name is empty or null.");
            }
            if (fileName.Contains(".cs"))
            {
                point++;
            }
            else if (!fileName.Contains(".cs"))
            {

                point = 0;
            }
            return point;

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Console.WriteLine(Divide(1, 2));
                Console.WriteLine(Divide(1, 0));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            try
            {
                Dictionary<string, string> students = new Dictionary<string, string>();
                students.Add("Carl", "Program.cs");
                students.Add("Brad", "");
                students.Add("Elizabeth", "MyCode.cs");
                students.Add("Stefanie", "CoolProgram.cs");

                foreach (KeyValuePair<string, string> entry in students) {
                    Console.WriteLine(entry.Key + ":" + CheckFileExtension(entry.Value));
                }

            }
           

            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
