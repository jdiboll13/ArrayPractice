using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayPractice
{
    class Program
    {

        public static int countMults(int[] nums, int divisibility)
        {
            var divisibleCount = 0;
            foreach (var item in nums)
            {
                if (item % divisibility == 0)
                {
                    divisibleCount++;
                }
            }
            return divisibleCount;
        }

        public static bool hasThreeNonAdjacentThrees(int[] nums)
        {
            var threeCount = 0;
            foreach (var item in nums)
            {
                if (item == 3)
                {
                    threeCount++;
                }
            }
            if (threeCount != 3)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] == 3 && nums[i + 1] == 3)
                    {
                        return false;
                    }
                }
                return true;
            }


        }

        public static bool containsString(char[] letters, string word)
        {
            
            var letterCount = word.Where(l => letters.Contains(l)).Count();
            //letterCount = where l(current cahracter in word) is equal to l(current character in letters array) then add to count.
            return letterCount == word.Length;
            

        }

        static void Main(string[] args)
        {
            var firstNumList = new List<int>();
            firstNumList.Add(1);
            firstNumList.Add(3);
            firstNumList.Add(15);
            firstNumList.Add(3);
            firstNumList.Add(21);
            firstNumList.Add(3);
            firstNumList.Add(4);
            var myArray = firstNumList.ToArray();
            Console.WriteLine(countMults(myArray, 3));

            Console.WriteLine(hasThreeNonAdjacentThrees(myArray));

            var letters = new char[6];
            letters[0] = 'a';
            letters[1] = 'd';
            letters[2] = 'o';
            letters[3] = 'd';
            letters[4] = 'e';
            letters[5] = 'g';

            Console.WriteLine(containsString(letters, "doge"));
        }
    }
}
