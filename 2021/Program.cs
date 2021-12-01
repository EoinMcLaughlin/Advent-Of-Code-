using System;
using System.IO;

namespace _2021
{
    class Program
    {
        static void Main()
        {
            string[] numbers = File.ReadAllText(@"Day1.txt").Split(Environment.NewLine);
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers2[i] = Convert.ToInt32(numbers[i]);
            }

            #region Part One
            int increasecount = 0;
            for (int i = 0; i < numbers2.Length - 1; i++)
            {
                if (numbers2[i] < numbers2[i + 1])
                {
                    increasecount++;
                }
            }
            Console.WriteLine(increasecount);
            #endregion

            #region Part Two
            int total = 0, secondtotal = 0;
            increasecount = 0;
            for (int i = 0; i < numbers2.Length - 3; i++)
            {

                total = numbers2[i] + numbers2[i + 1] + numbers2[i + 2];
                secondtotal = numbers2[i + 1] + numbers2[i + 2] + numbers2[i + 3];
                if (total < secondtotal)
                {
                    increasecount++;
                }
            }

            Console.WriteLine(increasecount);
            #endregion
        }
    }
}
