using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenScitum
{
    public static class EjercicioDos
    {
        private const int IsSix = 6; 
        public static void Execute()
        {
            
            var firstArray = new int[] { 1, 2, 4, 5, 1 };
            Console.WriteLine("Primero [{0}] :\n", string.Join(", ", firstArray));
            IsSumSixByPair(firstArray);
            
            var secondtArray = new int[] { 1, 2, 3, 5, 8 };
            Console.WriteLine("\nSegundo [{0}] :\n", string.Join(", ", secondtArray));
            IsSumSixByPair(secondtArray);
            
            var thirdArray = new int[] { 4, 3, 2, 1, 3, 5, 3, 4, 1 };
            Console.WriteLine("\nTercero [{0}] :\n", string.Join(", ", thirdArray));
            IsSumSixByPair(thirdArray);
            
            var fourtArray = new int[] { 20, 3, 1, 2, 9 };
            Console.WriteLine("\nCuarto [{0}] :\n", string.Join(", ", fourtArray));
            IsSumSixByPair(fourtArray);
        } 
        private static void IsSumSixByPair(int [] arrayInt)
        {
            int countSuccess = 0;
            for(int i = 0; i < arrayInt.Length; i++)
            {
                for(int j = i+1; j < arrayInt.Length; j++)
                {
                    if(arrayInt[i] + arrayInt[j] == IsSix & (i+1== j))
                    {
                        countSuccess++;
                        Console.WriteLine($"[{arrayInt[i]}, {arrayInt[j]}]");
                    }

                }
            }
            if (countSuccess.Equals(0)) Console.WriteLine("-1");
        }
    }
}
