using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOne
{
    internal class CGPA
    {
        public int totalCostUnitRegister;

        public CGPA()
        {
            this.totalCostUnitRegister = 0;
        }

        public decimal CalculateCGPA(decimal totalWeightedPoints, decimal totalCourseUnit)
        {
            decimal result = totalWeightedPoints / totalCourseUnit;
            return Math.Round(result, 2);
        }

        public void TotalCostUnitRegister(int score)
        {
            this.totalCostUnitRegister += score;
        }

    }
}
