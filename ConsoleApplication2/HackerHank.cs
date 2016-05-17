using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class HackerHank
    {
        static void Main(string[] args)
        {
            //int[] ar = new int[] { 406, 157, 415, 318, 472, 46, 252, 187, 364, 481, 450, 90, 390, 35, 452, 74, 196, 312, 142, 160, 143, 220, 483, 392, 443, 488, 79, 234, 68, 150, 356, 496, 69, 88, 177, 12, 288, 120, 222, 270, 441, 422, 103, 321, 65, 316, 448, 331, 117, 183, 184, 128, 323, 141, 467, 31, 172, 48, 95, 359, 239, 209, 398, 99, 440, 171, 86, 233, 293, 162, 121, 61, 317, 52, 54, 273, 30, 226, 421, 64, 204, 444, 418, 275, 263, 108, 10, 149, 497, 20, 97, 136, 139, 200, 266, 238, 493, 22, 17, 39 };
            //int[] ar = new int[] { 1, 3, 9, 8, 2, 7, 5 };
            //1 3 9 8 2 7 5
            //bool p = palindrome("ciicv");
            //insertionSort2(new int[] { 2, 4, 3, 5, 6, 1 });
            TheGridSearch();
        }

        //String S = input string

        static void CountingSort1()
        {
            int _ar_size = 1000;
            //_ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            //String elements = Console.ReadLine();
            string elements = "89 37 29 73 68 82 58 45 84 17 88 46 69 60 20 24 34 49 52 80 43 72 92 55 10 49 14 88 77 47 64 43 23 66 64 86 27 63 38 62 75 25 58 13 79 30 26 12 94 96 29 92 59 15 98 39 32 81 78 13 15 86 72 45 82 46 42 66 97 85 42 46 56 57 40 54 63 27 32 68 2 64 29 22 38 18 36 60 82 20 75 18 79 70 17 56 6 15 11 15 40 17 5 96 84 7 78 28 74 51 67 3 48 53 30 46 9 89 40 65 16 61 98 33 3 19 57 84 32 27 42 83 60 80 27 17 98 61 7 14 76 74 65 37 2 97 52 12 77 40 41 99 90 29 55 76 71 62 63 46 27 46 51 3 11 89 75 52 78 23 96 17 65 85 63 19 16 50 42 4 92 67 51 96 53 7 37 97 45 5 70 73 80 73 39 19 15 43 39 34 4 31 72 26 96 98 17 84 8 76 21 5 86 23 30 95 88 92 44 33 7 10 32 1 69 88 10 19 29 8 82 86 25 91 60 47 18 7 36 53 88 40 25 29 69 99 82 93 47 92 25 33 26 8 88 83 16 87 31 95 9 0 28 52 20 39 20 81 71 39 10 85 63 22 8 98 67 26 99 96 71 19 64 75 54 35 58 26 40 89 46 67 23 53 61 17 69 41 62 64 19 74 48 61 81 38 49 38 69 74 61 20 2 84 48 35 63 91 82 75 98 87 16 35 26 53 9 0 84 75 41 28 25 48 11 0 99 11 10 71 79 58 96 88 94 0 74 75 84 52 92 53 93 13 21 91 64 46 16 6 82 57 19 53 95 29 1 46 52 58 99 78 37 23 60 24 47 10 97 34 38 6 35 49 53 98 84 62 51 66 78 30 58 48 60 34 51 30 95 16 36 55 53 99 54 3 53 57 43 55 98 92 53 98 73 70 86 7 50 58 75 32 67 36 84 56 37 81 6 73 90 5 8 69 92 18 3 76 59 42 88 87 64 48 45 95 33 40 5 51 58 5 30 20 87 33 37 61 14 36 95 32 44 33 74 93 23 23 28 4 90 75 58 93 20 60 57 64 79 56 69 35 45 37 14 6 47 16 36 90 18 29 4 82 19 77 8 22 54 2 65 37 86 5 67 58 33 86 43 15 4 97 62 39 7 12 60 75 17 66 97 76 57 86 75 7 78 49 74 81 50 26 69 82 75 40 17 34 24 15 37 8 18 35 24 19 86 47 0 14 30 22 20 3 97 56 93 55 28 11 98 78 19 5 70 71 42 62 91 0 84 36 24 21 26 59 20 46 65 26 82 50 34 40 98 30 63 60 2 91 83 94 18 69 12 37 22 97 53 78 17 85 66 27 55 0 96 89 73 85 42 21 81 5 38 37 62 14 77 60 57 17 45 43 25 53 82 72 30 2 85 25 8 29 18 21 96 51 4 55 23 79 9 40 35 10 96 24 96 18 11 81 55 27 72 8 28 67 40 32 77 76 26 17 63 47 99 22 37 64 42 32 3 41 15 83 86 58 5 74 93 47 44 18 1 32 27 41 10 74 67 42 81 70 17 57 26 92 33 29 23 42 90 9 40 11 20 85 79 67 26 62 19 81 45 17 92 20 34 52 79 39 90 58 92 56 12 66 69 20 53 0 14 5 1 44 34 49 47 68 53 62 13 21 37 36 66 25 55 87 88 4 31 2 54 64 71 62 97 95 45 46 23 94 37 45 45 49 50 54 24 10 29 44 91 93 12 71 9 73 45 46 63 94 10 50 94 64 22 96 54 53 89 67 98 2 42 15 31 82 82 18 72 41 20 8 21 57 54 78 37 47 37 75 26 32 17 64 79 46 88 46 57 63 62 63 30 86 99 57 32 58 48 67 27 7 0 6 9 50 82 55 72 5 48 20 45 62 67 32 45 94 18 81 92 33 78 9 97 76 25 29 74 86 0 59 60 45 25 6 25 14 4 20 10 45 34 4 64 6 21 42 87 0 81 16 77 16 79 46 24 33 83 62 95 52 52 51 92 47 57 97 47 53 12 62 24 41 74 35 3 95 70 13 13 99 50 19 2 63 4 70 42 78 95 8 69 56 98 54 42 73 22 45 73 22 7 32 58 6 90 13 50 74 26 37 44 9 60 54 45 87 30 8 24 81 23 91 90 97 29 49 31 47 93 88 6 29 48 11 43 28 28 2 9 73 37 48 72 56 62 13 48 19 83 21 29 19 24 76 60 35 89 76 18 65 2 32 45 91";
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }

            Dictionary<int, int> count = new Dictionary<int, int>();
            for (int i = 0; i < _ar_size; i++)
            {
                if (count.ContainsKey(_ar[i])) count[_ar[i]]++;
                else count.Add(_ar[i], 1);
            }

            for (int i = 0; i < 100; i++)
            {
                if (count.ContainsKey(i)) Console.Write(count[i]);
                else Console.Write("0");

                Console.Write(" ");
            }


        }

        public static bool palindrome(string s)
        {
            int qty = 0;
            char c;
            Dictionary<char, int> p = new Dictionary<char, int>();

            if (s.Length <= 1) return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (p.ContainsKey(s[i])) p[s[i]]++;
                else p.Add(s[i], 1);
            }

            foreach (var item in p)
            {
                if (item.Value % 2 != 0) qty++;
            }

            return qty <= 1;
        }

        static void BiggerisGreater()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 100000;
            //string[] linesInput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\sort\question.txt");
            //string[] linesOutput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\sort\answer.txt");

            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                //string s = "vvvygfabrsqeitgelpxwodhdfyypoyufxnecmrtkbzbhzfbtvnffcmikqoosfzoozssonomkgmtdqfecrqtps";
                //string s = linesInput[a0];
                string f = s;
                char lastMin = 'ç';
                int posMin = -1;
                int posChange = -1;

                if (a0 == 153) Console.ReadKey();

                for (int j = s.Length - 2; j >= 0; j--)
                {
                    for (int i = j + 1; i < s.Length; i++)
                    {
                        if (s[j] < s[i])
                        {
                            posChange = j;
                            if (s[i] < lastMin)
                            {
                                posMin = i;
                                lastMin = s[i];
                            }
                        }
                    }
                    if (posChange != -1) break;
                }

                if (posChange != -1)
                {
                    string p = "";
                    if (posMin > 0) p = s.Substring(posChange, posMin - posChange);
                    if (posMin != 0 && posMin < s.Length - 1) p += s.Substring(posMin + 1);

                    f = "";
                    if (posChange > 0) f = s.Substring(0, posChange);

                    if (posChange != s.Length - 2)
                    {
                        char[] c = p.ToCharArray();
                        quicksort(ref c, 0, c.Length - 1);
                        f += lastMin;
                        f += string.Join("", c);
                    }
                    else
                    {
                        f += s[posMin].ToString() + s[posChange].ToString();
                        if (posMin < s.Length - 1) f += s.Substring(posMin + 1);
                    }
                }
                if (s == f) f = "no answer";
                //if (f != linesOutput[a0]) Console.ReadKey();
                Console.WriteLine(f);
            }
        }

        #region Lomotu
        static void quicksort(ref char[] A, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = partition(ref A, lo, hi);
                quicksort(ref A, lo, p - 1);
                quicksort(ref A, p + 1, hi);
            }
        }

        static int partition(ref char[] A, int lo, int hi)
        {
            int pivot = A[hi];
            int i = lo;        // place for swapping
            char temp;
            for (int j = lo; j < hi; j++)
            {
                if (A[j] <= pivot)
                {
                    temp = A[i]; A[i] = A[j]; A[j] = temp;

                    i++;
                }
            }
            temp = A[i]; A[i] = A[hi]; A[hi] = temp;

            //Console.WriteLine(string.Join(" ", A));
            return i;
        }
        #endregion

        //static void quickSort(ref int[] ar)
        //{
        //    int pivot = ar[0];
        //    List<int> left = new List<int>();
        //    List<int> right = new List<int>();

        //    for (int i = 1; i < ar.Length; i++)
        //    {
        //        if (pivot > ar[i]) left.Add(ar[i]);
        //        else right.Add(ar[i]);
        //    }

        //    bool bSort = true;
        //    for (int j = 0; j < left.Count - 1; j++)
        //    {
        //        if (left[j] > left[j + 1]) { bSort = false; break; }
        //    }
        //    int[] arLeft = left.ToArray();
        //    if (!bSort) quickSort(ref arLeft);
        //    if (bSort && arLeft.Length > 1) Console.WriteLine(string.Join(" ", arLeft));

        //    bSort = true;
        //    for (int j = 0; j < right.Count - 1; j++)
        //    {
        //        if (right[j] > right[j + 1]) { bSort = false; break; }
        //    }
        //    int[] arRight = right.ToArray();
        //    if (!bSort) quickSort(ref arRight);
        //    if (bSort && arRight.Length > 1) Console.WriteLine(string.Join(" ", arRight));

        //    int[] arFull = new int[ar.Length];
        //    if (arLeft.Length > 0) Array.Copy(arLeft, arFull, arLeft.Length);
        //    Array.Copy(new int[] { pivot }, 0, arFull, arLeft.Length, 1);
        //    if (arRight.Length > 0) Array.Copy(arRight, 0, arFull, arLeft.Length + 1, arRight.Length);

        //    bSort = true;
        //    for (int j = 0; j < arFull.Length - 1; j++)
        //    {
        //        if (arFull[j] > arFull[j + 1]) { bSort = false; break; }
        //    }
        //    if (bSort) Console.WriteLine(string.Join(" ", arFull));

        //    ar = arFull;
        //}

        //static void partition(int[] ar)
        //{
        //    StringBuilder left = new StringBuilder();
        //    StringBuilder right = new StringBuilder();

        //    int p = ar[0];
        //    for (int i = 1; i < ar.Length; i++)
        //    {
        //        if (ar[i] < p) left.Append(ar[i] + " ");
        //        else right.Append(ar[i] + " ");
        //    }

        //    Console.WriteLine(left.ToString() + p + " " + right.ToString());
        //}

        static void RunningTimeofAlgorithms(int[] A)
        {
            var j = 0; int split = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;

                    split++;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(split);
        }

        //static void Main(string[] args)
        //{
        //    Console.ReadLine();
        //    int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        //    insertionSort(_ar);
        //}

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
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));

        }

        static void insertionSort2(int[] ar)
        {

            int i = 1;
            int j = 0;
            int value = 0;
            while (i < ar.Length)
            {
                if (ar[i] < ar[i - 1])
                {
                    value = ar[i];
                }
                else { Console.WriteLine(string.Join(" ", ar)); i++; }

                if (value != 0)
                {
                    j = i;
                    while (j > 0 && ar[j - 1] > value)
                    {
                        ar[j] = ar[j - 1];
                        j--;
                    }

                    ar[j] = value;
                    Console.WriteLine(string.Join(" ", ar));
                    value = 0;
                    i++;
                }

            }

            //else Console.WriteLine(string.Join(" ", ar));
        }

        static void insertionSort(int[] ar)
        {

            int i = 0;
            int j = 0;
            int value = 0;
            while (i < ar.Length - 1)
            {
                if (ar[i] > ar[i + 1])
                {
                    value = ar[i + 1];
                    //i++;
                    break;
                }
                i++;
            }

            if (value != 0)
            {
                while (i >= 0 && ar[i] > value)
                {
                    ar[i + 1] = ar[i];
                    Console.WriteLine(string.Join(" ", ar));
                    i--;
                }

                ar[i + 1] = value;
                Console.WriteLine(string.Join(" ", ar));
            }
            else Console.WriteLine(string.Join(" ", ar));

        }

        static void Sort()
        {
            //int v = 4;
            int v = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = Console.ReadLine().Split(' ');

            int i;
            for (i = 0; i < n; i++)
            {
                if (Convert.ToInt32(arr[i]) == v) break;
            }

            Console.WriteLine(i);
        }

        static int CommonChildRec(int posS1, int posS2, string S1, string S2, int qty, int nivel)
        {
            int qtyMax = 0; int qtyAcum = qty;
            while (posS2 < S2.Length && posS1 < S1.Length)
            {
                if (posS1 < posS2) posS1 = posS2;
                int pos = S1.IndexOf(S2[posS2], posS1);
                if (pos != -1)
                {
                    qty = CommonChildRec(pos + 1, posS2 + 1, S1, S2, qty + 1, nivel + 1);
                }

                qtyMax = Math.Max(qtyMax, qty);
                qty = qtyAcum;
                posS2++;
            }

            return Math.Max(qtyMax, qty);
        }

        static void CommonChild()
        {
            //string s1 = Console.ReadLine();
            //string s2 = Console.ReadLine();
            string s1 = "ABCDEF";
            string s2 = "FBDAMN";
            //string s1 = "SHINCHAN";
            //string s2 = "NOHARAAA";
            //string s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
            //string s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";
            //string s1 = "UBBJXJGKLXGXTFBJYNLHQPULFILXLMPDQFWIYVBRSRFNETTEGXOHLBVOAJMHLZMTMPSJCPWJGHISUUIKDPPAWVQMZECIEIQUPLMFKENHVLKCJVDDSUPDOZXBZSRMWHLIHENULKFEXVCZIOVHRQHZWMDAYLDLGXSTMPDBGAMEBHOMOGGEBFRITAQVALWGINAOWMTRJLJHGEVJOPCVXZQVDBKOUPFJWHMRXULNNKRUUITTVIXYYSZDECBIBBIIWPDOEMFHDJKUSIFZNOTGIVDIJJVHPOGQHXWERMYNYGYOHJYGNOVFNWWERWMTBZOAXNHTCJIBOCUBXERSJORHOAMALOODYOHXIDEINMDWSNKUKFLMFHZLUIFOVDDSGPRJLUOLSFVNCVZUIWRFLKGCKPHGBWMXGNATTRKPOPYYMTHSRYHVXOGFDVRSKDVHHCTJIRAWOLDFDCRXROEVQXMDVOJSGHUPHDSGAJUFWLILUNCGSEPBIGBDNNAGCHBZHFWVUDPAQXLAXIPLSZWDLRQJOMILYKVJNMGBPARKUUTIHOAFIKIRWWUAZASRTOOYHPNHCANPDHGZEWHKAIBGDAAZLAYRWKRWUKBVTRAMLQKSRYVSRXRYVVBOUEGBMGXAZMTQMAJHKGQCRLAJORKHTVLPWFDOZFWHJXMMHNMQIJOBNALQQMPBHMIZCGRGQKOSTJHQXYXUOFKDYKHEISOYNVJSMLYSTEEBWSPFNWIYVBWEFGTUFRZZJGXSMUQGLKQNJPBLKDTXOZQEHXXGKHJZPUUOCWMXUNIBNTJCUFXRQWZGZSLYADLXFYOOPLJRLSYYYHQQUCFEAHNWZOMOUWAUYRFAWHDUPAOJHHPIWYLQRFXGRUCUOAMDNFVTTWTXREEUFCSXADRQKRLRTWYSOGJQSIQZQJHLFWOHTMTYETCJRBRVNYAWIOTXTVEVJMXSGDBESHKJMWQZLWBPSRQAIVURCOZJUXTKCDVJSTEEEXWZCHIFXCROXLHDDVGSFLRPNLRPNXFUUBATGIZJUUVUXMUWAZGKJBRRJAIVIACJTZICMLIKDJRMPVOHEQNAYZMNDMQFMAJNMQOZBXYIXTZDLUJAPISDFMILADTNCJMWSINHWZNGNJNWCRQBSFZAAQVOVQAHJTGFAQTYBEHMSWYGQOJTNJKVVBXZQHOCBOSSBKVRRVFGEXXRZEEOSTOLDFXEATRULHACAQXYAXDEXHFHHGOBXZNIBHEJMRLLNNHICIFTPCRWIPNCXYYRJRERNDVSZAOXIULLFQROQLUAZXDRSYGWOVNCLUBKKRNBEYKALCZDJCJMPFBQXIIMNOHYWEHYGWBRVGNZYVRHVIOSMCATCNDNHKJQVILGTTJIIYPYWECZWDHUGMYBGOAANHFHRUHHFSNXIPYDTEACTOWCUYEXZIOFVOYOYPRQQSBGCBQSFQMTHMCKADQWTMSPHSDYIMOHHWJADQFCRIZANPLWJDCXYXUKOXEMWVKHBISONBQJLODRNPRSSUMBIUKAINIRZEZSHKPTYYVXTGXCRXAULWYFDTRPWWIYDVGFVLNSLIAZHKLWCHVBUFJWINZWKZNVYJYKJYKJIBOBJRQGGVPADSKQHXPSZHXVAVIWQTXZBBDJMTVVFDMZMCWIPEAXLUJJECGMHETBGCJZWIAMKJPXDRYNYZDVYIXHFNOBGOPKUCXTUDFVZFAMWKBTHZDXQNUMFQRNZZNQPYBSWCFJDGOGBAVORCVMWPPRLOKGFCSUMMUBDHABUEYTGOPRLPYESPONOIQNMUQGBFGULJYRLESRQCYNXLOPTBTOZKPRABIYIUWRWIPWONTDPKNGMPHSEWHGNIIAVKUVIXIQZGPNSXCNPPLMIOXKMNUUIAUABOQMMYRJDVDAYAAYOXOWQAVGBMCMIZTVDGKQVXCWRUCCUHSHWXKLZIKJDKIZZBSMBGNYARWXMMKNIPMBKUKSYBVYLTHLIDEHXBHSNYVYJVINFOKPNQCAZIDRYAWTWODCYHUTVHDLBPAQIJJNDDEMVVADJXIJHHHJEVSCHPNJLAUGUPEZAZJEVTJQWCAUUZISUMSYJPRUBAOCAFMTUHXOWBPRAGKFYPLJUPHWHEEOOWKDXYHISNGQYJTADSPAGQMIVZQZLIZQGMMIOKMTKMCOHDZQRYGIKEJCKOBGHWUJZNNSDSSUPUDTPXNBBOKYZRFCORNYJEQXDXGDTIKQMKZNCANALAIPXFIDROXSCHDSPXUMHIHYRCETHUZQJHLCSNGEMBDDFPNONFMKDFXPYANYIYHSKMLYOJRQFOBWIGTEBZVLQDXNUDHZXNMESUJWWQSMZYRXTHXXCEAFUJVFHYYBEOJEVGBPHYMKWVHCCIARIBUISSSAPDIZRBRMSUBWYEKVUMGPJCBBOCDCLMCZBWBVYRQRREQPLHUNHMHTRGLXXXKZJBLJWYKEOJWIQEYBHWJCLQGHHLASDDMWAHFYZHCZJPXJWZQTDGKTOJRAHCTIDIVHRQUHSCMRDICYAAPQYZEQBMXUEPOTILSIJKEEOJXXFFXWDXBVZYTQJSAUAQKELWVTTQGXAHXJWBKBZWZVZADQSCHFQBMSXLCGNNGDMIPFWNKAVZIQLIHBMABUBXSGXXTREJZYBTFBAVIIKTDAIRPYWQZANPYLDJSHRZPMWIPZJPUQUTXJPKMRNOAYOHPFCVLINPOTRDAZWXZCJMDLHGOOLZTNQXMVPNOUZCDFEYATNLCODMOQLDSPYOAPQITRJLQYEBBTOEOHKJKCCETKIADLYLJOMWLGZSKPJQAPFJFOTPTRDCTUCHKTJMTVIFSCRCADLSGNNIUHXXHKOSTZEZMJRYIYCIWCZQPMJPFNBGGIRBTWQYDTVSKDNXDVVIFEJSKELBNQUGYDVKHOUMFGBABLJAYLZKASVYVLCJALPJCUGCULUCLCZIZUYNRPBOQJZHTCKIHEQYMTYLOHJLOEAKZBCGKAQRJSATNRZUSFOSEQXEEZCDBALXHUALTQVBBAWRFBIWKBESOYXPBZINJPUJIKHUJWTJLKHKKQWQTWZNLHSTHYUVINLTDXFNEFRFEGODSFWXGDWZHAVWRNROFTNYEVEBWKMZZURJKOHOHQTANWSMKBNGQOWQHGWWGWAQPNSFNFAKUJNEHRMBYJTWYXKQCWYVGLSEUZGBIFDCEJKVTUGCEKGOFGXDOPADDEZQSHPOWIDPMRCPEEIBBAIUJFVCGAFVSPOJSUPSRYAFBBPALHFKIBQKZEWNUTESHZCHPJHSQUCIEAKQXQWVNJKYHWCSKUEPDRSYGLYQDLFAHYCOCYOXCUKIDVVROCZFOCQCLIHYKOBQPTRAOPZFMOBQNZXHIPZFTDZJALTSKOYTEYAOAOCYEXBGRQYWUOEAVHQUXBPTMVDMIVOWWURCVCXJBSKGNKDMRKQCIYRYHQJTROFIGSITZACPYJDAYODNXWWIDMMNEQWEVLKJAHXERTAPWJHYDTVGSVXADZLUEEMPRSVRJCNAEOIAUJMCYYMKOSZFRXDSOKMXVXGGXSHZHJSPFKMNPBOBQRXFRGFTOGGCVNSWUTUQFVWQLRXMBRLIHOESBLCCINFAHGSAYJVDZOTGVAFDTCLAKQVQHRXPPWZHVOMUNCYWGCLBHXRCYOIZDHFWVRSGQHQQSXDHIGOTKUZAOZXPCROWQIZWBEDUJTYADZOMLAADXDOHDZJLNGXVENVCPWUPBZCWAWTIJKYTRUMITKRNHTFEUVDHVAGLXJCIQJCBTBTZGVHONTTMAMWRWFETPAKQJMDZPZLQPMEJICRKYBFPBHWLIOCXVDXQDEBHVLXOSYKYBSUAFHLOJQFNAUZGVVLMVINWBEJAGFJOTWFIDEIOXPZESJBZBXVCOYWTDDAILFJOKHJPVCALFABUJAHUEDMBPESMINFHTSSLJTQDTYREYQPNJYYDQBLBCUCEOYVGGZDMGGAVBOVPZHWCFMALQTQWMOEWUOJDYCCUFULJBHDDULAWCDXZTMAICBKRVXWXYTNUVNPLVZVIBKJEMKIXCDSVGDLNDXFMUNEOWSUWQCIYNPAEJCHGEUAKBXGCFGLJRFSTZHERMKGIQQYDYXMKUFESCWIQWKRBNYRASHYXUGYMRUZOGKZKNGQDWRXJUWAZBISCSLYBASSZUEHUVZIGHONWDSDVFTKUOECNMKYMWLLPNKYDINPKSLFYIBNERJIZUSELWCICKHZJVDBUIIXHGKRQGOGCSUIYVHWROOAPWMWMGBYWGBDSTFKXFUIWPJOBFEICKIJHHHLNVUDCEMLWEPKCANBMFGODZQRRXRIPKXBGYWAKOWIHFWWXCTZXJVCSHEXDZAXVQYDHMKTFTWVSZHPDPQFCBHYDT";
            //string s2 = "WZFPTGLCXKNHAKSFEIXYOHTDCCSDAKYASOBHHDTBEZXRKGKOJOLMEGTPSWQNRODAHQOYMOJDVGVSUSMDMLJLVQZYREJGKMKLXGBQEPYXVCTABIBGSWXFWXIIIKDAOXUWZLNYOWRWAUCQTACZPIZREJGTIBCACYDCGSAUULVWRCDLSMIAPCDPHJEOUPOLYPUDSEBYVIUMPLMGTFWCZKDZOHHSGRZDGGPXCUBINGTMOTEOHGLTPOUGCLLJJYFCJJATPZKJSVVKDBJOCJIUNGJJITGMBSYMJLMOCYEGTFECRMBFSBFLXCPSIOJZONIMPPKXETQEEYHUODXZCZJSGMRPFEIRUBUZMHSHRXNXKHMVEMFCSPQQGVEWOMJXSHDRBSPZTFFBAYKXSVULEHDYTDCWATCQCDDEUZINAXFLMWJLOPVWMAMSTMXKKOXSGLAWMGAIWTYWTPBWYEAKSWKSSDQTWVYDFHNTMLAGJBFUSVXUZCMSMDAUBPQOUYLIGVSWGVTASPISVRYGKCJTSKRXCMQOUVNMIIOMQZGZTGLUSRZXFVRLPKDSTTOTHEBQNJNCAICMFQRISSKYKTQWVLLGLLUCHDCKNXSWKGXHEVJGTLQFZJBAPYPUMYLQJPRJZCSRRPSTJQZGVFINHPRKVMHQUPUAAWVAGZIUMNXXGMWQAZXOFHPIHIMJCJMXVUMFSVYGXIIQOSFCRDXYIBHDAZFCJLQTYPVZUEWHCHABWOBSFZMSDHZUDPLRKWIHKJTJLUDZEGHRERGCEGXAWHXHPNEBANUYQVJDVGTFHOUPIVEHVLYZHELIWZPXLKMRLFIHTBBXPSCZZKFDYNHAHFBACRXGGLWLKZDCKPPHPYHLKVJQNXSZVXXBCREROFCITROSOSILHTCXPTNUETFSWJBNHMIIESTBUPFPRCODHDNHSWUEDBUQLYAPSJNHOVYMHXEOCUAHAMTXAFWRTPGMLIOVXDUKCFIVBRVXWTSJYHYTNGQGVPUEQPZAOLVGHDWBHBRHIFVZHAWZQDMNOUXTNJRPTIASYVQIJLBMMCRNYLHMBPIKGVDPPTGKZZNXXTYGNFKYNQKRCDBKHXYXMGJJQERHDUIGMBVNNDCECRCTAQEJRFKWEAZDJJBVSSGFLQYALBPKCPXUMIELWGRWWHLQLTKZFPKXWTMMIYHLOSZOGELNGJEHTIQKJXLKIUOCVWOZEXMWQMSVEAHQQMYHGIBMSQUPEZNDRJGPGGEYVSHEMAYEEDAMLGUUCOKTMKFJVQMKOWXOLEUCYMSTLWROBVFSIFFELMDPXRFRZMVXTSMBONXRSYSLKDLMTCCATCPNLQUTMIODOVTEBFFJVRXLRHJZLWFOJMQAPTTBOQPBQIUWRBHIVHKCELSUUVYKOHVIPHUGBLFZFEECTYORMHBFQMNDNYJANEAHZEGAGNHZOUYEVLAXJXLKYQKSSMITMPYUHTYXRSXTXYLMFYVXDMJFJCAXUFKJLNRDLERJAPAERTYJJFAUFPKYCILLMPDWKZYPWGHYIUCEDRYAAUAQXSPZMYVPGBJYBABGELVTBRFCMCBRQZIWTFOGMRTWZLTMFKPKJEIXTCQUHBIRIRUZBIRBLQDWDEVQBMNFFHJYVIFATHAZBWKVDPDCAVBQOJUUSBHKKNUVNMXSDDXOAWZWUDFLPBJEDAHLYCHTYXHEFQIJABDKILJYPWLHRXUZYFAJGSREEKIXHKTBLZBYFSJSHJVTNWZZIGJHZHSFWZHLEMBHOYFLQOUPJKLZCOUTAVAJWOTTWNFRZJRTZWUTOGNFTWQXJKRFIEZBEQLVCCHVKMOUOFWNPKAIISJHCZVMBQFBOYVWKAMMSZJTYLUXTOVDUNXKADHSTMFBDRGAIULKUOXIFWHJDXLCSFBIMJGELSAGXEALCLIUVCHESOHYLLJPDKYJICTLFTUAYLJUXZQRVHYGBFEDKEJSXLGBRZFEWDZUWTYRYRRVCZJBWEATAGHSHMABGFBQVXODNHJCGMSYKJETETHKZPJHCTMIGUDRMOKCSBKCQQYOTYHGOYJVAIFYCBKZDVXHSHRSFNIMZNBJLLBNKFXSRXPCOXJBYYEWYCAVCQSJYWGBEXWZIXNLGMNEZTVWSMAPWXHKVCXUCIQOBFDNSJKTMLGRGMHMRSYRZEWSUKKVAGTXWDSFHXTHBCBCQLVTQOPGHXKOZCPCQOGFADJTNNHTMCPPWKRCFFPAPPVQFZSUUHPIZCKOYFZNKSJKNLHFOBWPAZYTOJLRYHTNDLXGWDLMYHUOVBQQZARLKZGCJXHSQMFHJWIUYHNBSHHCOPCMXZLLDCFGLKCGXTYTWLOWNGGBEOZECGZCTMVRMKMWYSHAAACPEILLEPOKDJZKGHCUZKWFBPDGRGBXYUCAEMESCABKAETFXHLFGSDFCDEPRIZVJNWPOCNBALVTJXZQHJFRWLVAVPMRFLZVJAFRZJKUKYJTJRSFXCLMINWSSUFWGZNUNZWLVLZJRIXVWYDDNXCVVZHCTPFTPLEOGAWXLLAAEQUWVJLZKYSXNDOTDJUMSDCABLVCKYWYLGBZGLXEWHRFBOJAIGCDWITRGFDUYFCNEXOKFCRJWRFUUKABRXDXIKBFWQVKIXFEEWUVFTNLKJSXNGNMFQDBSFGPYLBMUVKSMORJWGKGQFGASYIZENJITLEEJGNTTLVABVGSBYOQZJQBOOEEVRHVJHYEXIDYJKWUCNSDDSNTTOIBKDAECIXNYKPJNNGDTXJUBDCNYUUMJPSACOYPZXJCTHULSHQLOAJSQNVNOYGSHRFXYSWXIIJMKPTTLCKUVDWTLITJEJPTQQXAFZHMPCKCNKADEGFBSMMCYSQDFEDQLPUAPPAOAIAHVPIRFWIMTBUZVFNCOBQHIOUJADJQJGHTKLADBXUNTPJEVELRPZXEKXPCHTRKVHBNRJNXAXFHQNRPQZJKGBBJENGTAXGBOUCNEKGOAIKLXEAABOWLXRKPAJBSNVFGOOWOWPNYMKCWQNYRRBYVDXTGRELHZHRWXNKCOYXFCGAMXVZWGWEHQZXNLSENXXURQHXGJFVJMGNPUAJZQEWZWXPYROYCVPLRFBCMDRKXZVEFYWGSVLQAFABEPSOOFOLUBQSYXFDRMWNWWYKMGPWHCYNGAEFBDTKPZXZBMOCTSSAUVLIOVYXVUBPKWOYMEDFDSGGJYVSKLQUGCYSIUCGTBYNPMLSMTMEEIZUDHFQVXSLPEQDLWQFJUNPFAKVDRHJSYDJZFLHIRECPPZZFUGVGAJJXPXVECCLHJGTYITISTNHQGCMFWMDJILIIRHJOOUCMFXVWXNSOJTJHDCRDUNDHQWRTRCECBUALWWMWIQDQBCPFAUSRNNWLBLXSYXAQMEVEOEILOHVEZHNUXVATZVXIBXLTVCVTDYFPZGAJGSMVDHHDWJZAGSRCQHGSZAZDQRVARLPYCTAIEKGHDHXPQTTWGQSCVGOLAUQPLTCVNKANFOSTJIYFPRZXHFZSWYCMDADPYGMTZXICKQGQBNMMHETBDBCCUGYILYVHXVDJVZGLXJNCFUDUDWKKCBBWWFYAAJXAUSVUDPHMPTKHORGLRSBXFPDNMQMJSYCMZMXGQWNPXRWZJEAXRXMJVKVMLYWKMHWPPROVLNBTFXMGLSRNPPWZKHMUORZURRSCFNLUOFAJJVOEZWXOZZBMCKGWWCCXPIUNUPSMYSDSKKYJXFMDVAHODUXEHDNAVZALDXZMKEBBTFLRANQHDCUSXBCNTSLVOHOOUIPJFASOCGOGCMTEVOLRCLOSASVQPTDMQQGAXNSHOTPJMETQCJWXLKQATYGZMHRMROBLDWEOAQPVPNPHUJYSXLPFBRCFJKWZLFYAUQIRVRRBIBXMEHMRDFUKXUTYWMKKVAYFTKGGXOMLNDLEVBMECEKOYSISHGRANUDISOXFELKXCSZARTZAVLJXUZISWMSLKDRBDHBEKGYYYZZJKBSQLBRUXPSDMJFCZSLLYGXTBHYCCKAUUKLUASWFYYPYXYQMHEHIXJVQIHBLABNHINYLVUWZGUXVNQWNVPHGZEHVQCCFNTKEPVABVBXHKEIHHYAJTVBCAUGPWJBQIDEIHFKVLTHEBOMPAYSQMMAVCFCXTRUMIMRZLNAJNRWKRLDTGNLDEACNVOJYUZTCXREGPLPKXFEWPOCESGDPYRJYYZSPWTPALTNZMYAVZDBIAVWKWVBWRPLRSWDHOAWAEIFLXVCTWQXAJHTNYBOBXQGWAICLFLMEICSYMDSKSTJQLTQHELYJTUDUQLNCCVHTSXBWSGGGJXQPPZVUYMYOFSQGSFLMQNWERJORSTYZYJVVKTSDBILTGYMBGAECEOWSAZSHLHWDRAHNEGYEKBR";

            int qtyMax = 0;

            qtyMax = Math.Max(qtyMax, CommonChildRec(0, 0, s1, s2, 0, 0));

            Console.WriteLine(qtyMax);
        }

        //static void CommonChild()
        //{
        //    //string s1 = Console.ReadLine();
        //    //string s2 = Console.ReadLine();
        //    //string s1 = "ABCDEF";
        //    //string s2 = "FBDAMN";
        //    string s1 = "WEWOUCUIDGCGTRMEZEPXZFEJWISRSBBSYXAYDFEJJDLEBVHHKS";
        //    string s2 = "FDAGCXGKCTKWNECHMRXZWMLRYUCOCZHJRRJBOAJOQJZZVUYXIC";

        //    int qtyMax = 0; int qtyVector = 0; int qtyBase = 0;
        //    int pos = 0; int posS1 = 0; int posS2 = 0;

        //    int[] Recursive = new int[s2.Length * s2.Length];

        //    for (int i = 0; i < s2.Length; i++)
        //    {

        //        qtyBase = 0;
        //        posS1 = i;
        //        posS2 = i;
        //        while (posS1 < s1.Length && posS2 < s2.Length)
        //        {
        //            pos = s1.IndexOf(s2[posS2], posS1);
        //            if (pos == -1 && posS2 == i) break;
        //            else if (pos != -1)
        //            {
        //                qtyBase += 1;
        //                posS1 = pos + 1;
        //                posS2++;
        //            }
        //            else posS2++;
        //        }

        //        qtyMax = Math.Max(qtyMax, qtyBase);
        //    }

        //    Console.WriteLine(qtyMax);
        //}

        static void ReverseShuffleMerge()
        {

        }

        static void SherlockandAnagrams()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 1;

            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                int div = 1;
                for (int i = 0; i < s.Length; i++)
                {

                }
            }
        }

        static void TwoStrings()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 1;

            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                string f = Console.ReadLine();

                HashSet<char> p = new HashSet<char>(s);
                HashSet<char> m = new HashSet<char>(f);

                bool contains = false;

                foreach (var item in p)
                {
                    if (m.Contains(item)) { contains = true; break; }
                }

                if (contains) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }

        static void Anagram()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 1;

            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();

                if (s.Length % 2 != 0) { Console.WriteLine(-1); continue; }
                Dictionary<char, int> l = new Dictionary<char, int>();

                int half = s.Length / 2;
                for (int i = 0; i < half; i++)
                {
                    if (i < half)
                    {
                        if (l.ContainsKey(s[i])) l[s[i]]++;
                        else l.Add(s[i], 1);
                    }
                }

                int qtyDiff = 0;
                for (int j = half; j < s.Length; j++)
                {
                    if (l.ContainsKey(s[j]) && l[s[j]] > 0) l[s[j]]--;
                    else qtyDiff++;
                }

                Console.WriteLine(qtyDiff);
            }
        }

        static void MakeitAnagram()
        {
            string s = Console.ReadLine();
            string f = Console.ReadLine();
            //string s = "cdec";
            //string f = "abc";

            Dictionary<char, int> k = new Dictionary<char, int>();
            Dictionary<char, int> m = new Dictionary<char, int>();

            int qty = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (f.Contains(s[i]))
                {
                    if (k.ContainsKey(s[i])) k[s[i]]++;
                    else k.Add(s[i], 1);
                }
                else qty++;
            }

            for (int i = 0; i < f.Length; i++)
            {
                if (s.Contains(f[i]))
                {
                    if (m.ContainsKey(f[i])) m[f[i]]++;
                    else m.Add(f[i], 1);
                }
                else qty++;
            }

            foreach (var item in k)
            {
                if (m[item.Key] != item.Value)
                {
                    qty += Math.Abs(m[item.Key] - item.Value);
                }
            }

            Console.WriteLine(qty);
        }

        static void GemStones()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 2;
            //string first = "abcdde";
            string first = Console.ReadLine();
            HashSet<char> gema = new HashSet<char>(first);
            for (int a0 = 1; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                //string s = "eeabg";
                for (int i = gema.Count - 1; i >= 0; i--)
                {
                    char c = gema.ElementAt(i);
                    if (!s.Contains(c)) gema.Remove(c);
                }
                //for 


            }

            Console.WriteLine(gema.Count);
        }

        static void GameofThrones()
        {
            string s = Console.ReadLine(); int qtyEven = 0;
            Dictionary<char, int> anagram = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (anagram.ContainsKey(s[i])) anagram[s[i]]++;
                else anagram.Add(s[i], 1);
            }



            foreach (var j in anagram)
            {
                if (j.Value % 2 != 0) qtyEven++;
                if (qtyEven > 1) break;
            }

            if (qtyEven > 1) Console.WriteLine("NO");
            else if (s.Length % 2 == 0 && qtyEven == 0) Console.WriteLine("YES");
            else if (s.Length % 2 != 0 && qtyEven != 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }

        static void AlternatingCharacters()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                int qty = 0;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1]) qty++;
                }
                Console.WriteLine(qty);
            }
        }

        static void TheLoveLetterMystery()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            int t = 1;
            for (int a0 = 0; a0 < t; a0++)
            {
                //string s = Console.ReadLine();
                ////string s = "abc";
                string s = "aba";
                //string newString = s;
                //string normal = s; string reverse = "";
                int qty = 0; char c; char p; int i = 0; int j = 0;
                bool front;

                //normal = newString;
                //reverse = string.Join("", normal.Reverse());

                if (s.Length == 1) { Console.WriteLine(0); continue; }
                j = s.Length - 1;

                while (i < j)
                {
                    c = s[i];
                    p = s[j];

                    if (c > p) front = true;
                    else front = false;

                    char l = front ? c : p;
                    char m = front ? p : c;

                    qty += l - m;

                    //if (front) normal = normal.Substring(0, i) + m + normal.Substring(i + 1);
                    //else normal = normal.Substring(0, j) + m + normal.Substring(j + 1);

                    //if (front) reverse = reverse.Substring(0, i) + m + reverse.Substring(i + 1);
                    //else reverse = reverse.Substring(0, j) + m + reverse.Substring(j + 1);

                    //if (normal == reverse) { palindromo = true; }

                    i++;
                    j--;

                    //if (i <= 0 || i >= s.Length) break;
                }
                Console.WriteLine(qty);
            }
        }

        static void FunnyString()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 1;
            for (int a0 = 0; a0 < t; a0++)
            {
                string s = Console.ReadLine();
                // string s = "acxz";
                string r = string.Join("", s.Reverse());

                bool Funny = true;
                for (int i = 1; i < s.Length; i++)
                {
                    if (Math.Abs((Int32)s[i] - (Int32)s[i - 1]) != Math.Abs((Int32)r[i] - (Int32)r[i - 1])) { Funny = false; break; }
                }

                if (Funny) Console.WriteLine("Funny");
                else Console.WriteLine("Not Funny");
            }
        }

        static void pangram()
        {
            string s = Console.ReadLine();
            //string s = "We promptly judged antique ivory buckles for the next prize";
            HashSet<char> alfa = new HashSet<char>();
            foreach (char c in s.ToLower())
            {

                if (c != ' ' && !alfa.Contains(c)) alfa.Add(c);
                if (alfa.Count == 26) break;
            }

            if (alfa.Count == 26) Console.WriteLine("pangram");
            else Console.WriteLine("not pangram");
        }

        static void MatrixRotation()
        {
            string[] token = Console.ReadLine().Split(' ');
            int r = Convert.ToInt32(token[0]);

            int c = Convert.ToInt32(token[1]);
            int rotation = Convert.ToInt32(token[2]);

            int[,] tMatrix = new int[r, c];
            int[,] fMatrix = new int[r, c];
            for (int i_t = 0; i_t < r; i_t++)
            {
                string[] ch = Console.ReadLine().Split(' ');
                for (int c_I = 0; c_I < ch.Length; c_I++)
                {
                    tMatrix[i_t, c_I] = Convert.ToInt32(ch[c_I]);
                }
            }

            //int r = 5;
            //int c = 4;
            //int rotation = 7;
            //int[,] tMatrix = new int[r, c];
            //int[,] fMatrix = new int[r, c];

            //int i = 0;
            //string[] ch = "1 2 3 4".Split(' ');
            //for (int c_I = 0; c_I < ch.Length; c_I++)
            //{
            //    tMatrix[i, c_I] = Convert.ToInt32(ch[c_I]);
            //}
            //i = 1;
            //ch = "7 8 9 10".Split(' ');
            //for (int c_I = 0; c_I < ch.Length; c_I++)
            //{
            //    tMatrix[i, c_I] = Convert.ToInt32(ch[c_I]);
            //}
            //ch = "13 14 15 16".Split(' ');
            //i = 2;
            //for (int c_I = 0; c_I < ch.Length; c_I++)
            //{
            //    tMatrix[i, c_I] = Convert.ToInt32(ch[c_I]);
            //}
            //ch = "19 20 21 22".Split(' ');
            //i = 3;
            //for (int c_I = 0; c_I < ch.Length; c_I++)
            //{
            //    tMatrix[i, c_I] = Convert.ToInt32(ch[c_I]);
            //}
            //ch = "25 26 27 28".Split(' ');
            //i = 4;
            //for (int c_I = 0; c_I < ch.Length; c_I++)
            //{
            //    tMatrix[i, c_I] = Convert.ToInt32(ch[c_I]);
            //}

            int limitC; int limitR;
            int factor = 0;

            int min = Math.Min(r, c);

            while (min / (factor + 1) >= 2.0)
            {
                limitR = r - (factor * 2) - 1;
                limitC = c - (factor * 2) - 1;

                int rT = 0; int cT = 0;
                int rF; int cF = 0;
                int total = (limitR + 1) * 2 + (limitC + 1) * 2 - 4;

                int finalRotation = rotation;
                if (rotation > total) finalRotation = rotation % total;
                int abRotation;

                for (int finalPos = 0; finalPos < total; finalPos++)
                {
                    rT = finalPos;
                    if (rT > limitR) cT = finalPos - limitR;
                    if (rT > limitR) rT = limitR;
                    if (rT == limitR && cT > limitC) { rT -= finalPos - limitR - limitC; }
                    if (rT < 0 && cT > limitC) { rT = 0; cT = limitC; cT -= finalPos - limitR * 2 - limitC; }
                    else if (cT > limitC) cT = limitC;

                    abRotation = finalPos + finalRotation;
                    if (abRotation > total) abRotation = abRotation % total;
                    rF = abRotation;
                    if (rF > limitR) cF = abRotation - limitR;
                    if (rF > limitR) rF = limitR;
                    if (rF == limitR && cF > limitC) { rF -= abRotation - limitR - limitC; }
                    if (rF < 0 && cF > limitC) { rF = 0; cF = limitC; cF -= abRotation - limitR * 2 - limitC; }
                    else if (cF > limitC) cF = limitC;

                    fMatrix[factor + rF, factor + cF] = tMatrix[factor + rT, factor + cT];
                }
                factor++;
            }

            for (int d = 0; d < r; d++)
            {
                for (int p = 0; p < c; p++)
                {
                    Console.Write(fMatrix[d, p]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static void Encryption()
        {
            //string s = Console.ReadLine();
            //string s = "ifmanwasmeanttostayonthegroundgodwouldhavegivenusroots";
            //string s = "haveaniceday";
            string s = "chillout";
            int length = s.Length;
            int r = Convert.ToInt32(Math.Floor(Math.Sqrt(length)));
            int c = Convert.ToInt32(Math.Ceiling(Math.Sqrt(length)));

            if (r * c < length) r = c;

            string[] sentence = new string[c];

            int factor = 0;
            for (int i = 0; i < length; i++)
            {
                sentence[factor] += s[i];
                factor++;
                if (factor >= c) factor = 0;
            }

            Console.WriteLine(string.Join(" ", sentence));
        }


        static void ModifiedKaprekarNumbers()
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());

            //int p = 1;
            //int q = 100;
            double sqrt;
            int middle;
            string result = "";

            for (int i = p; i <= q; i++)
            {
                if (i == 1) result += i + " ";
                else
                {
                    sqrt = Math.Pow(i, 2);
                    if (sqrt.ToString("0").Length == 1) continue;
                    else if (sqrt.ToString("0").Length % 2 == 0) middle = sqrt.ToString("0").Length / 2;
                    else middle = sqrt.ToString("0").Length / 2;

                    if (i == Convert.ToInt32(sqrt.ToString("0").Substring(0, middle)) + Convert.ToInt32(sqrt.ToString("0").Substring(middle))) result += i + " ";
                }
            }

            if (result != "") Console.WriteLine(result);
            else Console.WriteLine("INVALID RANGE");
        }

        static void ExtraLongFactorials()
        {
            uint n = 77;
            decimal j = n;

            for (uint i = n - 1; i > 1; i--)
            {
                j *= i;
            }

            Console.WriteLine(j.ToString("0"));
        }

        static void TaumandBday()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            int t = 1;
            for (int a0 = 0; a0 < t; a0++)
            {
                //string[] tokens_b = Console.ReadLine().Split(' ');
                //int b = Convert.ToInt32(tokens_b[0]);
                int b = 11152;
                //int w = Convert.ToInt32(tokens_b[1]);
                int w = 43844;
                //string[] tokens_x = Console.ReadLine().Split(' ');
                //int x = Convert.ToInt32(tokens_x[0]);
                //int y = Convert.ToInt32(tokens_x[1]);
                //int z = Convert.ToInt32(tokens_x[2]);

                int x = 788543;
                int y = 223872;
                int z = 972572;

                Int64 min = 0; Int64 max = 0; Int64 fMin = 0; Int64 fMax = 0;
                Int64 result = 0;

                if (x <= y) { min = x; fMin = b; max = y; fMax = w; }
                else { min = y; fMin = w; max = x; fMax = b; }

                if (min + z < max) result = (fMin * min + fMax * min + fMax * z);
                else result = (fMin * min + fMax * max);

                Console.WriteLine(result);

            }
        }

        static void ACMICPCTeam()
        {
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int m = Convert.ToInt32(tokens_n[1]);
            int n = 4;
            int m = 5;
            string[] topic = new string[n];
            //for (int topic_i = 0; topic_i < n; topic_i++)
            //{
            //    topic[topic_i] = Console.ReadLine();
            //}

            topic[0] = "10101";
            topic[1] = "11100";
            topic[2] = "11010";
            topic[3] = "00101";


            int qtdTopics = 0;
            int maxTopics = 0;
            int qtdPerson = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int c = 0; c < m; c++)
                    {
                        if (topic[i][c] == '1' || topic[j][c] == '1') qtdTopics++;
                    }
                    if (qtdTopics > maxTopics)
                    {
                        maxTopics = qtdTopics;
                        qtdPerson = 1;
                    }
                    else if (qtdTopics == maxTopics) qtdPerson++;
                    qtdTopics = 0;
                }
            }
            Console.WriteLine(maxTopics);
            Console.WriteLine(qtdPerson);
        }

        static void LibraryFine()
        {
            string[] tokens_d1 = Console.ReadLine().Split(' ');
            int d1 = Convert.ToInt32(tokens_d1[0]);
            int m1 = Convert.ToInt32(tokens_d1[1]);
            int y1 = Convert.ToInt32(tokens_d1[2]);
            string[] tokens_d2 = Console.ReadLine().Split(' ');
            int d2 = Convert.ToInt32(tokens_d2[0]);
            int m2 = Convert.ToInt32(tokens_d2[1]);
            int y2 = Convert.ToInt32(tokens_d2[2]);

            DateTime date1 = new DateTime(y1, m1, d1);
            DateTime date2 = new DateTime(y2, m2, d2);

            if (date1 <= date2) Console.WriteLine(0);
            else if (date1.Month == date2.Month && date1.Year == date2.Year) Console.WriteLine((date1 - date2).Days * 15);
            else if (date1.Year == date2.Year)
            {
                int diffMonths = date1.Month - date2.Month;
                Console.WriteLine(diffMonths * 500);
            }
            else Console.WriteLine(10000);
        }

        static void ManasaandStones()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int t = 0; t < T; t++)
            {
                int stones = Convert.ToInt32(Console.ReadLine());
                int jump1 = Convert.ToInt32(Console.ReadLine());
                int jump2 = Convert.ToInt32(Console.ReadLine());

                int sum = 0;
                string results = "";
                int limit = stones;
                for (int i = 0; i < stones; i++)
                {
                    sum = 0;
                    for (int j = 1; j < stones; j++)
                    {
                        if (j < limit) sum += jump1;
                        else sum += jump2;
                    }
                    limit -= 1;
                    results += sum.ToString() + " ";
                }

                Console.WriteLine(results.TrimEnd());
            }
        }

        static void CavityMap()
        {
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int grid_i = 0; grid_i < n; grid_i++)
            //{
            //    grid[grid_i] = Console.ReadLine();
            //}

            int n = 4;
            string[] grid = new string[n];
            grid[0] = "1112";
            grid[1] = "1912";
            grid[2] = "1892";
            grid[3] = "1234";

            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    int p = grid[i][j];
                    if (grid[i - 1][j] == 'X' || grid[i - 1][j] >= p) continue;
                    else if (grid[i][j - 1] == 'X' || grid[i][j - 1] >= p) continue;
                    else if (grid[i][j + 1] == 'X' || grid[i][j + 1] >= p) continue;
                    else if (grid[i + 1][j] == 'X' || grid[i + 1][j] >= p) continue;
                    else grid[i] = grid[i].Substring(0, j) + "X" + grid[i].Substring(j + 1);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(grid[i]);
            }

        }

        static void MostDistant()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[m];

            for (int arrI = 0; arrI < m; arrI++)
            {
                arr[arrI] = Console.ReadLine();
            }
            //int m = 4;
            //string[] arr = new string[m];

            //arr[0] = "-1 0";
            //arr[1] = "1 0";
            //arr[2] = "0 1";
            //arr[3] = "-5 -1";

            float Max1 = 0;
            float Max2 = 0;

            for (int i = 0; i < m; i++)
            {
                float x = Convert.ToInt32(arr[i].Split(' ')[0]);
                float y = Convert.ToInt32(arr[i].Split(' ')[1]);

                float distance = 0;
                if (((x > 0) && (y < 0)) || ((x < 0) && (y > 0))) distance = Math.Abs(x) + Math.Abs(y);
                else distance = Math.Abs(x - y);

                if (distance > Max1) Max1 = distance;
                else if (distance > Max2) Max2 = distance;
            }

            Console.WriteLine((Max1 + Max2).ToString("0.000000000000"));
        }

        static void MrKmarsh()
        {
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int m = Convert.ToInt32(arr_temp[0]);
            //int n = Convert.ToInt32(arr_temp[0]);
            //string[] arr = new string[m];

            //for (int arrI = 0; arrI < m; m++)
            //{
            //    arr[arrI] = Console.ReadLine();
            //}

            int m = 4;
            int n = 5;

            string[] arr = new string[m];
            arr[0] = ".....";
            arr[1] = ".x.x.";
            arr[2] = ".....";
            arr[3] = ".....";

            int minX = m - 1;
            int minY = n - 1;
            int maxX = 0;
            int maxY = 0;

            int[] arrX = new int[m];
            int[] arrY = new int[n];

            int i = 0; int indexN = -1;
            while (i < m)
            {
                indexN = arr[i].IndexOf("X");
                if (indexN != -1)
                {
                    arrX[i] = 1;
                    arrY[indexN] = 1;

                    minX = Math.Min(i, minX);
                    maxX = Math.Max(i, maxX);
                }
                else
                {
                    i++;
                }
            }

            for (int Y = 0; Y < m; Y++)
            {
                if (arrY[Y] == 0) minY = Math.Min(Y, minY);
                if (arrY[Y] == 0) maxY = Math.Max(Y, maxY);
            }

            //if (maxY - minY < 2) 
        }

        static void TheGridSearch()
        {
            string[] linesInput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\thegridsearchinput.txt");
            string[] linesOutput = System.IO.File.ReadAllLines(@"C:\Users\fcampinho\Desktop\thegridsearchoutput.txt");
            int input = 0;

            int t = Convert.ToInt32(linesInput[input++]);
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_R = linesInput[input++].Split(' ');
                int R = Convert.ToInt32(tokens_R[0]);
                int C = Convert.ToInt32(tokens_R[1]);
                string[] G = new string[R];

                //G[0] = "123412";
                //G[1] = "561212";
                //G[2] = "123634";
                //G[3] = "781288";

                //G[0] = "7283455864";
                //G[1] = "6731158619";
                //G[2] = "8988242643";
                //G[3] = "3830589324";
                //G[4] = "2229505813";
                //G[5] = "5633845374";
                //G[6] = "6473530293";
                //G[7] = "7053106601";
                //G[8] = "0834282956";
                //G[9] = "4607924137";
                //for (int G_i = 0; G_i < R; G_i++)
                //{
                //    G[G_i] = Console.ReadLine();
                //}
                for (int G_i = 0; G_i < R; G_i++)
                {
                    G[G_i] = linesInput[input++];
                }
                string[] tokens_r = linesInput[input++].Split(' ');
                int r = Convert.ToInt32(tokens_r[0]);
                int c = Convert.ToInt32(tokens_r[1]);
                string[] P = new string[r];
                //P[0] = "9505";
                //P[1] = "3845";
                //P[2] = "3530";

                //P[0] = "12";
                //P[1] = "34";

                //for (int P_i = 0; P_i < r; P_i++)
                //{
                //    P[P_i] = Console.ReadLine();
                //}
                for (int P_i = 0; P_i < r; P_i++)
                {
                    P[P_i] = linesInput[input++];
                }

                bool bMatch = false;
                int rV = -1;
                int i = 0;
                while (i < R - r + 1)
                {
                    rV = G[i].IndexOf(P[0], rV + 1);
                    if (rV != -1)
                    {
                        for (int j = 1; j < r; j++)
                        {
                            if (G[i + j].Substring(rV, c) != P[j]) { bMatch = false; break; }
                            bMatch = true;
                        }
                    }
                    else
                    {
                        rV = -1;
                        i++;
                    }
                    if (bMatch) break;
                }

                if (bMatch) Console.WriteLine("YES");
                else Console.WriteLine("NO");

            }
        }

        static void ArraysDS()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] arr_temp = Console.ReadLine().Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] arr = new int[] { 1, 4, 3, 2 };

            Array.Reverse(arr);

            //arr.ToString()

            Console.WriteLine(string.Join(" ", arr));
        }

        static void CaesarCipher()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //string s = Console.ReadLine();
            //int k = Convert.ToInt32(Console.ReadLine());

            int n = 2;
            string s = "middle-Outz";
            int k = 11;

            int maxa = (int)'z';
            int maxA = (int)'Z';

            int val;
            int max;
            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                {
                    Console.Write(c);
                    continue;
                }
                if (char.IsUpper(c)) max = maxA;
                else max = maxa;

                val = (int)c + k;
                while (val > max)
                {
                    val -= 26;
                }
                Console.Write((char)val);
            }
        }

        static void ChocolateFeast()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int packages = 0; int changes = 0; int chocoRest = 0; int Chocolates = 0; int packRest = 0;
                Chocolates = n / c;
                packages = Chocolates;

                while (packages >= m)
                {
                    changes = packages / m;
                    Chocolates += changes;

                    packRest = packages % m;
                    packages = changes + packRest;
                }

                Console.WriteLine(Chocolates);
            }
        }
        static void Cutthesticks()
        {
            int n = 6;
            string[] arr_temp = "5 4 4 2 2 8".Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


            //HashSet<int> set = new HashSet<int>(arr);
            Console.WriteLine(arr.Length);

            while (arr.Length > 0)
            {
                int min = arr.Min();
                arr = arr.Select(i => i - min).Where(i => i > 0).ToArray<int>();
                if (arr.Length > 0) Console.WriteLine(arr.Length);
            }
        }

        static void ServiceLane()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int t = Convert.ToInt32(tokens_n[1]);
            string[] width_temp = Console.ReadLine().Split(' ');
            int[] width = Array.ConvertAll(width_temp, Int32.Parse);
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_i = Console.ReadLine().Split(' ');
                int i = Convert.ToInt32(tokens_i[0]);
                int j = Convert.ToInt32(tokens_i[1]);

                int min = width.Skip(i).Take(j - i + 1).Min();
                Console.WriteLine(min);
            }
        }

        static void SherlockandSquares()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            //int t = 1;
            for (int k = 0; k < t; k++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int min = Convert.ToInt32(tokens_n[0]);
                int max = Convert.ToInt32(tokens_n[1]);
                //int min = 89784519;
                //int max = 103811134;
                int count = 0;
                int squareMin = Convert.ToInt32(Math.Truncate(Math.Sqrt(min)));
                while (Math.Pow(squareMin, 2) <= max)
                {
                    if (Math.Pow(squareMin, 2) >= min) count++;
                    squareMin++;
                }
                Console.WriteLine(count);
            }
        }

        static void FindDigits()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int a0 = 0; a0 < t; a0++)
            //{
            int n = 1012;

            string step = n.ToString();
            int count = 0;
            foreach (char c in step)
            {
                if (c.ToString() != "0")
                    if (n % Convert.ToInt32(Convert.ToString(c)) == 0)
                    {
                        count++;
                    }
            }

            Console.WriteLine(count);
            //}
        }

        static void UtopianTree()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int H = 1; bool bSpring = true;
                for (int i = 0; i < n; i++)
                {
                    if (bSpring) H *= 2;
                    else H += 1;

                    bSpring = !bSpring;
                }
            }

        }

        static void Permutation()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int a0 = 0; a0 < t; a0++)
            //{
            //int n = Convert.ToInt32(Console.ReadLine());
            int n = 11;
            StringBuilder permutation = new StringBuilder();

            int pivot = n;
            while (pivot > 0)
            {
                if (pivot % 3 == 0)
                    break;
                else
                    pivot -= 5;
            }

            if (pivot < 0)
                Console.WriteLine(-1);
            else
            {
                int repeat = pivot / 3;
                while (repeat-- > 0)
                    permutation.Append("555");
                repeat = (n - pivot) / 5;
                while (repeat-- > 0)
                    permutation.Append("33333");
                Console.WriteLine(permutation.ToString());
            }
            //}
        }

        static void AngryProfessor()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                Array.Sort(a);
                int qtyBefore = 0;
                for (int i = 0; i < k && i < n; i++)
                {
                    if (a[i] <= 0) qtyBefore++;
                    if (a[i] > 0) break;
                }

                if (qtyBefore >= k) Console.WriteLine("NO");
                else Console.WriteLine("YES");
            }
        }

        static void TimeConversion()
        {
            //12:40:22AM

            string time = Console.ReadLine();
            string[] parts = time.Split(Convert.ToChar(":"));
            int factorHour = (parts[2].IndexOf("PM") != -1) ? 12 : 0;
            if (parts[0] == "12") parts[0] = "00";
            string hs24 = (Convert.ToInt32(parts[0]) + factorHour).ToString("00") + ":" + parts[1] + ":" + parts[2].Replace("AM", "").Replace("PM", "");

            Console.WriteLine(hs24);
        }

        static void StairCase()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new String(Convert.ToChar(" "), n - i - 1) + new String(Convert.ToChar("#"), i + 1));
            }

        }

        static void MinusPlus()
        {
            //int qtyPositive = 0; int qtyNegative = 0; int qtyZero = 0;
            //double qtyTotal = n;
            //for (int i = 0; i < n; i++)
            //{
            //    if (arr[i] > 0) qtyPositive++;
            //    else if (arr[i] < 0) qtyNegative++;
            //    else qtyZero++;
            //}

            //double resPositive = qtyPositive / qtyTotal;
            //Console.WriteLine(resPositive.ToString("0.000000"));
            //double resNegative = qtyNegative / qtyTotal;
            //Console.WriteLine(resNegative.ToString("0.000000"));
            //double resZero = qtyZero / qtyTotal;
            //Console.WriteLine(resZero.ToString("0.000000"));
        }

        static void DiagonalDifference()
        {
            string[] v = new string[] { "3", "11 2 4", "4 5 6", "10 8 -12" };

            int n = Convert.ToInt32(v[0]);
            int[][] a = new int[n][];
            int matrix1 = 0; int matrix2 = 0;
            int[] b;

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = v[a_i + 1].Split(' ');
                //a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                b = Array.ConvertAll(a_temp, Int32.Parse);

                matrix1 += b[a_i];
                matrix2 += b[b.Length - a_i - 1];
            }

            //matrix1 = a[0][0] + a[n / 2][a[n / 2].Length / 2] + a[n - 1][a[n - 1].Length - 1];
            //matrix2 = a[0][a[0].Length - 1] + a[n / 2][a[n / 2].Length / 2] + a[n - 1][0];

            Console.Write(Math.Abs(matrix1 - matrix2));
        }
    }
}
