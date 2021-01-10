using System;
using System.IO;

namespace Lab4_2
{
    class Program
    {
        static void Main()
        {
            int[,] mas = { { 3, 6, 9 }, { 1, 2, 3 }, { 10, 30, 20 } };
            int biggestCollumnElem = 0;
            int elemFromFile = 0;
            int[] biggestCollumnElems = new int[] { 0, 0, 0 };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (mas[i, j] > biggestCollumnElems[i])
                    {
                        biggestCollumnElems[j] = mas[i, j];

                    }
                }
            }

            foreach (int i in biggestCollumnElems)
            {
                biggestCollumnElem += i;
            }

            if (elemFromFile == 0)
            {
                InputIntoFile(biggestCollumnElem);
            }

            elemFromFile = ReadFromFile();

            Console.WriteLine("Сумма всех самых больших элементов столбцов данной матрицы равна: " + elemFromFile);
        }

        static void InputIntoFile(int biggestElem)
        {
            FileInfo fi = new FileInfo("elem.txt");
            fi.Create();
            StreamWriter sw = new StreamWriter("../../../elem.txt");
            sw.WriteLine(biggestElem);
            sw.Close();
        }

        static int ReadFromFile()
        {
            StreamReader streamReader = new StreamReader("../../../elem.txt");
            var str = "";
            if (File.Exists("../../../elem.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    str += streamReader.ReadLine();
                }
                int highest = Convert.ToInt32(str);
                return highest;
            }
            else
            {
                return 0;
            }

        }
    }
}
