using System.ComponentModel.DataAnnotations.Schema;

namespace LeetCode_Exercises.Solutions.Set_Mismatch
{
    public class Solution
    {
        public int[] FindErrorNums(int[] nums)
        {
            int result = -1;
            int missingNumber = -1;
            foreach (int num in nums)
            {
                if (nums[Math.Abs(num) - 1] < 0)
                {
                    result = Math.Abs(num);
                }
                else
                {
                    nums[Math.Abs(num) - 1] *= -1;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    result = i + 1;
                }
            }

            return new int[] { result, missingNumber };
        }
    }
}
