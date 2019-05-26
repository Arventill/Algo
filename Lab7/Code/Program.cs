using System;
using System.Diagnostics;

namespace Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            string[] lines_norm_10 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_10.txt");
            string[] lines_norm_20 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_20.txt");
            string[] lines_norm_30 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_30.txt");
            string[] lines_norm_50 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_50.txt");
            string[] lines_norm_75 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_75.txt");
            string[] lines_norm_100 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_100.txt");
            string[] lines_norm_200 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_200.txt");
            string[] lines_norm_300 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_300.txt");
            string[] lines_norm_400 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_400.txt");
            string[] lines_norm_500 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\norm_500.txt");

            string[] lines_pesim_10 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_10.txt");
            string[] lines_pesim_20 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_20.txt");
            string[] lines_pesim_30 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_30.txt");
            string[] lines_pesim_50 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_50.txt");
            string[] lines_pesim_75 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_75.txt");
            string[] lines_pesim_100 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_100.txt");
            string[] lines_pesim_200 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_200.txt");
            string[] lines_pesim_300 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_300.txt");
            string[] lines_pesim_400 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_400.txt");
            string[] lines_pesim_500 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\pesim_500.txt");

            string[] lines_optim_10 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_10.txt");
            string[] lines_optim_20 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_20.txt");
            string[] lines_optim_30 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_30.txt");
            string[] lines_optim_50 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_50.txt");
            string[] lines_optim_75 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_75.txt");
            string[] lines_optim_100 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_100.txt");
            string[] lines_optim_200 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_200.txt");
            string[] lines_optim_300 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_300.txt");
            string[] lines_optim_400 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_400.txt");
            string[] lines_optim_500 = System.IO.File.ReadAllLines(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\optim_500.txt");
            // ----------------------------------------------------------------------------------------------------------------------------------------------- \\
            int[] norm_10 = parse(lines_norm_10);
            int[] norm_20 = parse(lines_norm_20);
            int[] norm_30 = parse(lines_norm_30);
            int[] norm_50 = parse(lines_norm_50);
            int[] norm_75 = parse(lines_norm_75);
            int[] norm_100 = parse(lines_norm_100);
            int[] norm_200 = parse(lines_norm_200);
            int[] norm_300 = parse(lines_norm_300);
            int[] norm_400 = parse(lines_norm_400);
            int[] norm_500 = parse(lines_norm_500);

            int[] pesim_10 = parse(lines_pesim_10);
            int[] pesim_20 = parse(lines_pesim_20);
            int[] pesim_30 = parse(lines_pesim_30);
            int[] pesim_50 = parse(lines_pesim_50);
            int[] pesim_75 = parse(lines_pesim_75);
            int[] pesim_100 = parse(lines_pesim_100);
            int[] pesim_200 = parse(lines_pesim_200);
            int[] pesim_300 = parse(lines_pesim_300);
            int[] pesim_400 = parse(lines_pesim_400);
            int[] pesim_500 = parse(lines_pesim_500);

            int[] optim_10 = parse(lines_optim_10);
            int[] optim_20 = parse(lines_optim_20);
            int[] optim_30 = parse(lines_optim_30);
            int[] optim_50 = parse(lines_optim_50);
            int[] optim_75 = parse(lines_optim_75);
            int[] optim_100 = parse(lines_optim_100);
            int[] optim_200 = parse(lines_optim_200);
            int[] optim_300 = parse(lines_optim_300);
            int[] optim_400 = parse(lines_optim_400);
            int[] optim_500 = parse(lines_optim_500);
            // ----------------------------------------------------------------------------------------------------------------------------------------------- \\

            stopwatch.Start(); bubble_sort(ref norm_10, 10); stopwatch.Stop();
            string test1 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_20, 20); stopwatch.Stop();
            string test2 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_30, 30); stopwatch.Stop();
            string test3 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_50, 50); stopwatch.Stop();
            string test4 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_75, 75); stopwatch.Stop();
            string test5 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_100, 100); stopwatch.Stop();
            string test6 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_200, 200); stopwatch.Stop();
            string test7 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_300, 300); stopwatch.Stop();
            string test8 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_400, 400); stopwatch.Stop();
            string test9 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref norm_500, 500); stopwatch.Stop();
            string test10 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); bubble_sort(ref pesim_10, 10); stopwatch.Stop();
            string test11 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_20, 20); stopwatch.Stop();
            string test12 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_30, 30); stopwatch.Stop();
            string test13 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_50, 50); stopwatch.Stop();
            string test14 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_75, 75); stopwatch.Stop();
            string test15 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_100, 100); stopwatch.Stop();
            string test16 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_200, 200); stopwatch.Stop();
            string test17 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_300, 300); stopwatch.Stop();
            string test18 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_400, 400); stopwatch.Stop();
            string test19 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref pesim_500, 500); stopwatch.Stop();
            string test20 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); bubble_sort(ref optim_10, 10); stopwatch.Stop();
            string test21 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_20, 20); stopwatch.Stop();
            string test22 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_30, 30); stopwatch.Stop();
            string test23 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_50, 50); stopwatch.Stop();
            string test24 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_75, 75); stopwatch.Stop();
            string test25 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_100, 100); stopwatch.Stop();
            string test26 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_200, 200); stopwatch.Stop();
            string test27 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_300, 300); stopwatch.Stop();
            string test28 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_400, 400); stopwatch.Stop();
            string test29 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); bubble_sort(ref optim_500, 500); stopwatch.Stop();
            string test30 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            //*****************************\\
            stopwatch.Start(); insertion_sort(ref norm_10, 10); stopwatch.Stop();
            string test31 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_20, 20); stopwatch.Stop();
            string test32 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_30, 30); stopwatch.Stop();
            string test33 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_50, 50); stopwatch.Stop();
            string test34 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_75, 75); stopwatch.Stop();
            string test35 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_100, 100); stopwatch.Stop();
            string test36 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_200, 200); stopwatch.Stop();
            string test37 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_300, 300); stopwatch.Stop();
            string test38 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_400, 400); stopwatch.Stop();
            string test39 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref norm_500, 500); stopwatch.Stop();
            string test40 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); insertion_sort(ref pesim_10, 10); stopwatch.Stop();
            string test41 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_20, 20); stopwatch.Stop();
            string test42 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_30, 30); stopwatch.Stop();
            string test43 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_50, 50); stopwatch.Stop();
            string test44 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_75, 75); stopwatch.Stop();
            string test45 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_100, 100); stopwatch.Stop();
            string test46 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_200, 200); stopwatch.Stop();
            string test47 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_300, 300); stopwatch.Stop();
            string test48 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_400, 400); stopwatch.Stop();
            string test49 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref pesim_500, 500); stopwatch.Stop();
            string test50 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); insertion_sort(ref optim_10, 10); stopwatch.Stop();
            string test51 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_20, 20); stopwatch.Stop();
            string test52 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_30, 30); stopwatch.Stop();
            string test53 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_50, 50); stopwatch.Stop();
            string test54 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_75, 75); stopwatch.Stop();
            string test55 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_100, 100); stopwatch.Stop();
            string test56 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_200, 200); stopwatch.Stop();
            string test57 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_300, 300); stopwatch.Stop();
            string test58 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_400, 400); stopwatch.Stop();
            string test59 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); insertion_sort(ref optim_500, 500); stopwatch.Stop();
            string test60 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            //******************************\\
            stopwatch.Start(); selection_sort(ref norm_10, 10); stopwatch.Stop();
            string test61 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_20, 20); stopwatch.Stop();
            string test62 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_30, 30); stopwatch.Stop();
            string test63 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_50, 50); stopwatch.Stop();
            string test64 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_75, 75); stopwatch.Stop();
            string test65 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_100, 100); stopwatch.Stop();
            string test66 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_200, 200); stopwatch.Stop();
            string test67 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_300, 300); stopwatch.Stop();
            string test68 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_400, 400); stopwatch.Stop();
            string test69 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref norm_500, 500); stopwatch.Stop();
            string test70 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); selection_sort(ref pesim_10, 10); stopwatch.Stop();
            string test71 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_20, 20); stopwatch.Stop();
            string test72 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_30, 30); stopwatch.Stop();
            string test73 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_50, 50); stopwatch.Stop();
            string test74 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_75, 75); stopwatch.Stop();
            string test75 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_100, 100); stopwatch.Stop();
            string test76 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_200, 200); stopwatch.Stop();
            string test77 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_300, 300); stopwatch.Stop();
            string test78 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_400, 400); stopwatch.Stop();
            string test79 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref pesim_500, 500); stopwatch.Stop();
            string test80 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); selection_sort(ref optim_10, 10); stopwatch.Stop();
            string test81 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_20, 20); stopwatch.Stop();
            string test82 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_30, 30); stopwatch.Stop();
            string test83 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_50, 50); stopwatch.Stop();
            string test84 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_75, 75); stopwatch.Stop();
            string test85 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_100, 100); stopwatch.Stop();
            string test86 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_200, 200); stopwatch.Stop();
            string test87 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_300, 300); stopwatch.Stop();
            string test88 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_400, 400); stopwatch.Stop();
            string test89 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); selection_sort(ref optim_500, 500); stopwatch.Stop();
            string test90 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            //***********************************************\\
            stopwatch.Start(); quick_sort(ref norm_10, 0, 9); stopwatch.Stop();
            string test91 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_20, 0, 19); stopwatch.Stop();
            string test92 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_30, 0, 29); stopwatch.Stop();
            string test93 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_50, 0, 49); stopwatch.Stop();
            string test94 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_75, 0, 74); stopwatch.Stop();
            string test95 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_100, 0, 99); stopwatch.Stop();
            string test96 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_200, 0, 199); stopwatch.Stop();
            string test97 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_300, 0, 299); stopwatch.Stop();
            string test98 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_400, 0, 399); stopwatch.Stop();
            string test99 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref norm_500, 0, 499); stopwatch.Stop();
            string test100 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); quick_sort(ref pesim_10, 0, 9); stopwatch.Stop();
            string test101 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_20, 0, 19); stopwatch.Stop();
            string test102 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_30, 0, 29); stopwatch.Stop();
            string test103 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_50, 0, 49); stopwatch.Stop();
            string test104 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_75, 0, 74); stopwatch.Stop();
            string test105 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_100, 0, 99); stopwatch.Stop();
            string test106 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_200, 0, 199); stopwatch.Stop();
            string test107 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_300, 0, 299); stopwatch.Stop();
            string test108 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_400, 0, 399); stopwatch.Stop();
            string test109 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref pesim_500, 0, 499); stopwatch.Stop();
            string test110 = stopwatch.Elapsed.ToString(); stopwatch.Reset();

            stopwatch.Start(); quick_sort(ref optim_10, 0, 9); stopwatch.Stop();
            string test111 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_20, 0, 19); stopwatch.Stop();
            string test112 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_30, 0, 29); stopwatch.Stop();
            string test113 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_50, 0, 49); stopwatch.Stop();
            string test114 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_75, 0, 74); stopwatch.Stop();
            string test115 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_100, 0, 99); stopwatch.Stop();
            string test116 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_200, 0, 199); stopwatch.Stop();
            string test117 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_300, 0, 299); stopwatch.Stop();
            string test118 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_400, 0, 399); stopwatch.Stop();
            string test119 = stopwatch.Elapsed.ToString(); stopwatch.Reset();
            stopwatch.Start(); quick_sort(ref optim_500, 0, 499); stopwatch.Stop();
            string test120 = stopwatch.Elapsed.ToString(); stopwatch.Reset();


            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\times_norm.txt", true))
            {
                file.WriteLine("bubble:\n\n");
                file.WriteLine(test1 + '\n' + test2 + '\n' + test3 + '\n' + test4 + '\n' + test5 + '\n' + test6 + '\n' + test7 + '\n' + test8 + '\n' + test9 + '\n' + test10);
                file.WriteLine("\n\ninsertion:\n\n");
                file.WriteLine(test31 + '\n' + test32 + '\n' + test33 + '\n' + test34 + '\n' + test35 + '\n' + test36 + '\n' + test37 + '\n' + test38 + '\n' + test39 + '\n' + test40);
                file.WriteLine("\n\nselection:\n\n");
                file.WriteLine(test61 + '\n' + test62 + '\n' + test63 + '\n' + test64 + '\n' + test65 + '\n' + test66 + '\n' + test67 + '\n' + test68 + '\n' + test69 + '\n' + test70);
                file.WriteLine("\n===================================================\n");
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\times_pesim.txt", true))
            {
                file.WriteLine("bubble:\n\n");
                file.WriteLine(test11 + '\n' + test12 + '\n' + test13 + '\n' + test14 + '\n' + test15 + '\n' + test16 + '\n' + test17 + '\n' + test18 + '\n' + test19 + '\n' + test20);
                file.WriteLine("\n\ninsertion:\n\n");
                file.WriteLine(test31 + '\n' + test42 + '\n' + test43 + '\n' + test44 + '\n' + test45 + '\n' + test46 + '\n' + test47 + '\n' + test48 + '\n' + test49 + '\n' + test50);
                file.WriteLine("\n\nselection:\n\n");
                file.WriteLine(test71 + '\n' + test72 + '\n' + test73 + '\n' + test74 + '\n' + test75 + '\n' + test76 + '\n' + test77 + '\n' + test78 + '\n' + test79 + '\n' + test80);
                file.WriteLine("\n===================================================\n");
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\times_optim.txt", true))
            {
                file.WriteLine("bubble:\n\n");
                file.WriteLine(test21 + '\n' + test22 + '\n' + test23 + '\n' + test24 + '\n' + test25 + '\n' + test26 + '\n' + test27 + '\n' + test28 + '\n' + test29 + '\n' + test30);
                file.WriteLine("\n\ninsertion:\n\n");
                file.WriteLine(test51 + '\n' + test52 + '\n' + test53 + '\n' + test54 + '\n' + test55 + '\n' + test56 + '\n' + test57 + '\n' + test58 + '\n' + test59 + '\n' + test60);
                file.WriteLine("\n\nselection:\n\n");
                file.WriteLine(test81 + '\n' + test82 + '\n' + test83 + '\n' + test84 + '\n' + test85 + '\n' + test86 + '\n' + test87 + '\n' + test88 + '\n' + test89 + '\n' + test90);
                file.WriteLine("\n===================================================\n");
            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Filip\Desktop\CAT\programming\C#\Algo\Algo\times_all_quick.txt", true))
            {
                file.WriteLine("bubble:\n\n");
                file.WriteLine(test91 + '\n' + test92 + '\n' + test93 + '\n' + test94 + '\n' + test95 + '\n' + test96 + '\n' + test97 + '\n' + test98 + '\n' + test99 + '\n' + test100);
                file.WriteLine("\n\ninsertion:\n\n");
                file.WriteLine(test101 + '\n' + test102 + '\n' + test103 + '\n' + test104 + '\n' + test105 + '\n' + test106 + '\n' + test107 + '\n' + test108 + '\n' + test109 + '\n' + test110);
                file.WriteLine("\n\nselection:\n\n");
                file.WriteLine(test111 + '\n' + test112 + '\n' + test113 + '\n' + test114 + '\n' + test115 + '\n' + test116 + '\n' + test117 + '\n' + test118 + '\n' + test119 + '\n' + test120);
                file.WriteLine("\n===================================================\n");
            }
        }

        public static int[] parse(string[] origin)
        {
            int[] numbers = new int[origin.Length];
            for (int i = 0; i < origin.Length; i++)
                numbers[i] = Convert.ToInt32(origin[i]);

            return numbers;
        }

        public static string[] parse(int[] origin)
        {
            string[] numbers = new string[origin.Length];
            for (int i = 0; i < origin.Length; i++)
                numbers[i] = Convert.ToString(origin[i]);
            return numbers;
        }

        public static void bubble_sort(ref int[] t, int elements)
        {
            do
            {
                for (int i = 0; i < elements - 1; i++)
                {
                    if (t[i] > t[i + 1])
                    {
                        int tmp = t[i];
                        t[i] = t[i + 1];
                        t[i + 1] = tmp;
                    }
                }
                elements--;
            }
            while (elements > 1);
        }

        public static void insertion_sort(ref int[] t, int elements)
        {
            int i, j, v;
            for (i = 1; i < elements; i++)
            {
                j = i;
                v = t[i];
                while ((j > 0) && (t[j - 1] > v))
                {
                    t[j] = t[j - 1];
                    j--;
                }
                t[j] = v;
            }
        }

        public static void selection_sort(ref int[] t, int elements)
        {
            int counting = 0, mini, ch;
            for (int i = 0; i < elements; i++)
            {
                ch = i;
                mini = t[counting];
                for (var j = counting; j < elements; j++)
                {
                    if (t[j] < mini)
                    {
                        mini = t[j];
                        ch = j;
                    }
                }
                var tmp = t[counting];
                t[counting] = t[ch];
                t[ch] = tmp;
                counting++;
            }
        }

        public static void quick_sort(ref int[] t, int left, int right)
        {
            var i = left;
            var j = right;
            var pivot = t[(left + right) / 2];
            while (i < j)
            {
                while (t[i] < pivot) i++;
                while (t[j] > pivot) j--;
                if (i <= j)
                {
                    var tmp = t[i];
                    t[i++] = t[j];
                    t[j--] = tmp;
                }
            }
            if (left < j) quick_sort(ref t, left, j);
            if (i < right) quick_sort(ref t, i, right);
        }
    }
}
