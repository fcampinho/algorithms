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
            HappyLadybugs();
        }

        static void HappyLadybugs()
        {
            int Q = Convert.ToInt32(Console.ReadLine());
            string[] ret = new string[Q];
            for (int a0 = 0; a0 < Q; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string b = Console.ReadLine();
                
                Dictionary<char, int> color = new Dictionary<char, int>();
                bool perfect = true; char last = ' '; bool lastAdd = false;
                bool space = false;
                for (int i = 0; i < b.Length; i++)
                {
                    if (color.ContainsKey(b[i])) color[b[i]]++;
                    else if (b[i] != '_') color.Add(b[i], 1);

                    if (last != ' ' && perfect)
                    {
                        if (b[i] == last && perfect) lastAdd = true;
                        else if (lastAdd && perfect) lastAdd = false;
                        else perfect = false;
                    }

                    last = b[i];

                    if (b[i] == '_') space = true;
                }

                if ((space || perfect) && !color.ContainsValue(1)) ret[a0] = "YES";
                else ret[a0] = "NO";
            }

            for (int j = 0; j < Q; j++)
            {
                Console.WriteLine(ret[j]);
            }


        }

        static void FairRations()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            string[] B_temp = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(B_temp, Int32.Parse);

            bool ok = true;
            int qty = 0;
            for (int i = 0; i < N; i++)
            {
                if (B[i] % 2 != 0 && i < N - 1)
                {
                    B[i]++;
                    B[i + 1]++;
                    qty += 2;
                }
                else if (B[i] % 2 != 0 && i == N - 1)
                {
                    ok = false;
                }
            }

            if (ok) Console.WriteLine(qty);
            else Console.WriteLine("NO");
        }

        static void FlatlandSpaceStations()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);

            Array.Sort(A);

            int pos = A[0];
            int max = 0;

            if (pos != 0) max = pos;
            if (A[m - 1] != n - 1) max = Math.Max(max, n - 1 - A[m - 1]);

            for (int i = 1; i < m; i++)
            {
                int dist = (A[i] - pos) / 2;
                max = Math.Max(dist, max);
                pos = A[i];
            }

            Console.WriteLine(max);
        }

        static void MinimumDistances()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] A_temp = Console.ReadLine().Split(' ');
            int[] A = Array.ConvertAll(A_temp, Int32.Parse);

            Dictionary<int, int> dist = new Dictionary<int, int>();
            Dictionary<int, int> last = new Dictionary<int, int>();

            int min = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (last.ContainsKey(A[i])) { dist[A[i]] = Math.Min(dist[A[i]], i - last[A[i]]); min = Math.Min(min, dist[A[i]]); }
                else { last.Add(A[i], i); dist.Add(A[i], Int32.MaxValue); }
            }

            if (min == Int32.MaxValue) Console.WriteLine(-1);
            else Console.WriteLine(min);

        }

        static void BeautifulTriplets()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int qty = 0;
            for (int i = 0; i < n - 2; i++)
            {
                int b = 0;
                bool f = false;
                for (int j = i + 1; j < n; j++)
                {
                    if (c[j] - c[i] == k) { f = true; b = j; break; }
                }

                if (f)
                    for (int l = b + 1; l < n; l++)
                    {
                        if (c[l] - c[b] == k) { qty++; break; }
                    }
            }

            Console.WriteLine(qty);
        }

        static void EqualizetheArray()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (d.ContainsKey(c[i])) d[c[i]]++;
                else d.Add(c[i], 1);
            }

            int max = 0;
            int qty = 0;
            foreach (var item in d)
            {
                if (item.Value > max) { qty += max; max = item.Value; }
                else qty += item.Value;
            }

            Console.WriteLine(qty);
        }

        static void JumpingontheClouds()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int i = 0;
            int qty = 0;
            while (i < n - 1)
            {
                if (i + 2 < n - 1 && c[i + 2] == 1) i++;
                else i += 2;

                qty++;
            }

            Console.WriteLine(qty);
        }

        static void RepeatedString()
        {
            string w = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            long l = w.Length;
            long m = 0;

            for (int i = 0; i < l; i++)
            {
                if (w[i] == 'a') m++;
            }

            long f = 0;
            if (n > m) f = n / l * m;

            long x = n % l;
            if (x != 0)
            {
                for (int j = 0; j < x; j++)
                {
                    if (w[j] == 'a') f++;
                }
            }

            Console.WriteLine(f);

        }

        static void NonDivisibleSubset()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            Dictionary<int, int> m = new Dictionary<int, int>();
            bool ind = false;

            for (int i = 0; i < n; i++)
            {
                int r = c[i] % k;
                if (r == 0) ind = true;
                else if (m.ContainsKey(r)) m[r]++;
                else m.Add(r, 1);
            }

            int count = 0;
            //if (m.Count == 1) count = m.ElementAt(0).Value;
            //else
            for (int l = 0; l < m.Count; l++)
            {
                bool f = false;
                for (int p = l; p < m.Count; p++)
                {
                    if (l == p)
                    {
                        if (m.ElementAt(l).Value > 1 && (m.ElementAt(l).Key * 2) % k == 0)
                        {
                            m[m.ElementAt(p).Key] = 1;
                        }
                    }
                    else if (m.ElementAt(l).Key + m.ElementAt(p).Key == k)
                    {
                        count += Math.Max(m.ElementAt(l).Value, m.ElementAt(p).Value);
                        f = true;
                        m[m.ElementAt(p).Key] = 0;
                        break;
                    }

                }
                if (!f) count += m.ElementAt(l).Value;
            }

            if (ind) count++;

            Console.WriteLine(count);

        }

        static void AppendandDelete()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            int k = Convert.ToInt32(Console.ReadLine());

            bool equal = false;
            bool inc = false;
            for (int i = 0; i < k; i++)
            {
                if (!equal)
                {
                    if (s.Length > 0) s = s.Substring(0, s.Length - 1);
                    if (s.Length <= t.Length && s == t.Substring(0, s.Length)) equal = true;
                }
                else
                {
                    if (t.Length - s.Length == k - i) { inc = true; break; }
                    else if (t.Length - s.Length > k - i) break;
                    else if (s.Length > 0) s = s.Substring(0, s.Length - 1);
                }
            }

            if (inc) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }

        static void JumpingontheCloudsRevisited()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int i = 0;
            int e = 100;
            while (i < n)
            {
                i += k;
                e--;

                if (i > n - 1) { if (c[0] == 1) e -= 2; }
                else if (c[i] == 1) e -= 2;

            }

            Console.WriteLine(e);
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
