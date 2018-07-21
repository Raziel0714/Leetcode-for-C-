using System;


namespace Leetcode
{

    public class SetMatrixZero
    {
        public void SetZeroes(int[,] matrix)
        {
            int m = matrix.GetLength(0);
            int n = matrix.Length / m;
            List<int> rows = new List<int>();
            List<int> cols = new List<int>();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        if (!rows.Contains(i)) rows.Add(i);
                        if (!cols.Contains(j)) cols.Add(j);
                    }
                }
            }

            for (int i = 0; i < rows.Count; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[rows[i], j] = 0;
                }
            }

            for (int i = 0; i < cols.Count; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[j, cols[i]] = 0;
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
