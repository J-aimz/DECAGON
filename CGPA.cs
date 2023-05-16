using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOne
{
    internal class CGPA
    {
        

      

        public decimal CalculateCGPA(decimal totalWeightedPoints, decimal totalCourseUnit)
        {
            decimal result = totalWeightedPoints / totalCourseUnit;
            return Math.Round(result, 2);
        }

        public int TotalCostUnitPassed(Data[] data)
        {
            int result = 0;
            foreach (var items in data)
            {
                if (items.grade != 'F')
                {
                    result += items.courseUnit;
                }
            }
            return result;
        }

    }
}
