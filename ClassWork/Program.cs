namespace Toomakov_14._10._22
{
    internal class Program
    {

        static string Сounter(char[] arr)
        {
            char[] glas = "aeiouy".ToCharArray();
            char[] soglas = "bcdfghjklmnpqrstvwxyz".ToCharArray();
            int countglas = 0;
            int countsoglas = 0;

            foreach (char ch in arr)
            {
                foreach (char g in glas)
                {

                    if (ch == g)
                    {
                        countglas++;
                    }
                }
            }
            foreach (char ch in arr)
            {
                foreach (char g in soglas)
                {

                    if (ch == g)
                    {
                        countsoglas++;
                    }
                }
            }
            return "Количество гласных: " + Convert.ToString(countglas) + '\n' + "Количество согласных : " + Convert.ToString(countsoglas);


        }


        static int[,] Mat(int[,] array1, int[,] array2)
        {
            try
            {
                int len1_0 = array1.GetLength(0);  // число строк 1 матрицы
                int len1_1 = array1.GetLength(1);
                int len2_0 = array2.GetLength(0); // число строк
                int len2_1 = array2.GetLength(1);

                if (len1_1 == len2_0)
                {
                    int[,] new_matr = new int[len1_0, len2_1];

                    for (int i = 0; i < len1_0; i++)
                    {
                        for (int j = 0; j < len2_1; j++)
                        {
                            for (int k = 0; k < len1_1; k++)
                            {
                                new_matr[i, j] += array1[i, k] * array2[k, j];
                            }
                        }
                    }
                    return new_matr;
                }
                else
                {
                    Console.WriteLine("Количество столбцов первой матрицы не равно количеству строк второй!");
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
        static void PrintMat(int[,] new_matr, int[,] array1, int[,] array2)
        {
            for (int y = 0; y < Mat(array1, array2).GetLength(0); y++)
            {
                for (int x = 0; x < Mat(array1, array2).GetLength(1); x++)
                {
                    Console.Write(Mat(array1, array2)[y, x] + "\t");
                }
                Console.WriteLine();
            }



        }
        static int[] Temp(int[,] arr1)
        {
            int[] ints = new int[arr1.GetLength(0)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1) - 1; j++)
                {
                    ints[i] += arr1[i, j] + arr1[i, j + 1];
                }

            }
            return ints;
        }

        static string Simbols(List<char> list)
        {
            List<char> glas = new List<char>();
            string str_1 = ("aeiouy");
            foreach (char a in str_1)
            {
                glas.Add(a);
            }
            List<char> soglas = new List<char>();
            string str_2 = ("bcdfghjklmnpqrstvwxyz");
            foreach (char b in str_2)
            {
                soglas.Add(b);
            }
            int countglas = 0;
            int countsoglas = 0;

            foreach (char ch in list)
            {
                foreach (char g in glas)
                {

                    if (ch == g)
                    {
                        countglas++;
                    }
                }
            }
            foreach (char ch in list)
            {
                foreach (char g in soglas)
                {

                    if (ch == g)
                    {
                        countsoglas++;
                    }
                }
            }
            return "Количество гласных: " + Convert.ToString(countglas) + '\n' + "Количество согласных : " + Convert.ToString(countsoglas);


        }








        static void Main(string[] args)
        {

            Console.WriteLine("ДЗ.Задача 6.1");
            string str = "c:users\\admin\\github\\toomakov";
            char[] arr = str.ToCharArray();

            Console.WriteLine(Сounter(arr));


            Console.WriteLine("ДЗ.Задача 6.2");
            int[,] array1 = new int[,]
            {
                {1, 2, 3},
                {5, 6, 8},

            };
            int[,] array2 = new int[,]
            {
                {9, 2},
                {4, 7},
                {8, 4}

            };
            PrintMat(Mat(array1, array2), array1, array2);



            Console.WriteLine("ДЗ.Задача 6.3");

            int[,] arr1 = new int[12, 30];
            Random rand = new Random();

            for (int y = 0; y < arr1.GetLength(0); y++)
            {
                for (int x = 0; x < arr1.GetLength(1); x++)
                {
                    arr1[y, x] = rand.Next(-30, 30);

                }
            }
            for (int i = 0; i < Temp(arr1).Length; i++)
            {
                Console.WriteLine(Temp(arr1)[i]);
            }



            Console.WriteLine("ДЗ.Задача 6.1.1");
            List<char> list = new List<char>();
            string str1 = ("c:users\\admin\\github\\toomakov");
            foreach (char c in str1)
            {
                list.Add(c);
            }
            Console.WriteLine(Simbols(list));




            Console.WriteLine("ДЗ.Задача 6.1.2");
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 5, 6, 8 };

            List<List<int>> listOfLists = new List<List<int>>();
            listOfLists.Add(list1);
            listOfLists.Add(list2);

            List<int> list3 = new List<int>() { 9, 2, };
            List<int> list4 = new List<int>() { 4, 7, };
            List<int> list5 = new List<int>() { 8, 4, };

            List<List<int>> listOfLists1 = new List<List<int>>();
            listOfLists.Add(list3);
            listOfLists.Add(list4);
            listOfLists.Add(list5);