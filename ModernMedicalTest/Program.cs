using System;
using System.Globalization;
using System.Text;
using SharedExtensions;

namespace ModernMedicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Create a StringBuilder for efficiency
            //
            var stringBuilder = new StringBuilder();

            //
            // Loop through 100 numbers from 1 to 100, storing the value in a loop control variable (lcv)
            // for each iteration.
            //
            // locals:
            //     lcv: The loop control variable
            //     answer: The final answer (also used for temporary storage)
            //
            for(var lcv = 1; lcv <= 100; stringBuilder.Clear(), ++lcv)
            {
                //
                // Append "Modern" to the StringBuilder if divisible by 3
                //
                if (lcv.IsDivisibleBy(3))
                {
                    stringBuilder.Append("Modern");
                }
                
                //
                // Append "Medical" to the StringBuilder if divisible by 5
                // So, if the 
                if (lcv.IsDivisibleBy(5))
                {
                    stringBuilder.Append("Medical");
                }

                // Get the temporary answer...
                var answer = stringBuilder.ToString();

                //
                // The answer will be empty if not divisible by 3 and not divisible by 5..
                // In this case, change the answer to the actual number.
                //
                if (string.IsNullOrEmpty(answer))
                {
                    answer = lcv.ToString(CultureInfo.InvariantCulture);
                }

                Console.WriteLine(answer);
            }

            Console.WriteLine("\nHit any key to exit");

            Console.ReadKey();
        }
    }
}
