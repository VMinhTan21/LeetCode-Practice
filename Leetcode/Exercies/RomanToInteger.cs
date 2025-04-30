namespace Leetcode.Exercies
{
    public static class RomanToInteger
    {
        public static Dictionary<string, int> RomanValue = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
			{ "L", 50 },
			{ "C", 100 },
			{ "D", 500 },
			{ "M", 1000 },
			{ "IV", 4 },
			{ "IX", 9 },
			{ "XL", 40 },
			{ "XC", 90 },
			{ "CD", 400 },
			{ "CM", 900 },
		};

		public static int MyWay(string romanInput)
		{
			int result = 0;

			for (int i = romanInput.Length - 1; i >= 0; i--)
			{
				if (i == 0)
				{
					result += RomanValue[romanInput[i].ToString()];
				}
				else
				{
					switch (romanInput[i])
					{
						case 'V':
							if (romanInput[i - 1] == 'I')
							{
								result += RomanValue["IV"];
								i--;

								break;
							}
							goto default;

						case 'X':
							if (romanInput[i - 1] == 'I')
							{
								result += RomanValue["IX"];
								i--;

								break;
							}
							goto default;

						case 'L':
							if (romanInput[i - 1] == 'X')
							{
								result += RomanValue["XL"];
								i--;

								break;
							}
							goto default;

						case 'C':
							if (romanInput[i - 1] == 'X')
							{
								result += RomanValue["XC"];
								i--;

								break;
							}
							goto default;

						case 'D':
							if (romanInput[i - 1] == 'C')
							{
								result += RomanValue["CD"];
								i--;

								break;
							}
							goto default;

						case 'M':
							if (romanInput[i - 1] == 'C')
							{
								result += RomanValue["CM"];
								i--;

								break;
							}
							goto default;

						default:
							result += RomanValue[romanInput[i].ToString()];
							break;
					}
				}
			}

			return result;
		}
    }
}
