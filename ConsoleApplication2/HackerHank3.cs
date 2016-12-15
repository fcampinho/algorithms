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
            SavethePrisoner();
        }

        static void SavethePrisoner()
        {
            int p = 0;
            int T = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < T; j++)
            {
                string[] v = Console.ReadLine().Split(' ');
                int N = Convert.ToInt32(v[0]);
                int M = Convert.ToInt32(v[1]);
                int S = Convert.ToInt32(v[2]) - 1;
                int r = 0;

                M = M + S;
                if (M > N) r = M % N;
                else r = S + M;

                if (r == 0) r = N;

                Console.WriteLine(r);
            }

        }

        static void ViralAdvertising()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = 0; int k = 5; int nk = 0;
            for (int i = 0; i < n; i++)
            {
                nk = k / 2;
                p += nk;

                k = nk * 3;
            }

            Console.WriteLine(p);
        }

        static void BeautifulDaysattheMovies()
        {
            string s = Console.ReadLine();
            string[] sa = s.Split(' ');
            long i = Convert.ToInt64(sa[0]);
            long j = Convert.ToInt64(sa[1]);
            long k = Convert.ToInt64(sa[2]);

            long n = 0;

            for (long a = i; a <= j; a++)
            {
                long b = Convert.ToInt64(Reverse(a.ToString()));
                if ((b - a) % k == 0)
                {
                    n = n + 1;
                }
            }
            Console.WriteLine(n);
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void SockMerchant()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            Dictionary<int, int> q = new Dictionary<int, int>();
            int qty = 0;
            for (int i = 0; i < n; i++)
            {
                if (!q.ContainsKey(c[i])) q.Add(c[i], 1);
                else { q[c[i]]++; if (q[c[i]] % 2 == 0) qty++; }
            }

            Console.WriteLine(qty);
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
            for (int i = 0; i < n - 1; i++)
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
