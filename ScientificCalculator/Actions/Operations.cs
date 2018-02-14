namespace ScientificCalculator.Model
{
    using System;

    /// <summary>
    /// Class Operations.
    /// </summary>
    public static class Operations
    {
        public static decimal Add(decimal a, decimal b)
        {
            // TODO: nummer optellen en teruggeven

            return a + b;
        }

        public static decimal Substract(decimal a, decimal b)
        {
            // TODO: nummers aftrekken en teruggeven
            return a - b;
        }
        
        public static decimal Multiplicate(decimal a, decimal b)
        {
            // TODO: vermenigvuldigen
            return a * b;
        }
        public static decimal Divide(decimal a, decimal b)
        {
            // TODO: delen
            return a / b;
        }

        public static decimal Modulo(decimal a, decimal b)
        {
            return a % b;
        }

        public static decimal Identity(decimal a)
        {
            return a;
        }

        /// <summary>
        /// Sinuses the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Sinus(decimal a)
        {
            // TODO: sinus implementeren
            return (decimal)Math.Sin((double)a);
        }

        /// <summary>
        /// Factorials the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Factorial(decimal a)
        {
            // TODO: factorial implementeren
            return a;
        }

        public static decimal Power(decimal a, int b)
        {
            return (decimal)Math.Pow((double)a, (double)b);

            //decimal result = 1;
            //for (int i = 0; i < b; i++)
            //{
            //    result = result * a;
            //}
            //return result;
        }
    }
}