using System;

namespace Function
{
    public enum SortOrder { Ascending, Descending }   
    public static class Function
    {
        public static bool IsSorted(int[] array, SortOrder order)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1] && order == SortOrder.Ascending) count++;
                else { break; }
            }
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] >= array[j + 1] && order == SortOrder.Descending) count++;
                else { break; }
            }
            if (count == array.Length - 1) return true;
            else return false;
        }

        public static void Transform(int[] array, SortOrder order)
        {
            if (IsSorted(array, order) == true)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array[i] + i;
                }
            }
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

        public static double SumGeometricElements(double a, double t, double alim)
        {
            double summ = a;
            double def = 0;
            if (t < 1 && t > 0 && a > alim)
            {
                for (double an = a * t; an > alim; an = a * t)
                {
                    summ = summ + an;
                    a = an;                  
                }
                return summ;
            }
            else return def;
        }
    }

}

