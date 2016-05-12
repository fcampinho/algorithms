using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication2
{
    class HackerHank2
    {
        static int Swaps = 0;
        static int Shifts = 0;

        static void Main(string[] args)
        {
            LargestPermutation();
            //Pairs(new int[] { 1, 5, 3, 4, 2 }, 2);
        }

        static void ExtraLongFactorials()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger fat = 0;
            BigInteger sum = n;

            for (int i = n - 1; i > 1; i--)
            {

                fat = i;
                sum = sum * fat;
            }

            Console.WriteLine(sum);
        }

        static void MaxMin()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = (Convert.ToInt32(Console.ReadLine()));
            }

            Array.Sort(a);
            int minDiff = int.MaxValue;
            for (int j = 0; j < n - k + 1; j++)
            {
                minDiff = Math.Min(a[j + k - 1] - a[j], minDiff);
            }

            Console.WriteLine(minDiff);
        }

        static void BeautifulPairs()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] strA = Console.ReadLine().Split(' ');
            string[] strB = Console.ReadLine().Split(' ');

            Dictionary<int, int> ad = new Dictionary<int, int>();
            Dictionary<int, int> bd = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (ad.ContainsKey(Convert.ToInt32(strA[i]))) ad[Convert.ToInt32(strA[i])]++;
                else ad.Add(Convert.ToInt32(strA[i]), 1);

                if (bd.ContainsKey(Convert.ToInt32(strB[i]))) bd[Convert.ToInt32(strB[i])]++;
                else bd.Add(Convert.ToInt32(strB[i]), 1);
            }

            int qtyPair = 0;
            for (int j = 0; j < ad.Count; j++)
            {
                int key = ad.ElementAt(j).Key;
                if (bd.ContainsKey(key))
                {
                    if (bd[key] == ad[key])
                    {
                        qtyPair += ad[key];
                    }
                    else
                    {
                        qtyPair += Math.Min(ad[key], bd[key]);
                    }
                }
            }

            if (qtyPair == n) qtyPair -= 1;
            else qtyPair += 1;

            Console.WriteLine(qtyPair);
        }

        static Int32 Pairs(int[] a, int k)
        {
            Array.Sort(a);

            int i = 0;
            int j = i + 1;
            int qty = 0;
            while (j < a.Length)
            {
                if (a[j] - a[i] == k) { qty++; i++; j++; }
                else if (a[j] - a[i] > k) { i++; }
                else j++;
            }

            return qty;
        }

        static void TheTimeinWords()
        {
            int h = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, string> words = new Dictionary<int, string>();

            words.Add(1, "one");
            words.Add(2, "tow");
            words.Add(3, "three");
            words.Add(4, "four");
            words.Add(5, "five");
            words.Add(6, "six");
            words.Add(7, "seven");
            words.Add(8, "eight");
            words.Add(9, "nine");
            words.Add(10, "ten");
            words.Add(11, "eleven");
            words.Add(12, "twelve");
            words.Add(13, "thirteen");
            words.Add(14, "fourteen");
            words.Add(15, "quarter");
            words.Add(16, "sixteen");
            words.Add(17, "seventeen");
            words.Add(18, "eighteen");
            words.Add(19, "nineteen");
            words.Add(20, "twenty");
            words.Add(30, "half");

            string strHour = "";

            if (m == 0)
            {
                strHour = words[h] + " o' clock";
            }
            else if (m <= 30)
            {
                if (m > 20 && m != 30) strHour = words[20] + " " + words[m - 20] + " minutes";
                else if (m != 15 && m != 30) strHour = words[m] + " minutes";
                else strHour = words[m];

                strHour += " past ";
                strHour += words[h];
            }
            else
            {
                m = 60 - m;
                if (m > 20) strHour = words[20] + " " + words[m - 20] + " minutes";
                else if (m != 15) strHour = words[m] + " minutes";
                else strHour = words[m];

                strHour += " to ";
                strHour += words[h + 1];
            }

            Console.WriteLine(strHour);

        }

        static void AlgorithmicCrush()
        {

            string xy = Console.ReadLine();
            int x = Convert.ToInt32(xy.Split(' ')[0]);
            int y = Convert.ToInt32(xy.Split(' ')[1]);

            Int64[] l = new Int64[x];
            Int64 minJ = Int64.MaxValue;
            Int64 maxJ = Int64.MinValue;

            for (int i = 0; i < y; i++)
            {
                string abk = Console.ReadLine();
                Int64 a = Convert.ToInt64(abk.Split(' ')[0]);
                Int64 b = Convert.ToInt64(abk.Split(' ')[1]);
                Int64 k = Convert.ToInt64(abk.Split(' ')[2]);

                minJ = Math.Min(minJ, a);
                maxJ = Math.Max(maxJ, b);

                l[a - 1] += k;
                if (b < x) l[b] -= k;
            }

            Int64 acum = 0;
            Int64 MaxAcum = 0;
            for (Int64 i = minJ - 1; i < maxJ; i++)
            {
                acum += l[i];
                MaxAcum = Math.Max(acum, MaxAcum);
            }

            Console.WriteLine(MaxAcum);

        }

        static void CuttingBoards()
        {
            //Console.WriteLine(42 % (10 ^ 9 + 7));
            int p = 0;
            //string[] linesInput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\input.txt");
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = Convert.ToInt32(linesInput[p]); p++;

            for (int i = 0; i < t; i++)
            {
                string xy = Console.ReadLine();
                //string xy = linesInput[p]; p++;
                int x = Convert.ToInt32(xy.Split(' ')[1]);
                int y = Convert.ToInt32(xy.Split(' ')[0]);

                string[] cstrY = Console.ReadLine().Split(' ');
                //string[] cstrY = linesInput[p].Split(' '); p++;
                Int64[] cy = new Int64[y - 1];
                for (int j = 0; j < y - 1; j++)
                {
                    cy[j] = Convert.ToInt32(cstrY[j]);
                }

                string[] cstrX = Console.ReadLine().Split(' ');
                //string[] cstrX = linesInput[p].Split(' '); p++;
                Int64[] cx = new Int64[x - 1];
                for (int j = 0; j < x - 1; j++)
                {
                    cx[j] = Convert.ToInt32(cstrX[j]);
                }

                Array.Sort(cx);
                Array.Sort(cy);
                Array.Reverse(cx);
                Array.Reverse(cy);

                int xSeg = 1; int ySeg = 1;
                int m = 0; int n = 0;
                BigInteger module = (Int64)Math.Pow(10, 9) + 7;
                //Int64 cost = 0;
                BigInteger cost = new BigInteger(0);
                while (n < x - 1 || m < y - 1)
                {
                    if (n == x - 1)
                    {
                        cost += cy[m] * xSeg;
                        ySeg++;
                        m++;
                    }
                    else if (m == y - 1)
                    {
                        cost += cx[n] * ySeg;
                        xSeg++;
                        n++;

                    }
                    else if (cx[n] > cy[m])
                    {
                        cost += cx[n] * ySeg;
                        xSeg++;
                        n++;
                    }
                    else
                    {
                        cost += cy[m] * xSeg;
                        ySeg++;
                        m++;
                    }
                }

                Console.WriteLine(cost % module);
            }
        }

        static void SherlockandPairs()
        {
            string[] linesInput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\input02.txt");
            int p = 0;

            int t = Convert.ToInt32(linesInput[p]); p++;

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(linesInput[p]); p++; ;
                string[] a = linesInput[p].Split(' '); p++;

                Dictionary<int, Int64> d = new Dictionary<int, Int64>();
                for (int j = 0; j < n; j++)
                {
                    if (d.ContainsKey(Convert.ToInt32(a[j]))) d[Convert.ToInt32(a[j])]++;
                    else d.Add(Convert.ToInt32(a[j]), 1);
                }

                Int64 qty = 0;
                foreach (var item in d)
                {
                    if (item.Value > 1)
                        qty += item.Value * (item.Value - 1);
                }

                Console.WriteLine(qty);
            }
        }

        static void AlmostSorted()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            bool swap = false;
            int qtySwap = 0;
            bool reverse = false;
            bool breakReverse = false;
            bool reverseInvalid = false;
            int pSwapLeft = 0;
            int pSwapRight = 0;
            int pReverseLeft = 0;
            int pReverseRight = 0;

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N - 1; i++)
            {
                if (Convert.ToInt32(s[i]) > Convert.ToInt32(s[i + 1]))
                {
                    if (!swap) pSwapLeft = i;
                    swap = true;
                    pSwapRight = i + 1;
                    qtySwap++;

                    if (!reverse) pReverseLeft = i;
                    reverse = true;
                    pReverseRight = i + 1;

                    if (breakReverse) reverseInvalid = true;
                }
                else if (reverse)
                {
                    breakReverse = true;
                }
            }


            if (swap && qtySwap > 2) swap = false;
            else if (pSwapLeft > 0 && Convert.ToInt32(s[pSwapLeft - 1]) > Convert.ToInt32(s[pSwapRight])) swap = false;
            else if (Convert.ToInt32(s[pSwapLeft + 1]) < Convert.ToInt32(s[pSwapRight])) swap = false;
            else if (pSwapRight < N - 1 && Convert.ToInt32(s[pSwapRight + 1]) < Convert.ToInt32(s[pSwapLeft])) swap = false;
            else if (Convert.ToInt32(s[pSwapRight - 1]) > Convert.ToInt32(s[pSwapLeft])) swap = false;

            if (reverseInvalid) reverse = false;
            if (pReverseLeft > 0 && Convert.ToInt32(s[pReverseLeft - 1]) > Convert.ToInt32(s[pReverseRight])) reverse = false;
            if (pReverseRight < N - 1 && Convert.ToInt32(s[pReverseRight + 1]) < Convert.ToInt32(s[pReverseLeft])) reverse = false;

            if (swap)
            {
                Console.WriteLine("yes"); Console.WriteLine("swap " + (pSwapLeft + 1) + " " + (pSwapRight + 1));
            }
            else if (reverse)
            {
                Console.WriteLine("yes"); Console.WriteLine("reverse " + (pReverseLeft + 1) + " " + (pReverseRight + 1));
            }
            else if (!swap) Console.WriteLine("no");
        }

        static void GreedyFlorist()
        {
            int N, K;
            string NK = Console.ReadLine();
            string[] NandK = NK.Split(new Char[] { ' ', '\t', '\n' });
            N = Convert.ToInt32(NandK[0]);
            K = Convert.ToInt32(NandK[1]);

            int[] C = new int[N];

            string numbers = Console.ReadLine();
            string[] split = numbers.Split(new Char[] { ' ', '\t', '\n' });

            int i = 0;


            foreach (string s in split)
            {
                if (s.Trim() != "")
                {
                    C[i++] = Convert.ToInt32(s);
                }
            }

            int result = 0;

            Array.Sort(C);
            Array.Reverse(C);

            int mI = 0;
            int kI = 0;

            for (i = 0; i < N; i++)
            {
                result += (1 + mI) * C[i];
                kI++;
                if (kI == K) { mI++; kI = 0; }
            }

            Console.WriteLine(result);
        }

        static void LargestPermutation()
        {
            string nk = Console.ReadLine();
            //string nk = "1007 379";

            int n = Convert.ToInt32(nk.Split(' ')[0]);
            int k = Convert.ToInt32(nk.Split(' ')[1]);

            string[] sArr = Console.ReadLine().Split(' ');
            int[] arr = new int[n];

            int[] arrS = new int[n];
            Dictionary<int, int> pos = new Dictionary<int, int>();
            for (int m = 0; m < n; m++)
            {
                arr[m] = Convert.ToInt32(sArr[m]);
                pos.Add(arr[m], m);
            }
            arr.CopyTo(arrS, 0);
            Array.Sort(arrS);
            Array.Reverse(arrS);

            int p1 = 0; int p2 = 0;
            int val1 = 0; int val2 = 0;

            int limit = Math.Min(n, k);
            int i = 0;
            int j = 0;
            while (j < limit && i < n)
            {
                p1 = pos[arrS[i]];
                p2 = pos[arr[i]];

                if (p1 != p2)
                {
                    val1 = arrS[i];
                    val2 = arr[i];

                    arr[i] = val1;
                    arr[p1] = val2;

                    pos[val2] = p1;
                    j++;
                }

                i++;
            }

            Console.WriteLine(string.Join(" ", arr));
        }

        static void MaximizingXOR()
        {
            int L;
            L = Convert.ToInt32(Console.ReadLine());

            int R;
            R = Convert.ToInt32(Console.ReadLine());

            StringBuilder XOR;
            int Max = 0;
            for (int i = L; i <= R; i++)
            {
                string A = Convert.ToString(i, 2);
                for (int j = i; j <= R; j++)
                {
                    string B = Convert.ToString(j, 2);

                    if (A.Length > B.Length) B = new string('0', A.Length - B.Length) + B;
                    if (A.Length < B.Length) A = new string('0', B.Length - A.Length) + A;

                    XOR = new StringBuilder();
                    for (int m = 0; m < A.Length; m++)
                    {
                        bool AM = false; bool BM = false;
                        AM = (A[m] == '1' ? true : false);
                        BM = (B[m] == '1' ? true : false);

                        XOR.Append((AM ^ BM ? 1 : 0));
                    }

                    Max = Math.Max(Max, Convert.ToInt32(XOR.ToString(), 2));
                }
            }

            Console.WriteLine(Max);
        }

        static void PriyankaandToys()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            string nk = Console.ReadLine();
            string[] arr = nk.Split(' ');

            int[] toys = new int[t]; int i = 0;

            for (i = 0; i < t; i++)
            {
                toys[i] = Convert.ToInt32(arr[i]);
            }
            Array.Sort(toys);

            int qty = 0;

            i = 0;
            qty = 0;
            while (i < t)
            {
                for (int j = i + 1; j < t; j++)
                {
                    if (toys[j] > toys[i] + 4)
                    {
                        qty++; i = j; break;
                    }
                    else if (j + 1 == t) { i = t; qty++; }
                }
                if (i + 1 == t) { qty++; break; }
            }
            Console.WriteLine(qty);
        }

        static void Twoarrays()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n; int k;
                string nk = Console.ReadLine();
                n = Convert.ToInt32(nk.Split(' ')[0]);
                k = Convert.ToInt32(nk.Split(' ')[1]);

                int[] arrA = new int[n];
                string[] st = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    arrA[j] = Convert.ToInt32(st[j]);
                }

                int[] arrB = new int[n];
                st = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    arrB[j] = Convert.ToInt32(st[j]);
                }

                Array.Sort(arrA);
                Array.Sort(arrB);
                Array.Reverse(arrB);
                bool ok = true;

                for (int m = 0; m < n; m++)
                {
                    if (arrA[m] + arrB[m] < k) { ok = false; break; }
                }

                Console.WriteLine(ok ? "YES" : "NO");
            }
        }

        //Undone
        static void BearandSteadyGene()
        {
            int T;
            T = Convert.ToInt32(Console.ReadLine());
            Dictionary<char, int> G = new Dictionary<char, int>();
            string l = Console.ReadLine();
            for (int i = 0; i < T; i++)
            {
                if (G.ContainsKey(l[i])) { G[l[i]]++; }
                else G.Add(l[i], 1);
            }

            //            40
            //TGATGCCGTCCCCTCAACTTGAGTGCTCCTAATGCGTTGC
            //5


            bool a = false;
            bool c = false;
            bool t = false;
            bool g = false;

            char min = 'B'; char max = 'B';
            int vMin = int.MaxValue; int vMax = int.MinValue;
            int qty = 0;

            bool b = false;

            for (int j = 0; j < T; j++)
            {
                if (G.ContainsKey('A')) a = true;
                if (G.ContainsKey('C')) c = true;
                if (G.ContainsKey('G')) g = true;
                if (G.ContainsKey('T')) t = true;

                if (a)
                {
                    if (G['A'] > vMax) { vMax = G['A']; max = 'A'; }
                    if (G['A'] < vMin) { vMin = G['A']; min = 'A'; }
                }
                else { min = 'A'; vMin = 0; }

                if (c)
                {
                    if (G['C'] > vMax) { vMax = G['C']; max = 'C'; }
                    if (G['C'] < vMin) { vMin = G['C']; min = 'C'; }
                }
                else { min = 'C'; vMin = 0; }

                if (g)
                {
                    if (G['G'] > vMax) { vMax = G['G']; max = 'G'; }
                    if (G['G'] < vMin) { vMin = G['G']; min = 'G'; }
                }
                else { min = 'G'; vMin = 0; }

                if (t)
                {
                    if (G['T'] > vMax) { vMax = G['T']; max = 'T'; }
                    if (G['T'] < vMin) { vMin = G['T']; min = 'T'; }
                }
                else { min = 'T'; vMin = 0; }

                if (vMin != vMax)
                {
                    if (G[l[j]] > 1 && l[j] != min)
                    {
                        if (vMin == 0) G.Add(min, 1);
                        else G[min] += 1;

                        G[l[j]] -= 1;
                        b = true;

                        qty++;
                    }
                    else if (b) qty++;

                    vMin = int.MaxValue; vMax = int.MinValue;
                }
            }
            Console.WriteLine(qty);
        }

        static void LarrysArray()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n;
                n = Convert.ToInt32(Console.ReadLine());

                int[] arr = new int[n];
                string[] st = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    arr[j] = Convert.ToInt32(st[j]);
                }

                int p = 0; int minP = int.MaxValue; int temp = 0;
                bool impediment = false; bool change = false;
                while (p < n - 2)
                {
                    if (arr[p] < arr[p + 1] && arr[p] < arr[p + 2] && arr[p + 1] < arr[p + 2]) { change = true; }
                    else if (arr[p] > arr[p + 2] && arr[p] < arr[p + 1]) { temp = arr[p]; arr[p] = arr[p + 2]; arr[p + 2] = arr[p + 1]; arr[p + 1] = temp; change = true; } //rotaciona 2
                    else if (arr[p] > arr[p + 2] && arr[p + 1] > arr[p + 2]) { temp = arr[p]; arr[p] = arr[p + 2]; arr[p + 2] = arr[p + 1]; arr[p + 1] = temp; change = true; } //rotaciona 2
                    else if (arr[p] > arr[p + 2] && arr[p + 1] < arr[p + 2]) { temp = arr[p]; arr[p] = arr[p + 1]; arr[p + 1] = arr[p + 2]; arr[p + 2] = temp; change = true; } //rotaciona 1
                    else if (arr[p] > arr[p + 1]) { temp = arr[p]; arr[p] = arr[p + 1]; arr[p + 1] = arr[p + 2]; arr[p + 2] = temp; change = true; } //rotaciona 1
                    else if (arr[p] > arr[p + 1] && arr[p] > arr[p + 2]) { impediment = true; minP = Math.Min(minP, p); change = false; }

                    if (change && p > 1 && arr[p - 2] > arr[p]) { p -= 2; if (impediment && p <= minP) { impediment = false; minP = int.MaxValue; } }
                    else if (change && p > 0 && arr[p - 1] > arr[p]) { p--; if (impediment && p <= minP) { impediment = false; minP = int.MaxValue; } }
                    else p++;
                }

                if (arr[n - 2] > arr[n - 1]) { impediment = true; }

                if (impediment) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }

        static void LisasWorkbook()
        {
            string init = Console.ReadLine();
            int n;
            n = Convert.ToInt32(init.Split(' ')[0]);

            int k;
            k = Convert.ToInt32(init.Split(' ')[1]);

            string[] st = Console.ReadLine().Split(' ');
            int qtyAsk;

            int page = 1;
            int qtySpecial = 0;
            for (int chapter = 0; chapter < n; chapter++)
            {
                int minQuestion = 0; int maxQuestion = 0;
                qtyAsk = Convert.ToInt32(st[chapter]);
                int loop = (qtyAsk / k) + (qtyAsk % k == 0 ? 0 : 1);
                for (int i = 1; i <= loop; i++)
                {
                    minQuestion = maxQuestion + 1;
                    maxQuestion = minQuestion + Math.Min(qtyAsk, k) - 1;
                    qtyAsk -= k;
                    if (page >= minQuestion && page <= maxQuestion) qtySpecial++;

                    page++;
                }

            }

            Console.WriteLine(qtySpecial);

        }

        static void SherlockandMiniMax()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            string[] st = Console.ReadLine().Split(' ');
            int[] arr = new int[t];

            for (int i = 0; i < t; i++)
                arr[i] = Convert.ToInt32(st[i]);

            st = Console.ReadLine().Split(' ');
            int P = Convert.ToInt32(st[0]);
            int Q = Convert.ToInt32(st[1]);

            if (arr.Length == 1) { Console.WriteLine(P); return; }

            int minP = int.MaxValue;
            int minQ = int.MaxValue;
            for (int i = 0; i < t; i++)
            {
                minP = Math.Min(minP, Math.Abs(arr[i] - P));
                minQ = Math.Min(minQ, Math.Abs(arr[i] - Q));
            }

            Console.WriteLine(minP > minQ ? P : Q);
        }

        static void MarkandToys()
        {
            int N; int K;
            string[] start = Console.ReadLine().Split(' ');
            N = Convert.ToInt32(start[0]);
            K = Convert.ToInt32(start[1]);

            string[] stToys = Console.ReadLine().Split(' ');
            int[] toys = new int[N];

            for (int i = 0; i < N; i++)
                toys[i] = Convert.ToInt32(stToys[i]);

            Array.Sort(toys);
            int sumToys = 0; int qtyToys = 0;
            for (int j = 0; j < N; j++)
            {
                if (sumToys + toys[j] <= K) { sumToys += toys[j]; qtyToys++; }
                else break;
            }

            Console.WriteLine(qtyToys);
        }

        static void JimandtheOrders()
        {
            int t;
            t = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, string> orders = new Dictionary<int, string>();
            for (int j = 0; j < t; j++)
            {
                string order = Console.ReadLine();
                int time = Convert.ToInt32(order.Split(' ')[0]);
                int duration = Convert.ToInt32(order.Split(' ')[1]);

                int done = time + duration;
                if (orders.Keys.Contains(done)) orders[done] += " " + (j + 1).ToString();
                else orders.Add(done, (j + 1).ToString());
            }

            var final = orders.OrderBy(o => o.Key);
            foreach (var item in final)
            {
                Console.Write(item.Value + " ");
            }
        }

        static void GridChallenge()
        {
            //string[] linesInput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\input.txt");
            //string[] linesOutput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\output.txt");
            //int input = 0;

            int t = 4;
            t = Convert.ToInt32(Console.ReadLine());
            //t = Convert.ToInt32(linesInput[input++]);

            for (int j = 0; j < t; j++)
            {
                bool ok = true;
                int l = 4;
                l = Convert.ToInt32(Console.ReadLine());
                //l = Convert.ToInt32(linesInput[input++]);

                char[] matrixA = new char[l];
                char[] matrixB = new char[l];
                for (int i = 0; i < l; i++)
                {
                    string sentence = Console.ReadLine();
                    //string sentence = linesInput[input++];
                    if (ok)
                    {
                        for (int k = 0; k < l; k++)
                        {
                            matrixB[k] = sentence[k];
                        }

                        Array.Sort(matrixB);
                        if (i != 0)
                        {
                            for (int k = 0; k < l; k++)
                            {
                                if (matrixA[k] > matrixB[k]) { ok = false; break; }
                            }
                        }
                        Array.Copy(matrixB, matrixA, l);
                    }
                }

                if (ok) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }

        static void ConnectedCellinaGrid()
        {
            int m;
            m = Convert.ToInt32(Console.ReadLine());

            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int qty = 0;
            int qtyMax = 0;

            Stack<int[]> heap = new Stack<int[]>();

            string[][] matrix = new string[m][];
            for (int j = 0; j < m; j++)
            {
                string row = Console.ReadLine();
                matrix[j] = row.Split(' ');
            }

            int curX = 0; int curY = 0; int tCurX = 0; int tCurY = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    bool bChange = true; bool bReturn = false;
                    curX = j;
                    curY = i;
                    while (bChange)
                    {
                        bChange = false;
                        if (matrix[curX][curY] == "1" || bReturn)
                        {
                            qtyMax = Math.Max(1, qtyMax);
                            if (curY < n - 1 && matrix[curX][curY + 1] == "1") { bChange = true; tCurX = curX; tCurY = curY + 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Right
                            else if (curX < m - 1 && curY < n - 1 && matrix[curX + 1][curY + 1] == "1") { bChange = true; tCurX = curX + 1; tCurY = curY + 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Right-Down
                            else if (curX < m - 1 && matrix[curX + 1][curY] == "1") { bChange = true; tCurX = curX + 1; tCurY = curY; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Down
                            else if (curX < m - 1 && curY > 0 && matrix[curX + 1][curY - 1] == "1") { bChange = true; tCurX = curX + 1; tCurY = curY - 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Left-Down
                            else if (curY > 0 && matrix[curX][curY - 1] == "1") { bChange = true; tCurX = curX; tCurY = curY - 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Left
                            else if (curX > 0 && curY > 0 && matrix[curX - 1][curY - 1] == "1") { bChange = true; tCurX = curX - 1; tCurY = curY - 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Top-Left
                            else if (curX > 0 && matrix[curX - 1][curY] == "1") { bChange = true; tCurX = curX - 1; tCurY = curY; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Top
                            else if (curX > 0 && curY < n - 1 && matrix[curX - 1][curY + 1] == "1") { bChange = true; tCurX = curX - 1; tCurY = curY + 1; if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; } } //Top-Right

                            if (bChange) { heap.Push(new int[] { curX, curY }); curX = tCurX; curY = tCurY; bReturn = false; }
                            else if (heap.Count > 0)
                            {
                                if (matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; }
                                curX = heap.Peek()[0]; curY = heap.Peek()[1];
                                bChange = true;
                                if (bReturn) heap.Pop();
                                bReturn = true;
                            }
                            else
                            {
                                qty = 0;
                                bReturn = false;
                            }
                        }

                        qtyMax = Math.Max(qtyMax, qty);
                    }
                }
            }

            Console.WriteLine(qtyMax);
        }

        static void MissingNumbers()
        {
            int _a_size = 100000;
            //_a_size = Convert.ToInt32(Console.ReadLine());
            int[] _a = new int[_a_size];

            String sentence = Console.ReadLine();
            //String sentence = Console.ReadLine();
            String[] sentence_split = sentence.Split(' ');
            for (int _a_i = 0; _a_i < sentence_split.Length; _a_i++)
            {
                _a[_a_i] = Convert.ToInt32(sentence_split[_a_i]);
            }

            int _b_size = 100018;
            //_b_size = Convert.ToInt32(Console.ReadLine());
            int[] _b = new int[_b_size];

            //sentence = Console.ReadLine();
            sentence_split = sentence.Split(' ');
            for (int _b_i = 0; _b_i < sentence_split.Length; _b_i++)
            {
                _b[_b_i] = Convert.ToInt32(sentence_split[_b_i]);
            }

            Array.Sort(_a);
            Array.Sort(_b);

            //Console.WriteLine(string.Join(" ", _a));
            //Console.WriteLine(" ");
            //Console.WriteLine(string.Join(" ", _b));

            int i = 0;
            int j = 0;
            int lJ = 0;
            while (j < _b.Length)
            {
                if (i == _a_size)
                {
                    if (lJ != _b[j])
                    {
                        lJ = _b[j]; Console.Write(_b[j++].ToString() + ' ');
                    }
                    else j++;
                }
                else if (_a[i] == _b[j]) { i++; j++; }
                else if (lJ != _b[j]) { lJ = _b[j]; Console.Write(_b[j++].ToString() + ' '); }
                else j++;
            }
        }

        static int lonelyinteger(int[] a)
        {
            Dictionary<int, int> lonely = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (lonely.ContainsKey(a[i])) lonely[a[i]]++;
                else lonely.Add(a[i], 1);
            }

            int ret = lonely.First(v => v.Value == 1).Key;

            return ret;
        }

        static void LonelyInteger()
        {
            int res;

            //int _a_size = Convert.ToInt32(Console.ReadLine());
            int _a_size = 3;
            int[] _a = new int[_a_size];

            int _a_item;
            //String move = Console.ReadLine();
            string move = "1 1 2";
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }
            res = lonelyinteger(_a);
            Console.WriteLine(res);
        }

        static void IceCreamParlor()
        {
            int t = 1;
            //t = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < t; j++)
            {
                int m = 4;
                //m = Convert.ToInt32(Console.ReadLine());
                int n = 5;
                //n = Convert.ToInt32(Console.ReadLine());

                //String elements = Console.ReadLine();
                String elements = "1 4 5 3 2";
                String[] split_elements = elements.Split(' ');

                int[] values = new int[split_elements.Length];
                for (int i = 0; i < split_elements.Length; i++)
                {
                    values[i] = Convert.ToInt32(split_elements[i]);
                }

                bool sum = false;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int l = i + 1; l < n; l++)
                    {
                        if (values[i] + values[l] == m) { Console.WriteLine((i + 1).ToString() + ' ' + (l + 1).ToString()); sum = true; break; }
                    }
                    if (sum) break;
                }
            }
        }

        static void SherlockandArray()
        {
            int t = 1;
            //t = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < t; j++)
            {
                int _ar_size = 3;
                //_ar_size = Convert.ToInt32(Console.ReadLine());

                if (_ar_size == 1) { Console.WriteLine("YES"); continue; }
                else if (_ar_size == 2) { Console.WriteLine("NO"); continue; }

                int[] left = new int[_ar_size];
                int[] right = new int[_ar_size];
                int[] _ar = new int[_ar_size];

                int acumLeft = 0;
                int acumRight = 0;
                bool equal = false;

                //String elements = Console.ReadLine();
                String elements = "1 4 1";
                String[] split_elements = elements.Split(' ');

                for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
                {
                    acumLeft += Convert.ToInt32(split_elements[_ar_i]);
                    acumRight += Convert.ToInt32(split_elements[_ar_size - _ar_i - 1]);

                    _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
                    left[_ar_i] = acumLeft;
                    right[_ar_size - _ar_i - 1] = acumRight;
                }

                for (int m = 0; m < _ar_size - 2; m++)
                {
                    if (left[m] == right[m + 2]) { equal = true; break; }
                }

                Console.WriteLine(equal ? "YES" : "NO");
            }
        }

        static void SherlockandWatson()
        {
            //String elements = Console.ReadLine();
            //string elements = "51 51 100";
            //string elements = "72 74 500";
            string elements = "3 2 3";
            String[] split_init = elements.Split(' ');

            int n = Convert.ToInt32(split_init[0]);
            int k = Convert.ToInt32(split_init[1]);
            int q = Convert.ToInt32(split_init[2]);

            int[] _ar = new int[n];
            //elements = Console.ReadLine();
            //elements = "39356 87674 16667 54260 43958 70429 53682 6169 87496 66190 90286 4912 44792 65142 36183 43856 77633 38902 1407 88185 80399 72940 97555 23941 96271 49288 27021 32032 75662 69161 33581 15017 56835 66599 69277 17144 37027 39310 23312 24523 5499 13597 45786 66642 95090 98320 26849 72722 37221 28255 60906";
            //elements = "596 53804 13567 538 55791 75204 15873 98117 41061 49377 64425 62232 49127 20342 99276 24860 25787 81841 97359 7404 34400 37174 73359 257 88477 28020 25920 62652 3228 20401 99722 20175 74204 29640 20713 29994 4843 52937 28110 45903 18665 92535 24487 67791 29228 23762 9002 71367 21955 6360 78770 56354 59886 68480 72962 48362 96499 15233 11013 99726 35633 27086 36253 9836 73077 56965 39830 77919 26253 84291 40174 44918";
            elements = "1 2 3";
            String[] split_elements = elements.Split(' ');

            for (int _ar_i = 0; _ar_i < n; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            int vi = 0;
            int ni = 0;

            for (int i = 0; i < q; i++)
            {
                //ni = Convert.ToInt32(Console.ReadLine());
                ni = 0;
                vi = ni - k;
                if (vi < 0)
                {
                    int f = Math.Abs(vi);
                    if (Math.Abs(vi) > n) f = Math.Abs(vi) % (n);
                    vi = n - f;
                }
                Console.WriteLine(_ar[vi]);
            }
        }

        static void FindtheMedian()
        {
            int _ar_size = 10000;
            _ar_size = Convert.ToInt32(Console.ReadLine());

            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');

            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            Array.Sort(_ar);
            int median = _ar[_ar_size / 2];

            Console.WriteLine(median);
        }


        static void ClosestNumbers()
        {
            int _ar_size = 10000;
            _ar_size = Convert.ToInt32(Console.ReadLine());

            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');

            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            Array.Sort(_ar);
            int min; int max;
            long diff; long minDiff = long.MaxValue;
            StringBuilder output = new StringBuilder();

            for (int i = 1; i < _ar.Length; i++)
            {
                min = Math.Min(_ar[i], _ar[i - 1]);
                max = Math.Max(_ar[i], _ar[i - 1]);

                diff = max - min;
                if (diff < minDiff) { minDiff = diff; output.Clear(); output.Append(min.ToString() + " " + max.ToString() + " "); }
                else if (diff == minDiff) output.Append(min.ToString() + " " + max.ToString() + " ");
            }

            Console.WriteLine(output.ToString());
        }

        static void FibonacciModified()
        {
            BigInteger result = new BigInteger(0);
            BigInteger factor = new BigInteger(0);
            BigInteger lresult = new BigInteger(0);
            //String elements = Console.ReadLine();
            ////string elements = "-1 -2 -3 -4 -5 -6";
            //String[] split_elements = elements.Split(' ');
            //String[] split_elements = "0 1 10".Split(' ');
            //String[] split_elements = "0 1 5".Split(' ');
            String[] split_elements = "1 2 15".Split(' ');
            //3047256178414111539177892760416692371259184968596637101103470800691502127201206721753122686940948803915675049171249304581375612480754088028743832118763871935918417838829464707988489337429769611583833111684200745242063405701863222291780789306835766301890077485794933582184378775464518979959743359102141148662382408255253620650487176842801539394331458364031592213135740649454814982046786039395348848445769966417133647064866949189491066937591518907345678909773910972589196129055048855475649533694935951844856938244654313359320460469516821788324682888573791077411599764011075784920933641348884356966351475261443466247455025019252086769714642506572126969066430058968591788726159085446602156489564071886009742910372369813278342211511941722136648917170212494526671092030481544089862933890271924723192869393409558351184698970339087794416160184528405280293744029986132319011295653370647972229405001682588995176537774616262140795055979517433776085714177858363165843323310647101384809334561196539909577504309139685378761189410222798411087223651219470857113897310408007635740486554178410238800252689595412058577169081109645903635524928254805398891792386770002967761073090550132964823850304464672103776962806232852370670309853395949737558032824361632179843385017344627332557567731002041706039333732307635083529027623539116442611323503041818163841915716743038286645730504121278293170060104206224836400658420643625935112049246611294242162208426090364088712014313996176950078566752200488171301206916830452694729103357223040271875675033755316577427166495381432926909274573437248079947389551378543916721909213828454583046482282046806872083709575668506048054002975304955354985211211264938807844524101596601157573495696477148722207235612102934659343107414922094915268812831377465527333004052659892859694836384944379724097408146026356035228249320668078513571806700245892274455835401843269613304355466561546803871455042234590764926722326932158453231986433559197023954176644616281771591423693192241053854367228870530848941212609468718760569830719450762893381523382324852399752927920365145613699560339582193179698222969473637081673894366918745158691104745583816379116511264231523391848438332076385257639327634958086008038373519285878160494014466992569962128829312384544261638207409040319211973417558257011735804814613377174264573562857062938423786873232828164145801938398973526746417392152259802506928303787822148497632404993568719158027270554938121917888538265984785940893283376095126904076838746856868395360698781157946904241035371239813413865378011119242334202403280305971384874224669605501499639598361450708580267132920533725276595377131935555002062996762660135398133975271421949783689984695152216970215288517636587013754116660225980431165924802264920514814718497095839445008940209313926548607849148861770208385773492749322421938069218402860080627931640596164820210836911909853682716802111864419391202780728776127406888459561125012448297364986056922255269


            int a = Convert.ToInt32(split_elements[0]);
            int b = Convert.ToInt32(split_elements[1]);
            int n = Convert.ToInt32(split_elements[2]);

            result = Convert.ToInt64(Math.Pow(b, 2)) + a;
            lresult = b;

            for (int i = 4; i <= n; i++)
            {
                factor = lresult;
                lresult = result;
                result = result * result + factor;
            }

            Console.WriteLine(result);

        }

        static void TheMaximumSubarray()
        {
            int _ar_case = 1;
            _ar_case = Convert.ToInt32(Console.ReadLine());
            for (int ar_j = 0; ar_j < _ar_case; ar_j++)
            {
                int _ar_size = 1;
                _ar_size = Convert.ToInt32(Console.ReadLine());
                int _ar = 0;
                int MaxC = int.MinValue;
                long MaxI = int.MinValue;
                int TempMax = 0;

                String elements = Console.ReadLine();
                //string elements = "-1 -2 -3 -4 -5 -6";
                String[] split_elements = elements.Split(' ');

                for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
                {
                    _ar = Convert.ToInt32(split_elements[_ar_i]);

                    MaxI = Math.Max(MaxI, Math.Max(_ar, MaxI + _ar));

                    TempMax += _ar;
                    MaxC = Math.Max(MaxC, TempMax);

                    if (TempMax < 0) TempMax = 0;
                }

                Console.WriteLine(MaxC.ToString() + " " + MaxI.ToString());
            }
        }

        static void TheFullCountingSort()
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            string[] word = new string[_ar_size];

            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                String elements = Console.ReadLine();
                String[] split_elements = elements.Split(' ');
                _ar[_ar_i] = Convert.ToInt32(split_elements[0]);
                word[_ar_i] = split_elements[1];
            }

            StringBuilder[] sentence = new StringBuilder[_ar_size];

            for (int i = 0; i < _ar_size; i++)
            {
                if (sentence[_ar[i]] == null) sentence[_ar[i]] = new StringBuilder();
                if (i < _ar_size / 2) sentence[_ar[i]].Append("- ");
                else sentence[_ar[i]].Append(word[i] + " ");
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                //if (i >= _ar_size) break;
                if (sentence[i] != null) Console.Write(sentence[i].ToString());
            }
        }

        static void CountingSort3()
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];

            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                String elements = Console.ReadLine();
                String[] split_elements = elements.Split(' ');
                _ar[_ar_i] = Convert.ToInt32(split_elements[0]);
            }

            int[] count = new int[_ar_size];
            for (int i = 0; i < _ar_size; i++)
            {
                count[_ar[i]]++;
            }

            int valAcum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i < _ar_size) Console.Write(valAcum += count[i]);
                else Console.Write(valAcum);

                Console.Write(" ");
            }
        }

        static void CountingSort2()
        {
            int _ar_size = 7;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            //string elements
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            quicksort(ref _ar, 0, _ar.Length - 1);

            Console.Write(string.Join(" ", _ar));
        }

        static void quicksort(ref int[] A, int lo, int hi)







        {
            if (lo < hi)
            {
                int p = partition(ref A, lo, hi);
                quicksort(ref A, lo, p - 1);
                quicksort(ref A, p + 1, hi);
            }
        }

        static int partition(ref int[] A, int lo, int hi)
        {
            int pivot = A[hi];
            int i = lo;        // place for swapping
            int temp;
            for (int j = lo; j < hi; j++)
            {
                if (A[j] <= pivot)
                {
                    temp = A[i]; A[i] = A[j]; A[j] = temp;
                    i++;
                }
            }
            temp = A[i]; A[i] = A[hi]; A[hi] = temp;
            return i;
        }

        static void insertionSort3(int[] A)
        {
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;

                    Shifts++;
                }
                A[j + 1] = value;
            }
        }
    }
}