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
        public static decimal Power(decimal a, int b)
        {
            decimal result = 1;
            for (int i = 0; i < b; i++)
            {
                result = result * a;
            }
            return result;
        }
        public static decimal Modulo(decimal a, decimal b)
        {
            return a % b;
        }
    }
}