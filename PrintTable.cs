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
            Console.WriteLine();
            Console.WriteLine("Total Course Unit Registered is: {0}", results["totalCourseUnit"]);
            Console.WriteLine("Total Course Unit Passed: {0}", results["totalCourseUnitPassed"]);
            Console.WriteLine("Total Weight point: {0}", results["totalWeightPoints"]);
            Console.WriteLine("Your GPA is: {0}", results["gpa"]);
           
        }

        public void Table(Data[] userEntries)
        {
            Console.WriteLine("\tCOURSE CODE|\tCOURSE UNIT|\tGRADE|\tGRADE-UNIT|\tWEIGHT-POINT|\tREMARK");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");

            foreach (var data in userEntries)
            {
                Console.WriteLine("\t{0, -12}|\t{1, -10}|\t{2, -5}|\t{3, -10}|\t{4, -10}|\t{5, -7}|", data.courseCode, data.courseUnit, data.grade, data.gradeUnit, data.weightPoint, data.remark);
            }
        }
    }
}
