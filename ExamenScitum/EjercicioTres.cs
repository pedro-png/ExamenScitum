using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenScitum
{
    public static class EjercicioTres
    {
        public static void Execute()
        {
            var a = new int[] { 2, 1, 3, 5, 3, 2 };
            Console.WriteLine("\nPrimero [{0}] :\n", string.Join(", ", a));
            IsDuplicate(a);

            var b = new int[] { 2, 2 };
            Console.WriteLine("\nSegundo [{0}] :\n", string.Join(", ", b));
            IsDuplicate(b);


            var c = new int[] { 2, 4, 3, 5, 1 };
            Console.WriteLine("\nTercero [{0}] :\n", string.Join(", ", c));
            IsDuplicate(c);

            var d = new int[] { 1, 1, 2, 2, 1 };
            Console.WriteLine("\nCuarto [{0}] :\n", string.Join(", ", d));
            IsDuplicate(d);

        }
        private static void IsDuplicate(int[] arrayInt)
        {
            
            var groups = arrayInt.GroupBy(value => value);
            var count = 0;
            int size = GetNumbersElementsRepeat(groups);
            var duplicates = GetDuplicateElements(groups, count, size);
            if (duplicates.Length.Equals(0)) { 
                Console.WriteLine($"-1");
                return;
            }
            int max = 0;
            foreach (var element in duplicates)
            {
                for(int i=0; i< arrayInt.Length; i++)
                {
                    if(arrayInt[i] == element)
                    {
                        for (int j = i+1; j < arrayInt.Length; j++)
                        {
                            if (arrayInt[j] == element)
                            {
                                if (i > j)
                                    max = i;
                                else
                                    max = j;
                            }
                        }
                    }
                }
                
            }
            Console.WriteLine($"Min: {max}");
        }

        private static int[] GetDuplicateElements(IEnumerable<IGrouping<int, int>> groups, int count, int size)
        {
            var arrTemp = new int[size];
            foreach (var group in groups)
            {
                if (group.Count() > 1)
                {
                    arrTemp[count] = group.Key;
                    count++;
                }
            }
            return arrTemp;
        }

        private static int GetNumbersElementsRepeat(IEnumerable<IGrouping<int, int>> groups)
        {
            var count = 0;
            foreach (var group in groups)
            {
                if (group.Count() > 1)
                    count++;
            }
            return count;
        }
    }
}
