namespace SharedExtensions
{
    /// <summary>
    /// Extensions for integers
    /// </summary>
    static public class IntExtensions
    {
        /// <summary>
        /// Output whether or not a given number is divisible by a given divisor
        /// </summary>
        /// <param name="number">The number to check</param>
        /// <param name="divisor">The divisor to use</param>
        /// <returns>True if number is divisible by divisor, False if not (or if divisor is zero or negative)</returns>
        static public bool IsDivisibleBy(this int number, int divisor)
        {
            if (divisor <= 0)
                return false;

            return number % divisor == 0;
        }
    }
}
