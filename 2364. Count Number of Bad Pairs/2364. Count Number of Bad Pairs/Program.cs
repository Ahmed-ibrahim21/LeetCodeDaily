namespace _2364._Count_Number_of_Bad_Pairs
{
    public class Solution
    {
        public long CountBadPairs(int[] nums)
        {
            long length = nums.Length;
            long allPairs =  (length * (length - 1)) / 2;

            Dictionary<int,int> Dict = new Dictionary<int,int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int res = i - nums[i];
                if (Dict.ContainsKey(res))
                {
                    allPairs -= Dict[res];
                    Dict[res] += 1;
                }
                else
                {
                    Dict.Add(res, 1);
                }
            }
            return allPairs;
        }
    }

    public class Program
    {
        static void Main()
        {
            Solution s = new Solution();
            var result = s.CountBadPairs([4, 1, 3, 3]);
        }
    }
}
