using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int q = int.Parse(Console.ReadLine());
        for (int qi = 0; qi < q; qi++)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> x = new List<int>(n);
            List<int> y = new List<int>(n);
            for (int ni = 0; ni < n; ni++)
            {
                int[] tempArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                x.Add(tempArr[0]);
                y.Add(tempArr[1]);
            }

            if (n < 4)
            {
                Console.WriteLine("YES");
            }
            else
            {
                int xMax = x.Max();

                int yMax = y.Max();

                int xMin = x.Min();

                int yMin = y.Min();



                for (int i = 0; i < n; i++)
                {

                    if (
                        (x[i] != xMin && x[i] != xMax) &&
                        (y[i] != yMin && y[i] != yMax)
                        )
                    {
                        Console.WriteLine("NO");
                        break;
                    }


                    else if (
                        (x[i] < xMin || x[i] > xMax) ||
                        (y[i] < yMin || y[i] > yMax)
                        )
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                    else
                    {
                        if (i == n - 1) Console.WriteLine("YES");
                    }
                }
            }
        }
    }
}
