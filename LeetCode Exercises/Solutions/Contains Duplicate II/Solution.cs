namespace LeetCode_Exercises.Solutions.Contains_Duplicate_II
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {

            if (nums == null || nums.Length < 1)
                return false;

            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);
                }
                else
                {
                    if (i - dic[nums[i]] <= k)
                        return true;
                    else
                        dic[nums[i]] = i;
                }
            }

            return false;
        }
    }
}
