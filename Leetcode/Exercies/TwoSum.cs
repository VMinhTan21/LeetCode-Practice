
namespace Leetcode.Exercies
{
    public static class TwoSum
    {
		public static int[] Execute(int[] nums, int target)
		{
			for (int xIndex = 0; xIndex < nums.Length; xIndex++)
			{
				for (int yIndex = xIndex + 1; yIndex < nums.Length; yIndex++)
				{
					if ((nums[xIndex] + nums[yIndex]) == target)
					{
						return [xIndex, yIndex];
					}
				}
			}

			return [0, 0];
		}

		public static int[] BetterWay(int[] nums, int target)
		{
			HashSet<int> set = new HashSet<int>();

			for (int i = 0; i < nums.Length; i++)
			{
				int complement = target - nums[i];

				if (set.Contains(complement))
				{
					for (int j = 0; j < i; j++)
					{
						if (nums[j] == complement)
						{
							return [ j, i ];
						}
					}
				}

				set.Add(nums[i]);
			}

			return set.ToArray();
		}

		public static int[] BestWay(int[] nums, int target)
		{
			for (int i = 0; i <= nums.Length - 1; i++)
			{
				for (int j = 1 + i; j <= nums.Length - 1; j++)
				{
					if (nums[i] + nums[j] == target)
					{
						return [i, j];
					}
					else if (nums[j] + nums[j - 1] == target)
					{
						return [j, j - 1];
					}
				}
			}
			return [];
		}
	}
}
