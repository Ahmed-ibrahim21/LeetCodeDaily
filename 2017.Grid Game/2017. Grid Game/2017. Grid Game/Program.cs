namespace _2017._Grid_Game
{
    public class Solution
    {
        public long GridGame(int[][] grid)
        {
            long minResult = long.MaxValue;
            long row1Sum = 0;

            // Calculate sum of top row
            foreach (var val in grid[0])
            {
                row1Sum += val;
            }

            long row2Sum = 0;

            for (int i = 0; i < grid[0].Length; ++i)
            {
                row1Sum -= grid[0][i];
                minResult = Math.Min(minResult, Math.Max(row1Sum, row2Sum));
                row2Sum += grid[1][i];
            }

            return minResult;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            long res = solution.GridGame([[2, 5, 4], [1, 5, 1]]);
        }
    }
}

