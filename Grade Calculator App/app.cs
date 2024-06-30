using System; 

namespace GradeCalculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade point. Please enter a value between 0 and 100.");
                return;
            }

            char gradeLetter;
            if (grade >= 90)
            {
                gradeLetter = 'A';
            }
            else if ( grade >= 80)
            {
                gradeLetter = 'B';
            }
            else if (grade >= 70)
            {
                gradeLetter = 'C';
            }
            else if (grade >= 60)
            {
                gradeLetter = 'D';
            }
            else 
            {
                gradeLetter = 'F';
            }

            Console.WriteLine($"Your grade is: {gradeLetter}");
        }
    }
}