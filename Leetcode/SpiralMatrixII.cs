using System;


namespace Leetcode
{

    public class SpiralMatrixII
    {
        public int[,] GenerateMatrix(int n)
        {
            int u = 0, r = n - 1, d = n - 1, l = 0, i = 1;
            int[,] res = new int[n, n];
            while (true)
            {
                //up
                for (int col = l; col <= r; col++) res[u, col] = i++;
                if (u++ > d) break;
                //right
                for (int row = u; row <= d; row++) res[row, r] = i++;
                if (r-- < l) break;
                //down
                for (int col = r; col >= l; col--) res[d, col] = i++;
                if (d-- < u) break;
                //left
                for (int row = d; row >= u; row--) res[row, l] = i++;
                if (l++ > r) break;
            }
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
