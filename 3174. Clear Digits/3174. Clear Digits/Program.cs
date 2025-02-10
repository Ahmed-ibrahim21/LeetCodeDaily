namespace _3174._Clear_Digits
{
    public class Solution
    {
        public string ClearDigits(string s)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0;i < s.Length; i++)
            {
                if (s[i] <= '9' && s[i] >= '0')
                {
                    if (stack.Count == 0)
                        continue;
                    else
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            if(stack.Count == 0)
            {
                return "";
            }
            string res = new string(stack.Reverse().ToArray());
            return res;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            var res = solution.ClearDigits("cb34as");
            Console.WriteLine(res);
        }
    }
}
