
namespace _2661First_Completely_Painted_Row_or_Column
{
    public class Solution
    {
        public bool UpdateAndCheckDictionary((int, int) coords, Dictionary<string, int> keyValuePairs, int m, int n)
        {
            int row = coords.Item1;
            int col = coords.Item2;

            if (keyValuePairs.ContainsKey($"{row}R"))
            {
                keyValuePairs[$"{row}R"]++;
                if (keyValuePairs[$"{row}R"] == n)
                {
                    return true;
                }
            }
            else
            {
                keyValuePairs.Add($"{row}R", 1);
            }

            if (keyValuePairs.ContainsKey($"{col}C"))
            {
                keyValuePairs[$"{col}C"]++;
                if (keyValuePairs[$"{col}C"] == m)
                {
                    return true;
                }
            }
            else
            {
                keyValuePairs.Add($"{col}C", 1);
            }

            return false;
        }

        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            if (m == 1 || n == 1)
            {
                return 0;
            }

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            Dictionary<int, (int, int)> Coordinations = new Dictionary<int, (int, int)>();

            for (int r = 0; r < m; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Coordinations[mat[r][c]] = (r, c);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var coords = Coordinations[arr[i]];
                bool check = UpdateAndCheckDictionary(coords, keyValuePairs, m, n);
                if (check)
                {
                    return i;
                }
            }

            return 0;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 4, 5, 2, 6, 3];
            int[][] mat = [[4, 3, 5], [1, 2, 6]];

            Solution solution = new Solution();

            int res = solution.FirstCompleteIndex(arr, mat);
        }

    }
}
