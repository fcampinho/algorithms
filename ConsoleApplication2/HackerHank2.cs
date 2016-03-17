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
            GridChallenge();
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
            int m = 4;
            m = Convert.ToInt32(Console.ReadLine());

            int n = 4;
            n = Convert.ToInt32(Console.ReadLine());

            int qty = 0;
            int qtyMax = 0;

            string[][] matrix = new string[m][];
            for (int j = 0; j < m; j++)
            {
                string row = Console.ReadLine();
                matrix[j] = row.Split(' ');
            }

            int maxCC = 0;
            int curX = 0; int curY = 0;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    bool bChange = true;
                    curX = j;
                    curY = i;
                    while (bChange)
                    {
                        bChange = false;
                        if (matrix[curX][curY] == "1" || matrix[curX][curY] == "X")
                        {
                            if (curY < n - 1 && matrix[curX][curY + 1] == "1") { bChange = true; matrix[curX][curY + 1] = "X"; qty++; }
                            else if (curX < m - 1 && curY > 0 && matrix[curX + 1][curY - 1] == "1") { bChange = true; matrix[curX + 1][curY - 1] = "X"; qty++; }
                            else if (curX < m - 1 && matrix[curX + 1][curY] == "1") { bChange = true; matrix[curX + 1][curY] = "X"; qty++; }
                            else if (curX < m - 1 && curY < n - 1 && matrix[curX + 1][curY + 1] == "1") { bChange = true; matrix[curX + 1][curY + 1] = "X"; qty++; }
                            else if (bChange && matrix[curX][curY] == "1") { matrix[curX][curY] = "X"; qty++; }
                        }
                    }
                }
            }

            Console.WriteLine(qty);
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