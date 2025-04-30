namespace Leetcode.Exercies
{

	/*
    Given an integer x, return true if x is a palindrome and false otherwise.

    Example 1:
    Input: x = 121
    Output: true
    Explanation: 121 reads as 121 from left to right and from right to left.

    Example 2:
    Input: x = -121
    Output: false
    Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

    Example 3:
    Input: x = 10
    Output: false
    Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
    */


	public static class IsPalindrome
    {
        public static bool MyWay(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else if (x == 0)
            {
                return false;
            }

            string xConverted = x.ToString();

            for (int i = 0; i < (xConverted.Length / 2); i++)
            {
                if (xConverted[i] != xConverted[xConverted.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool BestWay(int x)
        {
			if (x < 0 || (x % 10 == 0 && x != 0))
				return false;

			int daonguoc = 0;
			while (x > daonguoc)
			{
				daonguoc = daonguoc * 10 + x % 10;
				x /= 10;
			}
			return x == daonguoc || x == daonguoc / 10;
		}
    }
}
