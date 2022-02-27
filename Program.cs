using System;

namespace CheckForElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 8, 10 };
            int num = 6;
          string ans = SearchForItemInArray(arr,num);
            Console.WriteLine(ans);
        }

        static string  SearchForItemInArray(int [] numberArr, int number)
        {
            
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] == number)
                {
                    return $"The element {number} is at index {i}";                   
                }
            }
            return $"The element {number} is not in the array"; ;           
        }
    }
}
