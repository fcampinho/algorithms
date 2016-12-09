using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class HackerHank3
    {
        static void Main(string[] args)
        {
            DivisibleSumPairs();
        }

        static void BonAppetit()
        {
            //Code in R
            //f < -file("stdin")
            //open(f)
            //data < -c()
            //while (length(line < -readLines(f, n = 1, warn = FALSE)) > 0)
            //            {
            //                data < -c(data, line)
            //}

            //            split_data < -strsplit(data, " ")
            //data < - as.numeric(unlist(split_data))

            //n < -data[1] + 2
            //k < -data[2] + 3
            //sumVector < -(sum(data[3:n]) - data[k]) / 2

            //result = data[n + 1]
            //text = "Bon Appetit"
            //if (sumVector != result)
            //            {
            //                write.table(result - sumVector, sep = "", append = T, row.names = F, col.names = F)
            //}
            //            else
            //            {
            //                cat(text, sep = "\n")
            //          }

        }

        static void DivisibleSumPairs()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int qty = 0;
            for (int i = 0; i < n -1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((a[i] + a[j]) % k == 0) qty++;
                }
            }

            Console.WriteLine(qty);
        }

        static void BetweenTwoSets()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);

            int min = a[a.Length - 1];
            int x = min; int qty = 0;
            int max = b[0];
            bool par = false;

            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] % 2 == 0) { par = true; break; }
            }

            while (x <= max)
            {
                bool factorA = true;
                bool factorB = true;

                for (int j = 0; j < a.Length; j++)
                {
                    if (x % a[j] != 0) { factorA = false; break; }
                }
                if (factorA)
                {
                    for (int i = 0; i < b.Length; i++)
                    {
                        if (b[i] % x != 0) { factorB = false; break; }
                    }
                }

                if (factorA && factorB) qty++;
                if (par) x += 2;
                else x++;
            }

            Console.WriteLine(qty);

        }

        static void AppleandOrange()
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int qtyM = 0; int qtyN = 0;
            for (var i = 0; i < m; i++)
            {
                if (apple[i] + a >= s && apple[i] + a <= t) qtyM++;
            }

            for (var i = 0; i < n; i++)
            {
                if (orange[i] + b >= s && orange[i] + b <= t) qtyN++;
            }

            Console.WriteLine(qtyM);
            Console.WriteLine(qtyN);
        }

        static void DesignerPDFViewer()
        {
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            string word = Console.ReadLine();

            int max = 0;
            foreach (char c in word)
            {
                int p = Convert.ToInt32(c);
                max = Math.Max(max, h[p - 97]);
            }

            Console.WriteLine(max * word.Length);
        }
    }
}
