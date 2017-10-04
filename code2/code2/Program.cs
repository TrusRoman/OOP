using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            // типы пpимитивов
            sbyte a; a = -127;
            short b; b = -10000;
            int c; c = -54688445;
            long d; d = -369844552224478856;
            byte e; e = 254;
            ushort f; f = 10000;
            uint g; g = 54688454;
            ulong h; h = 369844552224478856;
            //char j; j = 'R'; 
            //bool k; k = true;
            float l; l = 1.52F;
            double m; m = 1.52525252;
            decimal n; n = 1.123456789123456789123456789M;
            //string s; s = "Roman";
            object o; o = 1;

            // неявное приведение
            f = e;
            b = a;
            c = b;
            d = g;
            m = l;

            // явное приведение
            m = (double)n;
            c = (int)g;
            h = (ulong)d;
            a = (sbyte)b;
            e = (byte)a;


            //упаковка и распаковка
            int pack = 111;
            object p = pack;
            byte dispack = (byte)(int)p;

            //неявно заданная переменная
            var ne = 123;
            int x = ne + pack;
            Console.Write(x);
            Console.Write("\n");

            //Nullable
            int? x1 = null;
            int? x2 = null;
            if (x1 == x2)
                Console.WriteLine("\n x1=x2=null");





            //2
            //строковые литералы и сравнение
            string str1 = "Roman";
            string str2 = "Roman";
            if (str1 == str2)
                Console.WriteLine("\n\n2.\nСтроки str1 и str2 равны\n");


            //операции над string
            string s1 = "компилятор будет считать данный код синтаксически корректным";
            string s2 = "полезность неявных преобразований типов";
            string s3 = "преобразовать результат вычисления выражения в указанный тип";
            Console.WriteLine(s1 + s2, "\n");//сцепление

            string s4 = String.Copy(s3);//copyriting

            string s5 = s1.Substring(0, 10);//подстрока
            Console.WriteLine(s5, "\n\n");

            string[] split = s3.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            foreach (string ss in split)
            {

                if (ss.Trim() != "")
                    Console.WriteLine(ss);
            }
            Console.WriteLine("\n\n");

            s2 = s2.Insert(0, "ABC");
            Console.WriteLine(s2, "\n\n");

            s2 = s2.Remove(0, 3);
            Console.WriteLine(s2, "\n\n");

            string Spust = "";
            string Snull = null;

            s2 = s2.Insert(0, Spust);//можно вызывать методы

            if (Snull != s1)
                Console.WriteLine("Null строки можно сравнивать\n\n");


            //StringBuilder
            StringBuilder sb = new StringBuilder("abcde", 20);
            sb = sb.Append(new char[] { 'f', 'g', 'h' });
            sb = sb.AppendFormat("igklmn {0} {1}", 'o', 'p');
            Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());
            Console.WriteLine("\n\n\n");




            //3
            //matrix
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0} ", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine("\n\n\n");


            //string array
            string[] srtM = new string[] { "First line", "Second line", "Thrird line" };
            int size = srtM.Length;
            foreach (var i in srtM)
            {
                Console.Write(i + "\n");
            }
            Console.WriteLine("\nSize of array - " + size);
            Console.WriteLine("\n");

            Console.Write("Number to change - ");
            System.Int32 num;
            num = Int32.Parse(Console.ReadLine());
            string newstr = "Changed line";
            srtM[num - 1] = newstr;
            foreach (var i in srtM)
            {
                Console.Write(i + "\n");
            }
            Console.WriteLine("\n\n\n");



            //jagged
            double[][] jag = new double[3][];
            jag[0] = new double[2];
            jag[1] = new double[3];
            jag[2] = new double[4];

            Console.WriteLine("Ступенчатый массив\n");
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 2; i++)
            { jag[0][i] = Double.Parse(Console.ReadLine()); }
            for (int i = 0; i < 3; i++)
            { jag[1][i] = Double.Parse(Console.ReadLine()); }
            for (int i = 0; i < 4; i++)
            { jag[2][i] = Double.Parse(Console.ReadLine()); }
            Console.WriteLine("Ступенчатый массив:");
            foreach (double[] i in jag)
            {
                foreach (double j in i)
                {
                    Console.Write("\t" + j);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n\n");




            //var
            var numb = 1234;
            var stroke = "varvar";
            Console.Write(numb + "\n");
            Console.Write(stroke);
            Console.WriteLine("\n\n\n");





            //4
            //a) Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
            (int first, string second, char third, string fourth, ulong fifth) tuple = (123456, "stroke", 'R', "stroke2", 123456789123456789);
            Console.WriteLine($"Kортеж {tuple}");
            Console.WriteLine(tuple.first + " " + tuple.third + " " + tuple.fourth);
            Console.WriteLine();


            var (one, two, three, four, five) = (tuple);




            //5
            int[] ar = { 2, 3, 8, 6, -1, 0, 6 };
            string s = "green";
            Console.WriteLine(fun(ar, s));
            (int, int, int, string) fun(int[] number, string name)
            {
                int max = 0, min = 0, sum = 0;
                for (int i = 0; i < 7; i++)
                {
                    if (max < number[i])
                    {
                        max = number[i];
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    if (min > ar[i])
                    {
                        min = ar[i];
                    }
                }
                for (int i = 0; i < 7; i++)
                {
                    sum += ar[i];
                }
                string b_1 = name.Substring(0, 1);
                return (max, min, sum, b_1);
            }
        }
    }
}
