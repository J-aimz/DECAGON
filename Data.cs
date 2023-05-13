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
        F, 
        E,
        D,
        C,
        B,
        A
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

        public Data(ArrayList entries)
        {

            this.courseCode = Convert.ToString(entries[0]);
            this.courseUnit = Convert.ToByte(entries[1]);
            this.courseScore = Convert.ToByte(entries[2]);
            this.gradeUnit = GetGrade(courseScore);
            this.weightPoint = GetWeightedPoint(this.courseUnit, this.gradeUnit);
            this.grade = (char)(Grading)gradeUnit;


        }

        public int GetWeightedPoint(byte courseUnit, byte gradeUnit)
        {
            return  courseUnit * gradeUnit;
        }

        public byte GetGrade(byte courseScore)
        {
            switch (courseScore)
            {
                case byte score when (score is > 0 and < 40):
                    this.remark = "Fail";
                    return 0;
                case byte score when (score is > 39 and < 45):
                    this.remark = "Pass";
                    return 1;
                case byte score when (score is > 44 and < 50):
                    this.remark = "Fair";
                    return 2;
                case byte score when (score is > 49 and < 60):
                    this.remark = "Good";
                    return 3;
                case byte score when (score is > 59 and < 70):
                    this.remark = "Very Good";
                    return 4;
                case byte score when (score is > 69 and < 100):
                    this.remark = "Excellent";
                    return 5;
                default:
                    return 0;

            }
        }
    }
}
