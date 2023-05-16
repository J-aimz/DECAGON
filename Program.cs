using System.Collections;

namespace WeekOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //get number of courses
            int maxCourse = GetCourseMax();

            //initialise array 
            Data[] data = new Data[maxCourse];

            //get and store user data
            for (int i = 0; i < maxCourse; i++)
            {
                var newEntry = GetCourseData();
                data[i] = new Data(newEntry);
            }
            
            var totalResult = CalculateGpa(data, maxCourse);

            var printTable = new PrintTable();



            //print results
            printTable.PrintResults(totalResult, data);
            Console.ReadKey();
        }

        public static void PrintFinalResults(Dictionary<string, decimal> result)
        {
            Console.WriteLine("donne");
        }
        public static Dictionary<string, decimal> CalculateGpa(Data[] sentData, int limit)
        {
            var result = new Dictionary<string, decimal>();
            result.Add("gpa", 0);
            result.Add("totalCourseUnit", 0);
            result.Add("totalWeightPoints", 0);
            result.Add("totalCourseUnitPassed", 0);

            var gpa = new CGPA();
            //aggregate of weighted points and course unit
            for (int i = 0; i < limit; i++)
            {
                //get total weighted points
                result["totalWeightPoints"] += sentData[i].weightPoint;

                //get total course unit
                result["totalCourseUnit"] += sentData[i].courseUnit;
            }


            //calculate gpa
            result["gpa"] = gpa.CalculateCGPA(totalWeightedPoints: result["totalWeightPoints"], totalCourseUnit: result["totalCourseUnit"]);
            result["totalCourseUnitPassed"] = gpa.TotalCostUnitPassed(sentData);

            return result;
        }
        
        //method receives data for each course
        public static ArrayList GetCourseData()
        {
            Console.Clear();
            var prompt = new string[3] { "Input Course Code: ", "Input Course Unit: ", "Input Course Score: " };
            var allInput = new ArrayList();

            for (int i = 0; i < prompt.Length; i++)
            {
                bool inputIsValid = false;
                string input = null;
                //without the chks
                //Console.WriteLine(prompt[i]);
                //input = Console.ReadLine();


                //do
                //{
                //} while (inputIsValid);

                jumpBack: 
                    Console.WriteLine(prompt[i]);
                    input = Console.ReadLine();
                    int unit = 0;
                    int score = 0;

                    if (i == 0 && (!string.IsNullOrEmpty(input) || !string.IsNullOrWhiteSpace(input) || input == " "))
                        inputIsValid = true;
                    if (i == 1 && int.TryParse(input, out unit) && unit > 0 && unit < 6)
                            inputIsValid = true;
                    if (i == 2 && int.TryParse(input, out score) && score >= 0 && score <= 100)
                        inputIsValid = true;

                    if(!inputIsValid)
                        goto jumpBack;

                

                allInput.Add(input);
            }
            Console.Clear();

            return allInput;
        }

        public static int GetCourseMax()
        {
            bool isInputValid = false;
            int value = 0; 
            while (!isInputValid)
            {
                Console.WriteLine("Enter number of courses: ");
                string maxCourse = Console.ReadLine();
                if (int.TryParse(maxCourse, out value))
                {
                    isInputValid = true;
                }
            }

            return value;
        }
    }
}

