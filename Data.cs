using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace WeekOne
{
    public enum Grading
    {
        F = 0, 
        E = 1,
        D = 2,
        C = 3,
        B = 4,
        A = 5
    }

    public class Data
    {
        public string courseCode;
        public byte courseUnit;   
        public byte courseScore;
        public int weightPoint;
        public byte gradeUnit;
        public char grade;
        public string remark;
        private string[] grading;

        public Data(ArrayList entries)
        {

            this.courseCode = Convert.ToString(entries[0]);
            this.courseUnit = Convert.ToByte(entries[1]);
            this.courseScore = Convert.ToByte(entries[2]);
            this.grading = GetGrade(courseScore);
            this.gradeUnit = Convert.ToByte(grading[2]);
            this.grade = Convert.ToChar(grading[1]);
            this.remark = grading[0];
            this.weightPoint = GetWeightedPoint(this.courseUnit, this.gradeUnit);

        }

        public int GetWeightedPoint(byte courseUnit, byte gradeUnit)
        {
            return  courseUnit * gradeUnit;
        }

        public string[] GetGrade(byte courseScore)
        {
            string[] result;

            switch (courseScore)
            {
                case byte score when (score is > 0 and < 40):
                    result = new string[3] { "Fail", "F", "0" };
                    return result;
                case byte score when (score is > 39 and < 45):
                    result = new string[3] { "Pass", "E", "1" };
                    return result;
                case byte score when (score is > 44 and < 50):
                    result = new string[3] { "Fair", "D", "2" };
                    return result;
                case byte score when (score is > 49 and < 60):
                    result = new string[3] { "Good", "C", "3" };
                    return result;
                case byte score when (score is > 59 and < 70):
                    result = new string[3] { "Very Good", "B", "4" };
                    return result;
                case byte score when (score is > 69 and < 100):
                    result = new string[3] { "Excellent", "A", "5" };
                    return result;
                default:
                    result = new string[3];
                    return result;

            }
        }
    }
}
