using System;
using System.Collections.Generic;

namespace Chap_16_studio_part2
{
    class Program
    {
        static int CheckFileExt(string fileName)
        {
            /*input a string
             * split by '.'
             * if array[1] contains cs = point
             * if not cs no point
             * if no array[1] return error 
             * if array[1] contains " " return error*/
            string[] extCheckArr = fileName.Split('.');
            try
            {
                if (extCheckArr[1].Contains("cs"))
                {
                    Console.WriteLine("Woooo you got a point");
                    return 1;
                }
                else if (extCheckArr[1].Contains(" "))
                {
                    Console.WriteLine("Please input a valid file extension");
                    return 0;
                }
                else
                {
                    Console.WriteLine("dang you input the wrong file type no points");
                    return 0;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please input a valid filename with a file extension");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a filename:");
            string fileName = Console.ReadLine();
            CheckFileExt(fileName);
            Dictionary<string, string> studenInputs = new Dictionary<string, string>
            { 
                {"joe", "project.cs" },
                {"anne", "file.txt" },
                {"frank", "file" },
                {"eileen", "project." }
            };

            foreach(KeyValuePair<string,string> student in studenInputs)
            {
                Console.WriteLine($"{student.Key}:");
                int points = CheckFileExt(student.Value);
                Console.WriteLine($"{student.Key} was awarded {points} points.");

            }
        }
    }
}
