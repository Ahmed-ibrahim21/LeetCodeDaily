namespace _3066._Minimum_Operations_to_Exceed_Threshold_Value_II
{
    public class Solution
    {
        public int MinOperations(int[] nums, int k)
        {
            PriorityQueue<long,long> queue = new PriorityQueue<long,long>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < k)
                    queue.Enqueue(nums[i], nums[i]);
                else
                    continue;
            }
            int steps = 0;
            while (queue.Count > 0)
            {
                long res;
                if(queue.Count == 1)
                {
                    long st = queue.Dequeue();
                    res = st * 2 + st;
                }
                else
                {
                    res = (queue.Dequeue() * 2) + queue.Dequeue();
                }
                if(res < k)
                    queue.Enqueue(res, res);
                steps++;
            }
            return steps;
        }
    }

    public class Program
    {
        static void Main()
        {
            Solution s = new Solution();
            int x = s.MinOperations([999999999, 999999999, 999999999], 1000000000);
        }
    }
}
