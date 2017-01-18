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
            GameofStones();
        }

        static void GameofStones()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 7 <= 1) Console.WriteLine("Second");
                else Console.WriteLine("First");
            }
        }

        static void SumvsXOR()
        {
            //Brute Force
            //long n = Convert.ToInt64(Console.ReadLine());
            //int qty = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    long x = i ^ n;
            //    if (i + n == x) qty++;
            //}

            //if (n == 0) Console.WriteLine(1);
            //Console.WriteLine(qty);

            //Correct
            long n = Convert.ToInt64(Console.ReadLine());
            string bitStr = Convert.ToString(n, 2);
            int qty = 0;
            for (int i = 0; i < bitStr.Length; i++)
            {
                if (bitStr[i] == '0') qty++;
            }

            if (n == 0) Console.WriteLine(1);
            else Console.WriteLine(Math.Pow(2, qty));

        }

        static void LuckBalance()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);

            int[] a = new int[n];
            int p = 0;
            int s = 0;
            int f = k;

            int loses = 0;

            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                int l = Convert.ToInt32(temp[0]);
                int t = Convert.ToInt32(temp[1]);

                if (t == 1)
                {
                    if (k > 0)
                    {
                        loses += l;
                        k--;
                        a[p] = l;
                        p++;
                    }
                    else
                    {
                        for (int j = 0; j < f; j++)
                        {
                            if (a[j] < l) { s = a[j]; a[j] = l; l = s; loses += a[j] - l; }
                        }
                        loses -= l;
                    }
                }
                else loses += l;

            }

            Console.WriteLine(loses);
        }

        static void HackerlandRadioTransmitters()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] x_temp = Console.ReadLine().Split(' ');
            int[] x = Array.ConvertAll(x_temp, Int32.Parse);

            Array.Sort(x);

            int f = x[0];
            int p = x[0];
            int qty = 0;
            for (int i = 1; i < n; i++)
            {
                if (f + k >= x[i]) p = x[i];
                else if (x[i] - p > k) { qty++; f = x[i]; p = f; }
            }

            qty++;
            Console.WriteLine(qty);

        }

        static void PalindromeIndex()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            string[] S = new string[T];
            for (int i = 0; i < T; i++)
            {
                S[i] = Console.ReadLine();
            }

            for (int i = 0; i < T; i++)
            {
                string n = S[i];
                int j = 0;
                bool p = true;
                bool t = false;
                int jt = -1; int mt = -1;
                int m = n.Length - 1;
                int index = -1;

                while (p && j < m)
                {
                    if (index == -1 && n[j] != n[m])
                    {
                        if (!t && n[j + 1] == n[m]) { index = j; jt = j; mt = m; j++; }
                        else if (n[j] == n[m - 1]) { index = m; jt = j; mt = m; m--; }
                        else p = false;
                    }
                    else if (n[j] != n[m])
                    {
                        if (!t) { j = jt; m = mt; t = true; index = -1; }
                        else p = false;
                    }
                    else
                    {
                        j++;
                        m--;
                    }
                }

                if (!p) Console.WriteLine("-1");
                else Console.WriteLine(index);
            }
        }

        static void BeautifulBinaryString()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string B = Console.ReadLine();

            int qty = 0;
            if (n > 1)
            {
                int i = 0;
                while (i < n - 2)
                {
                    if (B.Substring(i, 3) == "010") { qty++; i += 3; }
                    else i++;
                }
            }
            Console.WriteLine(qty);
        }

        static void StringConstruction()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string s = Console.ReadLine();
                string p = "";
                int qty = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (p.IndexOf(s[i]) == -1) { qty++; p += s[i]; }
                }
                Console.WriteLine(qty);
            }
        }

        static void MarsExploration()
        {
            string S = Console.ReadLine();
            int qty = 0;
            string m = "SOS";
            for (int i = 0; i < S.Length; i += 3)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (S[i + j] != m[j]) qty++;
                }
            }
            Console.WriteLine(qty);
        }

        static void TwoCharacters()
        {
            int len = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();

            bool repeat = true;
            Dictionary<char, int> c = new Dictionary<char, int>();
            char l = ' ';
            while (repeat)
            {
                repeat = false;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == l) { s = s.Replace(l.ToString(), ""); repeat = true; break; }
                    l = s[i];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!c.ContainsKey(s[i])) c.Add(s[i], 1);
                else c[s[i]]++;
            }

            Dictionary<char, bool> valid = new Dictionary<char, bool>();
            Dictionary<char, bool> equal = new Dictionary<char, bool>();
            int max = 0;

            foreach (var letter in c)
            {
                int qtyOcurr = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == letter.Key)
                    {
                        qtyOcurr++;
                        for (int m = 0; m < equal.Count; m++)
                        {
                            if (!equal.ElementAt(m).Value) { valid[equal.ElementAt(m).Key] = false; }
                            else if (equal.ElementAt(m).Value) equal[equal.ElementAt(m).Key] = false;
                        }
                    }
                    else
                    {
                        if (equal.ContainsKey(s[i]) && equal[s[i]]) valid[s[i]] = false;
                        else if (equal.ContainsKey(s[i]) && !equal[s[i]]) equal[s[i]] = true;
                        else if (!equal.ContainsKey(s[i]) && qtyOcurr < 2) { equal.Add(s[i], true); valid.Add(s[i], true); }
                    }
                }

                foreach (var item in valid)
                {
                    if (item.Value) max = Math.Max(max, letter.Value + c[item.Key]);
                }

                valid.Clear();
                equal.Clear();
            }

            Console.WriteLine(max);
        }

        static void CamelCase()
        {
            string s = Console.ReadLine();
            int j = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] <= 'Z') j++;
            }

            Console.WriteLine(j + 1);
        }

        static void SuperReducedString()
        {
            string input = Console.ReadLine();

            bool r = true;
            while (r)
            {
                int i = 0;
                string temp = "";
                r = false;
                while (i < input.Length)
                {
                    if (i + 1 < input.Length && input[i] == input[i + 1]) { i += 2; r = true; }
                    else { temp += input[i].ToString(); i += 1; }
                }

                input = temp;
                temp = "";
            }

            if (input.Length == 0) Console.WriteLine("Empty String");
            else Console.WriteLine(input);
        }

        static void StrangeCounter()
        {
            long t = Convert.ToInt64(Console.ReadLine());

            //double z = Math.Floor(Math.Log((t - 1) / 3 + 1, 2));
            //double z = Math.Floor(Math.Log((t - 1) / 3 + 1, 2));

            long n = Convert.ToInt64(Math.Ceiling(Math.Log(t / 3 + 1, 2)));
            long ret = 3 * 2 ^ n - t - 2;

            //long n = 3;
            //while (t > n)
            //{
            //    t -= n;
            //    n *= 2;
            //}

            //else { z = n - t + p; p = t + 1; }
            Console.WriteLine(ret);
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
