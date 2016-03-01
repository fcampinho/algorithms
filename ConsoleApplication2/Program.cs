using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //(5, [5, 5, 1, 7, 2, 3, 5])
            Test1(5, new int[] { 5, 5, 1, 7, 2, 3, 5 });
            //Test1(5, new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            //Test1(5, new int[] { 1, -2, -1, 2, 500 });
            //Test2(new int[] { 1, 1, 0, 1 });
            //Test2(new int[] { 1, 0, 0, 1, 1 });
            //Test2(new int[] { 1, 0, 0, 1, 1, 1 });
            //Test2(new int[] { 1, 1, 0, 1, 0, 1, 1 });
            //Test2(new int[] { 1, -2, -1, 2, 500 });
            //Test3(new int[] { 4, 3, 4, 4, 4, 2 });
            //Test3(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            //Test3(new int[] { 1, -2, -1, 2, 500 });

            //Flags(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 });
            //MinPerimeterRectangle(30);
            //CountFactors(24);
            //MaxProfit(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 });
            //MaxSliceSum(new int[] { 3, 2, -6, 4, 0 });
            //MaxDoubleSliceSum(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 });
            //Leader(new int[] { 4, 3, 4, 4, 4, 2 });
            //Dominator(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            //Equilibrium(new int[] { -1, 3, -4, 5, 1, -6, 2, 1 });
            //Equilibrium(new int[] { 1, -2, -1, 2, 500 });
            //TapeEquilibrium(new int[] { 1000, -1000, 1500, 4000 });

            //Fish(new int[] { 1, -2, -1, 2, 500 }, new int[] { 1, -2, -1, 2, 500 });
            //NumberOfDiscIntersections(new int[] { 1, 5, 2, 1, 4, 0 });
            //MaxProductOfThree(new int[] { -3, 1, 2, -2, 5, 6 });
            //Brackets("{[()()]}");
            //StoneWall(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 });
            //GenomicRangeQuery("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });
            //CountDiv(6, 11, 2);
            //MaxCounters(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            //PermMissingElem(new int[] { });
            //PermMissingElem(new int[] { 2 });
            //PermMissingElem(new int[] { 2, 3, 1, 5 });
            //TapeEquilibrium(new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4 });
            //Console.Write(solution(15));

        }

        private static int Test1(int X, int[] A)
        {
            int qtyTrueX = 0;
            int qtyFalseX = 0;

            int[] arrT = new int[A.Length];
            int[] arrF = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == X)
                {
                    qtyTrueX++;
                }
                else
                {
                    qtyFalseX++;
                }
                arrT[i] = qtyTrueX;
                arrF[i] = qtyFalseX;
            }

            qtyFalseX += 1;
            for (int i = 0; i < A.Length; i++)
            {
                if (arrT[i] == qtyFalseX - arrF[i]) return i;
            }

            return 0;
        }

        private static int[] Test2(int[] A)
        {
            //StringBuilder sb = new StringBuilder();
            int X = 0;
            byte[] ba = new byte[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                X += A[i] * Convert.ToInt32(Math.Pow(-2, i));
            }

            X *= -1;

            int sum = 0;
            int MaxFor = X > 0 ? A.Length : A.Length - 1;
            int[] arrF = new int[MaxFor];
            sum = 0;

            if (X % 2 != 0) { arrF[0] = 1; sum = 1; } else arrF[0] = 0;

            for (int j = 1; j < MaxFor; j++)
            {
                if (j % 2 != 0)
                {
                    sum += Convert.ToInt32(Math.Pow(-2, j));
                    arrF[j] = 1;
                    if (Math.Abs(sum) >= Math.Abs(X)) break;
                }
                else arrF[j] = 0;
            }

            return arrF;
        }

        private static int Test3(int[] A)
        {


            return 0;
        }

        private static int Flags(int[] A)
        {
            HashSet<int> flags = new HashSet<int>();
            for (int i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i] > A[i + 1])
                {
                    flags.Add(i);
                }
            }

            int N = A.Length;
            for (int qtyFlags = 1; qtyFlags <= N; qtyFlags++)
            {
                if (N % qtyFlags != 0) continue;

                int find = 0;
                int groups = N / qtyFlags;
                bool ok = true;

                foreach (int j in flags)
                {
                    if (j / qtyFlags > find)
                    {
                        ok = false;
                        break;
                    }
                    if (j / qtyFlags == find) find++;
                }
                if (find != groups) ok = false;
                if (ok) return groups;

            }

            return 0;
        }

        public static int CountFactors(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int i = 1;
            int result = 0;

            while (i < Math.Sqrt(N))
            {
                if (N % i == 0)
                {
                    result += 2;
                }
                i++;
            }
            if (Math.Pow(i, 2) == N)
            {
                result += 1;
            }
            return result;

            //int factors = 0;
            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0) factors++;
            //}

            //return factors;
        }

        public static int MinPerimeterRectangle(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int minPer = Int32.MaxValue;

            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    minPer = Math.Min(minPer, 2 * (N / i + i));
                }
            }



            return minPer;
        }

        public static int MaxSliceSum(int[] A)
        {
            int Max = A[0]; int Acum = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                Acum = Math.Max(A[i], Acum + A[i]);
                Max = Math.Max(Max, Acum);
            }

            return Max;
        }

        public static int MaxProfit(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0 || A.Length == 1) return 0;

            int maxSoFar = 0;
            int maxEndingHere = 0;
            int minPrice = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                maxEndingHere = Math.Max(0, A[i] - minPrice);
                minPrice = Math.Min(minPrice, A[i]);
                maxSoFar = Math.Max(maxEndingHere, maxSoFar);
            }

            return maxSoFar;
        }

        public static int MaxDoubleSliceSum(int[] A)
        {

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            int[] K1 = new int[N];
            int[] K2 = new int[N];

            for (int i = 1; i < N - 1; i++)
            {
                K1[i] = Math.Max(K1[i - 1] + A[i], 0);
            }
            for (int i = N - 2; i > 0; i--)
            {
                K2[i] = Math.Max(K2[i + 1] + A[i], 0);
            }
            //{ 3, 2, 6, -1, 4, 5, -1, 2 }
            int max = 0;

            for (int i = 1; i < N - 1; i++)
            {
                max = Math.Max(max, K1[i - 1] + K2[i + 1]);
            }

            return max;

        }




        public static int Equilibrium(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int sum1 = 0; int sum2 = 0;
            sum1 = 0;
            //if (A.Length <= 2) return -1;

            for (int i = 1; i < A.Length; i++)
            {
                sum2 += A[i];
            }

            if (sum1 == sum2) return 0;

            for (int j = 1; j <= A.Length; j++)
            {
                sum1 += A[j - 1];
                //sum2 -= A[j - 2];
                sum2 -= A[j];

                if (sum1 == sum2) return j;
            }

            return -1;

        }

        public static int EquiLeader(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0) return 0;
            int half = A.Length / 2;

            Dictionary<int, int> dominator = new Dictionary<int, int>();

            int pMax = 0; int vMax = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (dominator.ContainsKey(A[i]))
                {
                    dominator[A[i]] += 1;
                }
                else
                {
                    dominator.Add(A[i], 1);
                }

                if (vMax < dominator[A[i]])
                {
                    pMax = i;
                    vMax = dominator[A[i]];
                }
            }

            if (vMax <= half) return 0;

            int leader = A[pMax];
            int equiLeaders = 0;
            int leaders = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == leader) leaders++;
                int leadersInRightPart = (vMax - leaders);
                if (leaders > (i + 1) / 2 && leadersInRightPart > (A.Length - 1 - i) / 2) equiLeaders++;
            }

            return equiLeaders;
        }

        public static int Dominator(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0) return -1;
            int half = A.Length / 2;

            Dictionary<int, int> dominator = new Dictionary<int, int>();

            int pMax = 0; int vMax = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (dominator.ContainsKey(A[i]))
                {
                    dominator[A[i]] += 1;
                }
                else
                {
                    dominator.Add(A[i], 1);
                }

                if (vMax < dominator[A[i]])
                {
                    pMax = i;
                    vMax = dominator[A[i]];
                }

                if (vMax > half) break;
            }

            if (vMax <= half) pMax = -1;

            return pMax;
        }

        public static int Nesting(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int qtyNest = 0;
            if (String.IsNullOrEmpty(S)) return 1;

            foreach (char c in S)
            {
                if (c == Convert.ToChar("(")) qtyNest++;
                else qtyNest--;
                if (qtyNest < 0) return 0;//CORRECTING ABOVE ERROR!
            }
            if (qtyNest == 0 && S[0] == '(' && S[S.Length - 1] == ')') return 1;
            else return 0;
        }

        public static int StoneWall(int[] H)
        {
            Stack<int> st = new Stack<int>();
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int lastSize = 0; int qtyBlocks = 0;
            lastSize = H[0];

            foreach (int b in H)
            {
                if (st.Count == 0)
                {
                    st.Push(b);
                    qtyBlocks++;
                    lastSize = b;
                }
                //8, 8, 5, 7, 9, 8, 7, 4, 8
                lastSize = Convert.ToInt32(st.Peek());
                while (lastSize > b && st.Count > 0)
                {
                    lastSize = Convert.ToInt32(st.Peek());
                    if (lastSize > b) st.Pop();
                }
                if (b != lastSize)
                {
                    qtyBlocks++;
                    st.Push(b);
                }

            }

            return qtyBlocks;
        }

        public static int Fish(int[] A, int[] B)
        {
            Stack aliveFishes = new Stack();
            for (int i = 0; i < A.Length; i++)
            {
                if (aliveFishes.Count == 0)
                {
                    aliveFishes.Push(i);
                }
                else
                {
                    while (aliveFishes.Count != 0
                             && B[i] - B[Convert.ToInt32(aliveFishes.Peek())] == -1
                             && A[Convert.ToInt32(aliveFishes.Peek())] < A[i])
                    { aliveFishes.Pop(); }

                    if (aliveFishes.Count != 0)
                    { if (B[i] - B[Convert.ToInt32(aliveFishes.Peek())] != -1) aliveFishes.Push(i); }

                    else { aliveFishes.Push(i); }
                }
            }
            return aliveFishes.Count;
        }

        public static int Brackets(string S)
        {
            if (String.IsNullOrEmpty(S)) return 1;
            Stack<char> stack = new Stack<char>();

            if (S[0] == ')' || S[0] == ']' || S[0] == '}') return 0;

            stack.Push(S[0]);

            for (int i = 1; i < S.Length; i++)
            {
                if (S[i] == ')' || S[i] == ']' || S[i] == '}')
                {
                    if (stack.Count == 0) return 0;
                    if (S[i] == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else if (S[i] == ')')
                    {
                        return 0;
                    }
                    if (S[i] == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                    }
                    else if (S[i] == ']')
                    {
                        return 0;
                    }
                    if (S[i] == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                    }
                    else if (S[i] == '}')
                    {
                        return 0;
                    }
                }
                else stack.Push(S[i]);

            }

            if (stack.Count != 0) return 0;
            return 1;
        }


        public static int NumberOfDiscIntersections(int[] A)
        {
            int N = A.Length;
            long[] AX = new long[N];
            long[] AY = new long[N];

            for (int i = 0; i < N; i++)
            {
                AX[Math.Max(0, i - A[i])]++;
                AY[Math.Min(N - 1, i + A[i])]++;
            }
            long result = 0;
            long discsAtIndex = 0;
            for (int i = 0; i < N; i++)
            {
                if (AX[i] > 0)
                {
                    result += discsAtIndex * AX[i] + (AX[i] * (AX[i] - 1) / 2);

                    discsAtIndex += AX[i];
                }
                discsAtIndex -= AY[i];
            }
            if (result <= 10000000)
                return (int)result;
            else return -1;
        }

        //        int intersections = 0;
        //            for (int i = 0; i<A.Length; i++)
        //            {
        //                //intersect.Add(i, 0);
        //                for (int j = 0; j<i; j++)
        //                {
        //                    if (i - A[i] <= j + A[j]) intersections++;

        //                }
        //}

        //            if (intersections > 10000000) intersections = -1;
        //            return intersections;


        //public static int NumberOfDiscIntersections(int[] A)
        //{
        //    // write your code in C# 6.0 with .NET 4.5 (Mono)
        //    //Dictionary<int, int> intersect = new Dictionary<int, int>();
        //    int intersctions = 0;
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        //intersect.Add(i, 0);
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (i - A[i] < j + A[j]) intersctions++;

        //        }
        //    }
        //}



        public static int Triangle(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            if (A.Length < 3) return 0;

            for (int i = 0; i < A.Length - 2; i++)
            {
                if (A[i] + A[i + 1] > A[i + 2])
                {
                    return 1;
                }
                if (A[i] == A[i + 2] &&
                   A[i + 2] == A[i + 1] &&
                   A[i] == Int32.MaxValue)
                {
                    return 1;
                }
            }
            return 0;
        }

        private static int Distinct(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length <= 0) return 0;

            int[] newA = A.Distinct().ToArray();
            return newA.Length;
        }

        private static int MaxProductOfThree(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);
            int a = 0;
            if (A[0] < 0 && A[1] < 0)
                a = A[0] * A[1] * A[A.Length - 1];
            int b = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

            if (a > b && (A[0] < 0 && A[1] < 0)) return a;
            else return b;
        }

        private static int[] GenomicRangeQuery(string S, int[] P, int[] Q)
        {
            var nucleo = new int[S.Length + 1, 4];
            for (var count = 0; count < S.Length; count++)
            {
                if (count > 0)
                {
                    for (var index = 0; index < 4; index++)
                    {
                        nucleo[count + 1, index] += nucleo[count, index];
                    }
                }
                switch (S[count])
                {
                    case 'A':
                        nucleo[count + 1, 0]++;
                        break;
                    case 'C':
                        nucleo[count + 1, 1]++;
                        break;
                    case 'G':
                        nucleo[count + 1, 2]++;
                        break;
                    case 'T':
                        nucleo[count + 1, 3]++;
                        break;
                }
            }

            var result = new int[P.Length];
            for (var count = 0; count < P.Length; count++)
            {
                if (P[count] == Q[count])
                {
                    switch (S[P[count]])
                    {
                        case 'A':
                            result[count] = 1;
                            break;
                        case 'C':
                            result[count] = 2;
                            break;
                        case 'G':
                            result[count] = 3;
                            break;
                        case 'T':
                            result[count] = 4;
                            break;
                    }
                }
                else {
                    for (var index = 0; index < 4; index++)
                    {
                        if ((nucleo[Q[count] + 1, index] - nucleo[P[count], index]) > 0)
                        {
                            result[count] = index + 1;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        private static int MinAvgTwoSlice(int[] A)
        {
            int minI = 0;
            double minValue = 100001.0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if (((A[i] + A[i + 1]) / 2.0) < minValue)
                {
                    minI = i;
                    minValue = (A[i] + A[i + 1]) / 2.0;

                }
                if (i < A.Length - 2)
                {
                    if (((A[i] + A[i + 1] + A[i + 2]) / 3.0) < minValue)
                    {
                        minI = i;
                        minValue = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                    }
                }
            }

            return minI;
        }


        private static int PassingCars(int[] A)
        {
            int pairsCar = 0;
            int factor = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == 0) factor++;
                if (A[i] == 1) pairsCar += factor;
            }

            if (pairsCar > 1000000000) return -1;

            return pairsCar;

            int l = A.Length;
            int countZero = 0;
            int countPairs = 0;
            int exceed = 1000000000;


            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1) countPairs += countZero;
                else countZero++;

            }

            if (countPairs > exceed || countPairs < 0) return -1;
            else return countPairs;
        }

        private static int CountDiv(int A, int B, int K)
        {
            //// write your code in C# 6.0 with .NET 4.5 (Mono)
            int result = 0;

            if (A % K == 0)
            {
                result = ((B - A) / K) + 1;
            }
            else {
                result = (B / K - ((A / K) + 1)) + 1;
            }

            return result;
        }

        private static int[] MaxCounters(int N, int[] A)
        {
            var increase = 0;
            var maxcounter = 0;
            var counters = Enumerable.Range(1, N).ToDictionary(i => i, i => 0);

            foreach (var number in A)
            {
                if (number == N + 1) maxcounter = increase;
                else
                {
                    counters[number] = Math.Max(counters[number], maxcounter) + 1;
                    increase = Math.Max(counters[number], increase);
                }
            }

            return counters.Values.Select(v => Math.Max(v, maxcounter)).ToArray();
        }

        private static int MissingInteger(int[] A)
        {
            HashSet<int> set = new HashSet<int>(A);
            for (int i = 1; i <= A.Length + 1; i++)
            {
                if (!set.Contains(i))
                { return i; }
            }
            return -1;
        }

        private static int PermCheck(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            long length = A.Length;
            List<int> perm = new List<int>();

            for (int i = 0; i < length; i++)
            {
                perm.Add(0);
            }

            for (int i = 0; i < length; i++)
            {
                if (length < A[i]) return 0;
                perm[A[i] - 1] = 1;
            }

            int ret = 0;
            if (perm.Contains(0)) ret = 0;
            else ret = 1;

            return ret;

        }

        private static int FrogRiverOne(int X, int[] A)
        {
            int N = A.Length;
            List<int> k = new List<int>();

            for (int i = 0; i < X; i++)
            {
                k.Add(0);
            }

            for (int i = 0; i < N; i++)
            {
                int diff = A[i] - 1;
                k[diff] = A[i];

                if (i >= X - 1)
                    if (!k.Contains(0))
                    {
                        return i;
                    }
            }

            return -1;
        }

        public static int FrogJmp(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (X == Y) return 0;

            int distance = Y - X;
            int jumps = distance / D;

            if (distance % D != 0) jumps++;

            return jumps;
        }

        public static int PermMissingElem(int[] A)
        {
            Array.Sort(A);
            if (A.Length == 0) return 1;
            if (A[0] != 1) return 1;
            if (A[A.Length - 1] != A.Length + 1) return A.Length + 1;

            int lastNumber = 0;
            foreach (int number in A)
            {
                if (number - 1 != lastNumber) return number - 1;
                else lastNumber++;
            }

            return A[A.Length - 1];


            //long length = A.Length;
            //length = (length + 1) * (length + 2) / 2;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    length = length - A[i];
            //}

            //return (int)length;
        }

        public static int TapeEquilibrium(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int minDiference = 0;
            int diference = 0;
            int sumPart1 = 0;
            int sumPart2 = 0;

            for (int ij = 1; ij < A.Length; ij++)
            {
                sumPart2 += A[ij];
            }

            sumPart1 = A[0];
            minDiference = A[0] - sumPart2;
            if (minDiference < 0) minDiference *= -1;

            for (int i = 1; i < A.Length - 1; i++)
            {
                sumPart1 += A[i];
                sumPart2 -= A[i];
                diference = sumPart1 > sumPart2 ? sumPart1 - sumPart2 : sumPart2 - sumPart1;

                if (diference < 0) diference *= -1;

                if (diference < minDiference) minDiference = diference;
            }

            return minDiference;
        }

        private static int OddOccurrencesInArray(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 1) return A[0];

            Array.Sort(A);

            int last = A[0]; int count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == last) count++;
                else if (count % 2 != 0) return last;
                else {
                    last = A[i];
                    count = 1;
                }
            }

            return last;
        }


        public static int BinaryGap(int N)
        {
            int qtyGap = 0;
            int qtyMaxGap = 0;

            string strBinary = Convert.ToString(N, 2);

            int posBegin = strBinary.IndexOf("1");
            int posEnd = 0;

            while (posBegin < strBinary.Length && posBegin != -1)
            {
                posBegin = posEnd;
                posEnd = strBinary.IndexOf("1", posBegin + 1);
                if (posEnd == -1) return qtyMaxGap;

                qtyGap = posEnd - posBegin - 1;
                if (qtyGap > qtyMaxGap) qtyMaxGap = qtyGap;
            }

            return qtyMaxGap;
        }
    }
}
