using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }
    public static class Function
    {
          public static bool IsSorted(int[] array, var order)
        {
            String factOrder = "0";
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1]) factOrder = "Ascending";
                else { break; }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1]) factOrder = "Descending";
                else { break; }
            }
            if (order == factOrder) return true;
            return false;
        }

        public static int Transform(int[] array, var order)
        {
            if (IsSorted(array, order) == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] + i;
                }
                return array;
            }
            else return array;
        }

        public static double MultArithmeticElements(double a, double t, int n)
        {
            double result = a;
            for (int i = 1; i < n; i++)
            {
                a = a + t;
                result = result * a;
            }
            return result;
        }

        public static double SumGeometricElements (double a, double t, double alim)
        {
             double summ = a;
            if (t< 1 && t> 0) 
            {
                for (double an = a* t; an > alim; an = a* t)
                {
                    summ = summ + an;
                    a1 = an;
                    Console.WriteLine(an + " - an " + summ + " - sum");
                }
            return summ;
            }
            else return summ;
        }
    }

    }
}
