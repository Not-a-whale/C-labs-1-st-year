using System;
namespace SortApp
{
    class Program
    {



        static void Main(string[] args)
        {
            // ввод чисел
            int[] nums = new int[1];
            string insert = "";
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
                }   else
                {
                    break;
                }
            }

            var notZeroNums = new int[0];
            var result = new int[0];
			foreach (var num in nums)
			{
                if(num == 0)
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
			Console.WriteLine("Вывод отсортированного массива");
			for (int i = 0; i < result.Length; i++)
			{
				Console.WriteLine(result[i]);
			}
			Console.ReadLine();

			//// сортировка
			//int temp;
			//int[] zerosArray = new int[0];
			//int[] finalArr = new int[0];
			//for (int i = 0; i < nums.Length - 1; i++)
			//{
			//    for (int j = i + 1; j < nums.Length; j++)
			//    {
			//        if(nums[i] == 0)
			//        {
			//            Array.Resize(ref zerosArray, zerosArray.Length + 1);
			//            //zerosArray[zerosArray.GetUpperBound(0)] = nums[i];
			//        } else if (nums[i] > nums[j])
			//        {
			//            temp = nums[i];
			//            nums[i] = nums[j];
			//            nums[j] = temp;
			//        }
			//    }
			//};
			//finalArr = new int[nums.Length];
			////zerosArray.CopyTo(finalArr, 0);
			//nums.CopyTo(finalArr, zerosArray.Length -1);
			//// вывод
			//Console.WriteLine("Вывод отсортированного массива");
			//for (int i = 0; i < finalArr.Length; i++)
			//{
			//    Console.WriteLine(finalArr[i]);
			//}
			//Console.ReadLine();
		}

    }
}