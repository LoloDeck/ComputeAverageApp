using System;
namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine(">> Welcome to the Average Calculator App <<");
            Console.WriteLine("===========================================");
            Console.Write("Enter the first grade  : ");
            float fGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the second grade : ");
            float sGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the third grade  : ");
            float tGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the fourth grade : ");
            float fourthGrade = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter the fifth grade  : ");
            float fifthGrade = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("===========================================");


            float average = (fGrade + sGrade + tGrade + fourthGrade + fifthGrade) / 5;
            int roundedAve = Convert.ToInt32(average);

            Console.WriteLine("The average is " + average + " and round off to " + roundedAve);
            Console.WriteLine("===========================================");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}