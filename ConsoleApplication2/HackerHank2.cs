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
            GreedyFlorist();
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
            //string nk = Console.ReadLine();
            string nk = "1007 379";

            int n = Convert.ToInt32(nk.Split(' ')[0]);
            int k = Convert.ToInt32(nk.Split(' ')[1]);

            //string[] sArr = Console.ReadLine().Split(' ');
            string[] sArr = "349 727 558 935 872 559 445 104 398 810 198 752 957 650 366 512 590 178 326 435 678 967 721 399 34 833 369 770 910 232 586 660 448 763 587 226 1002 354 76 732 348 33 621 905 911 612 257 438 143 778 734 312 361 838 906 328 821 137 855 999 191 486 108 377 786 978 713 947 272 241 524 439 958 811 412 758 494 739 983 141 16 908 169 9 875 183 740 523 157 938 741 639 670 661 207 652 859 846 432 729 459 277 789 551 22 60 11 431 129 484 982 172 996 804 334 420 757 536 940 301 390 229 1003 173 992 861 581 14 538 753 248 55 793 897 308 871 580 698 874 796 352 500 61 689 623 131 922 909 228 880 443 115 246 980 418 27 213 423 32 238 243 67 17 513 636 396 792 618 797 554 790 239 771 15 589 890 375 333 779 952 936 166 945 278 719 44 247 77 360 762 615 394 510 640 529 610 123 46 365 912 307 561 948 916 785 525 184 695 102 59 408 781 168 562 805 468 437 534 95 1 814 893 217 711 355 441 194 768 91 831 474 820 495 195 148 296 932 915 991 541 234 622 583 364 10 86 997 823 426 571 780 926 955 472 799 647 120 572 90 30 294 885 105 250 937 690 465 725 222 707 876 504 63 319 395 754 668 20 415 158 743 359 576 619 645 683 140 3 655 949 49 682 815 298 188 611 962 628 64 19 965 436 461 93 888 664 473 492 954 728 101 548 231 987 862 51 383 994 393 236 434 800 130 624 976 253 273 748 416 973 891 543 88 268 653 663 489 547 245 836 322 601 716 112 452 18 854 730 233 340 471 550 671 560 8 219 1001 372 617 293 260 594 206 941 521 491 29 697 858 477 275 424 68 147 154 896 497 956 124 162 509 182 164 988 970 573 717 478 24 313 733 337 193 886 931 100 505 629 176 37 626 290 852 344 215 708 5 853 113 600 508 819 276 404 631 125 520 950 969 866 903 303 179 1005 765 357 518 142 170 103 286 975 306 693 860 107 316 252 218 993 921 421 400 598 656 397 575 566 480 553 900 291 704 227 84 986 901 47 225 106 555 411 457 531 803 111 31 775 714 244 209 186 568 777 666 565 214 849 506 832 456 784 73 185 483 127 444 80 614 742 427 446 43 972 638 314 150 692 981 767 873 680 706 700 388 806 451 679 837 989 161 677 696 409 816 746 66 45 599 235 850 406 817 569 342 336 735 540 7 788 818 929 822 607 284 136 705 517 923 242 160 382 305 300 118 637 863 635 181 288 159 481 772 53 402 920 979 163 597 644 254 783 363 42 335 128 110 712 39 687 467 212 210 879 470 609 50 450 292 528 310 673 281 447 942 659 356 279 58 385 304 809 325 824 167 343 925 549 625 2 48 761 12 223 197 35 544 422 535 449 466 527 381 425 479 899 70 766 200 960 21 867 632 699 146 324 83 998 944 330 175 413 367 522 205 902 320 259 496 347 633 578 345 458 26 72 256 501 882 984 834 643 384 868 138 177 97 769 410 953 488 152 338 674 825 23 180 487 499 89 41 460 648 78 428 211 317 826 702 894 358 747 485 13 287 165 968 430 726 156 28 688 464 266 264 927 595 263 514 722 453 414 556 760 378 907 675 737 85 332 606 913 262 196 878 977 943 36 6 417 808 389 469 387 269 403 620 56 321 1000 964 237 736 844 691 608 889 373 764 96 654 759 546 658 577 407 493 951 718 613 331 685 933 795 503 723 65 199 476 802 187 401 270 963 813 990 285 710 40 928 329 463 829 94 69 684 339 604 315 327 99 38 346 715 592 299 530 309 274 914 149 616 709 971 475 563 376 75 240 507 341 139 588 570 904 109 848 297 498 934 812 81 720 669 646 114 190 133 870 482 280 282 582 135 92 271 516 827 946 440 515 985 220 283 634 841 261 842 869 258 843 959 856 62 429 865 533 845 642 362 405 52 883 370 898 651 745 353 4 828 208 379 230 596 605 864 585 731 455 857 924 995 323 87 433 121 82 442 249 567 526 676 657 724 79 574 839 667 627 801 961 368 791 189 203 807 892 974 54 391 267 751 782 116 557 119 454 774 539 174 694 881 204 151 930 649 798 750 545 918 251 835 1006 532 877 318 1004 919 895 564 144 662 71 126 371 749 686 511 351 311 552 289 302 773 74 155 201 117 830 419 542 738 672 221 776 122 1007 224 579 787 380 847 295 25 755 641 374 134 98 681 255 917 701 939 502 192 703 593 537 744 202 851 840 630 57 665 132 794 153 171 756 884 966 265 350 887 145 519 392 386 490 591 216 584 603 462 602".Split(' ');
            int[] arr = new int[n];
            int[] arrS = new int[n];
            Dictionary<int, int> pos = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(sArr[i]);
                pos.Add(arr[i], i);
            }
            arr.CopyTo(arrS, 0);
            Array.Sort(arrS);
            Array.Reverse(arrS);

            int cPerm = 0;
            for (int j = 0; j < k; j++)
            {
                for (int i = cPerm; i < n; i++)
                {
                    int temp; int pTemp;
                    if (arr[i] < arrS[i])
                    {
                        temp = arr[i];
                        pTemp = pos[arrS[i]];
                        arr[i] = arrS[i];
                        arr[pos[arrS[i]]] = temp;
                        pos[arr[i]] = i;
                        pos[temp] = pTemp;

                        cPerm = i + 1;
                        break;
                    }
                }
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