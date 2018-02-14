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
            return a + b;
        }

        public static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public static decimal Division(decimal a, decimal b)
        {
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

        public static decimal Power(decimal a, int b)
        {
            // TODO: Power implementeren
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
    }
}