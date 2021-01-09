using System;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = { { 3, 6, 9 }, { 1, 2, 3 }, { 10, 30, 20 } };
            int biggestCollumnElem = 0;
            int[] biggestCollumnElems = new int[] { 0, 0, 0 };

            for(int i = 0; i < 3; i++)
            {   
                for(int j = 0; j < 3; j++)
                {
                    if(mas[i, j] > biggestCollumnElems[i])
                    {
                        biggestCollumnElems[j] = mas[i, j];
  
                    }
                }
            }

            foreach (int i in biggestCollumnElems) {
                biggestCollumnElem += i;
            }
            Console.WriteLine(biggestCollumnElems[1]);
            Console.WriteLine(biggestCollumnElem);
        }
    }
}
