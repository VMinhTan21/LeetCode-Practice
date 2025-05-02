namespace Leetcode.Exercies
{
    static class ValidParentheses
    {
        private const char LEFT_PARENTHESIS = '(';
        private const char RIGHT_PARENTHESIS = ')';
        private const char LEFT_BRACE = '{';
        private const char RIGHT_BRACE = '}';
        private const char LEFT_SQUAREBRACKET = '[';
        private const char RIGHT_SQUAREBRACKET = ']';

        static private char GetOtherChar(char c)
        {
            switch (c)
            {
                case LEFT_PARENTHESIS:
                    return RIGHT_PARENTHESIS;
                case RIGHT_PARENTHESIS:
                    return LEFT_PARENTHESIS;
                case LEFT_BRACE:
                    return RIGHT_BRACE;
                case RIGHT_BRACE:
                    return LEFT_BRACE;
                case LEFT_SQUAREBRACKET:
                    return RIGHT_SQUAREBRACKET;
                default:
                    return LEFT_SQUAREBRACKET;
            }
        }

        static private bool IsOpenBracket(char c)
        {
            return (c.Equals(LEFT_PARENTHESIS) || c.Equals(LEFT_BRACE) || c.Equals(LEFT_SQUAREBRACKET)) ? true : false;
        }

        static private bool IsCloseBracket(char c)
        {
            return (c.Equals(RIGHT_PARENTHESIS) || c.Equals(RIGHT_BRACE) || c.Equals(RIGHT_SQUAREBRACKET)) ? true : false;
        }

        static public bool IsValid(string s)
        {
            bool isValid = false;

            if (s.Trim().Length % 2 != 0) 
                return false;
            else
            {
                if (s[0].Equals(RIGHT_PARENTHESIS) || s[0].Equals(RIGHT_BRACE) || s[0].Equals(RIGHT_SQUAREBRACKET))
                    return false;
                else
                {
                    for (int i = 0; i < s.Length; i += 2)
                    {
                        for (int j = i + 1; j < s.Length; j += 2)
                        {
                            if (s[j].Equals(GetOtherChar(s[i])) 
                                && (IsOpenBracket(s[i]))
                                && (IsCloseBracket(s[j])))
                                isValid = true;
                        }
                    }
                }
            }

            return isValid;
        }
    }
}
