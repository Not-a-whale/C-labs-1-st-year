using System;
using System.IO;
namespace SortApp
{
    class Program
    {



        static void Main(string[] args)
        {
            // ввод чисел
            int[] nums = new int[1];
            string insert = "";
            int[] numsFromFile = { };
            Console.WriteLine("Введите до 40 чисел от -20 до 20, или слово stop");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("{0}-е число: ", i + 1);
                insert = Console.ReadLine();
                if (insert != "stop")
                {

                    var number = Int32.Parse(insert);
                    if (number > 20 || number < -20)
                    {
                        Console.WriteLine("Число не входит в диапазон");
                        continue;
                    }
                    Array.Resize(ref nums, nums.Length + 1);
                    nums[nums.GetUpperBound(0)] = number;
                }
                else
                {
                    break;
                }
            }

            var notZeroNums = new int[0];
            var result = new int[0];
            foreach (var num in nums)
            {
                if (num == 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                }
                else
                {
                    Array.Resize(ref notZeroNums, notZeroNums.Length + 1);
                    notZeroNums[notZeroNums.GetUpperBound(0)] = num;
                }
            }

            Array.Sort(notZeroNums);
            foreach (var num in notZeroNums)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.GetUpperBound(0)] = num;
            }

            // вывод
            //Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < result.Length; i++)
            {
                //Console.WriteLine(result[i]);
                InputIntoFile(result[i]);
                Console.WriteLine(ReadFromFile());
            }
            Console.ReadLine();

        }

        static void InputIntoFile(int biggestElem)
        {
            FileInfo fi = new FileInfo("elem.txt");
            fi.Create();
            StreamWriter sw = new StreamWriter("../../../elem.txt");
            sw = fi.AppendText();
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