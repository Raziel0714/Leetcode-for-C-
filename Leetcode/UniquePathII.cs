using System;


namespace Leetcode
{

    public class UniquePathII
    {
        public int UniquePathsWithObstacles(int[,] obstacleGrid)
        {
            int m = obstacleGrid.GetLength(0);
            int n = obstacleGrid.Length / m;
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += obstacleGrid[i, j];
                }
            }
            if (m == 1 || n == 1)
            {
                if (sum == 0) return 1;
                else return 0;
            }
            if (obstacleGrid[0, 0] == 1) return 0;
            int[,] res = new int[m, n];
            res[0, 0] = 1;
            for (int i = 1; i < m; i++)
            {
                if (obstacleGrid[i, 0] == 0 && res[i - 1, 0] == 1)
                {
                    res[i, 0] = 1;
                }
                else
                {
                    res[i, 0] = 0;
                }
            }
            for (int i = 1; i < n; i++)
            {
                if (obstacleGrid[0, i] == 0 && res[0, i - 1] == 1)
                {
                    res[0, i] = 1;
                }
                else
                {
                    res[0, i] = 0;
                }
            }

            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (obstacleGrid[i, j] == 1)
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = res[i - 1, j] + res[i, j - 1];
                    }
                }
            }
            return res[m - 1, n - 1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
