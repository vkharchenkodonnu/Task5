using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Task5
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] x = File.ReadAllLines("x.txt");
            string[] y = File.ReadAllLines("y.txt");
            int[] a = new int[x.Length];
            int[] b = new int[y.Length];
            for (int i = 0; i < x.Length; i++)
            {
                a[i] = Convert.ToInt32(x[i].ToString());
                    b[i] = Convert.ToInt32(y[i].ToString());
                    int[] z = new int[x.Length];
                    if(a[i] % 7 == 0) { a[i] += 8; }
                    z[i] = (a[i] * a[i] - b[i] * b[i]) / 2;
                    Console.WriteLine(z[i]);
                    
            }

           

        }
    }
}
