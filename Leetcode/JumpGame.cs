using System;


namespace Leetcode
{

    public class JumpGame
    {
        public bool CanJump(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > max) return false;
                max = Math.Max(nums[i] + i, max);
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
