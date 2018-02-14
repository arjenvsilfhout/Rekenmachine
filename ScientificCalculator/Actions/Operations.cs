namespace ScientificCalculator.Model
{
    using System;

    /// <summary>
    /// Class Operations.
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Adds the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// Substracts the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        /// <summary>
        /// Divisions the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Division(decimal a, decimal b)
        {
            return a / b;
        }

        /// <summary>
        /// Moduloes the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Modulo(decimal a, decimal b)
        {
            return a % b;
        }

        /// <summary>
        /// Identities the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
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
            return (decimal)Math.Sin((double)a);
        }

        /// <summary>
        /// Cosinuses the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Cosinus(decimal a)
        {
            return (decimal)Math.Cos((double)a);
        }

        /// <summary>
        /// Tangenses the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Tangens(decimal a)
        {
            return (decimal)Math.Tan((double)a);
        }

        /// <summary>
        /// Factorials the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Factorial(decimal a)
        {
            decimal f = 1;
            for (int i = 0; i < a; i++)
            {
                f = f * i;
            }

            return f;
        }

        /// <summary>
        /// SQRTs the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Sqrt(decimal a)
        {
            return (decimal)Math.Sqrt((double)a);
        }

        /// <summary>
        /// Powers the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Power(decimal a, int b)
        {
            decimal result = a;
            for (int i = 0; i < b; i++)
            {
                a = a * a;
            }
            return result;
        }

        /// <summary>
        /// Logarithms the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <returns>System.Decimal.</returns>
        public static decimal Logarithm(decimal a)
        {
            return (decimal)Math.Log((double)a);
        }
    }
}