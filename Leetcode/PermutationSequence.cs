using System;


namespace Leetcode
{

    public class PermutationSequence
    {
        public string GetPermutation(int n, int k)
        {
            List<int> nums = new List<int>();
            int[] factorial = new int[n];
            StringBuilder sb = new StringBuilder();

            int sum = 1;
            factorial[0] = 1;
            for (int i = 1; i < n; i++)
            {
                sum *= i;
                factorial[i] = sum;
            }

            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
            }
            k--;
            for (int i = 1; i <= n; i++)
            {
                int index = k / factorial[n - i];
                sb.Append(nums[index].ToString());
                nums.RemoveAt(index);
                k -= index * factorial[n - i];
            }
            return sb.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
