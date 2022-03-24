namespace LeetCode
{
	public class Strings
	{
		/* First Unique Character in a String
	     * Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
	     */
		public int FirstUniqChar(string s)
		{
			Dictionary<char, int> list = new Dictionary<char, int>();

			foreach (char element in s)
			{
				if (list.ContainsKey(element))
				{
					list[element] = (list[element]) + 1;
				}
				else
				{
					list.Add(element, 1);
				}
			}

			for (int index = 0; index < s.Length; index++)
			{
				if (list[s[index]] == 1)
				{
					return index;
				}
			}

			return -1;
		}

		/* Reverse String
		 * Write a function that reverses a string. The input string is given as an array of characters s.
		 * You must do this by modifying the input array in-place with O(1) extra memory.
		 */
		public void ReverseString(char[] s)
		{
			int start = 0;
			int end = s.Length - 1;

			while (start < end)
			{
				char storage = s[start];
				s[start] = s[end];
				s[end] = storage;

				start++;
				end--;
			}
		}

		/* Valid Parentheses
		 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         * An input string is valid if:
         * Open brackets must be closed by the same type of brackets.
         * Open brackets must be closed in the correct order.
         */
		public bool IsValid(string s)
		{
			Stack<char> myStack = new Stack<char>();
			Dictionary<char, char> matcher = new Dictionary<char, char>();
			matcher.Add(')', '(');
			matcher.Add(']', '[');
			matcher.Add('}', '{');

			if (s.Length % 2 != 0)
			{
				return false;
			}

			for (int index = 0; index < s.Length; index++)
			{
				if (s[index] == '(' || s[index] == '{' || s[index] == '[')
				{
					myStack.Push(s[index]);
				}
				else
				{
					if (myStack.Count == 0)
					{
						return false;
					}

					if (matcher[s[index]] != myStack.Peek())
					{
						return false;
					}
					else
					{
						myStack.Pop();
					}
				}
			}

			return myStack.Count == 0;
		}
	}
}
