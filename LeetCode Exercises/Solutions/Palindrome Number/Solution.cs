namespace LeetCode_Exercises.Solutions.Palindrome_Number
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }

            var tmp = x;
            var comparison = 0;
            var currentNumber = 0;

            while (tmp != 0)
            {
                currentNumber = tmp % 10;
                comparison = comparison * 10 + currentNumber;
                tmp /= 10;
            }

            return x == comparison;
        }
    }
}
