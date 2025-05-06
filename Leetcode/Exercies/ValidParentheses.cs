using System.Runtime.CompilerServices;

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

        private static bool isOpenBracket(char c)
        {
            return (c.Equals(LEFT_BRACE) || c.Equals(LEFT_PARENTHESIS) || c.Equals(LEFT_SQUAREBRACKET)) ? true : false;
        }

        static public bool IsValid(string s)
        {
            s = s.Trim();

            if (s.Trim().Length % 2 != 0) 
                return false;
            else
            {
                if (s[0].Equals(RIGHT_PARENTHESIS) || s[0].Equals(RIGHT_BRACE) || s[0].Equals(RIGHT_SQUAREBRACKET))
                    return false;
                else
                {
                    for (int i = 0; i < s.Length; )
                    {
                        if (i != s.Length - 1)
                        {
                            if (s[i + 1] == GetOtherChar(s[i])
                                && isOpenBracket(s[i]))
                            {
                                s = s.Remove(i, 2);
                                i = 0;
                            }
                            else
                            {
                                if (s.Length == 2)
                                    return false;

                                i++;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            return (s.Length != 0) ? false : true;
        }

        static public bool AnotherWay(string s)
        {
            Stack<char> charsSeen = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    charsSeen.Push(s[i]);
                }
                else
                {
                    if (charsSeen.Count == 0 ||
                        (s[i] == ')' && charsSeen.Peek() != '(') ||
                        (s[i] == ']' && charsSeen.Peek() != '[') ||
                        (s[i] == '}' && charsSeen.Peek() != '{'))
                    {
                        return false;
                    }
                    charsSeen.Pop();
                }
            }

            return charsSeen.Count == 0;
        }
    }
}
