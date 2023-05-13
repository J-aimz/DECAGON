using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace WeekOne
{
    public class PrintTable
    {
        public void PrintResults(Dictionary<string, decimal> results, Data[] userEntries)
        {
            Table(userEntries);

            Console.WriteLine();
            Console.WriteLine($"Total Course Unit Registered is: {0}", results["totalCourseUnit"]);
            Console.WriteLine($"Total Course Unit Passed: {0}");
            Console.WriteLine($"Total Weight point: {0}", results["totalWeightPoints"]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Your GPA is: {0}", results["gpa"]);
           
        }

        public void Table(Data[] userEntries)
        {
            Console.WriteLine("COURSE & CODE\tCOURSE UNIT\tGRADE\tGRADE-UNIT\tWEIGHT POINT\tREMARK");

            //for (int i = 0; i < userEntries.Length; i++)
            //{
            //    Console.WriteLine($"{0, -10}\t{1,-10}\t{2,-10}\t{3,-10} \t\t{4,-10}", userEntries[i].courseCode, userEntries[i].courseUnit, userEntries[i].grade, userEntries[i].gradeUnit, userEntries[i].weightPoint, userEntries[i].remark );
            //}

            foreach (var data in userEntries)
            {
                Console.WriteLine($"{0, -10}\t{1, -10}\t{2, -10}\t{3, -10}\t{4, -10}", data.courseCode, data.courseUnit, data.grade, data.gradeUnit, data.weightPoint, data.remark);
            }
        }
    }
}
