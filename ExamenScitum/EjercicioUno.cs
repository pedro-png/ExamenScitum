using System;
using System.Collections.Generic;

namespace ExamenScitum
{
    public static class EjercicioUno
    {
        private static int countChar = 0;

        public static void Execute() => GetAllRepeatFirstChar();
        private static void GetAllRepeatFirstChar()
        {
            string[] arrayValues = new string[] { "aaabbcddddefff", "abcdefg", "eerlv", "rrtttv", "dddffffttttttttnnnnnnnmmmm" };
            foreach(var value in arrayValues)
                Console.WriteLine(GetRepeatFirstChar(value));
        }
        private static string GetRepeatFirstChar(string @char)
        {
            var stringArray = @char.ToCharArray();

            for (int i = 0; i < stringArray.Length; i++)
            {
                for (int j = 0; j < stringArray.Length; j++)
                {
                    if (stringArray[i] == stringArray[j])
                        countChar++;
                }
                if (countChar == 1)
                {
                    countChar = 0;
                    return stringArray[i].ToString();
                }
                countChar = 0;
            }
            return "NA";
        }
    }
}
