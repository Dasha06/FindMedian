using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Median;

public class MedianFinder
{
    public List<int> nums = new List<int>();
    public static float FindMedian(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;
        if (n % 2 == 0)
        {
            return (nums[n / 2 - 1] + nums[n / 2]) / 2.0f;
        }
        else
        {
            return (float)nums[n / 2];
        }
    }

    public void AddNum(int num)
    {
        nums.Add(num);
    }
}

class Program
{
    static void Main(string[] args)
    {
        MedianFinder medianFinder = new MedianFinder();
        
        Console.WriteLine("Введите команды (MedianFinder/addNum/findMedian) через запятую:");
        string commandInput = Console.ReadLine();
        string[] commands = commandInput.Split(',').Select(c => c.Trim()).ToArray();

        Console.WriteLine("Введите параметры для каждой команды через запятую (пустое место для MedianFinder и findMedian, число для addNum):");
        string paramInput = Console.ReadLine();
        string[] paramStrings = paramInput.Split(',').Select(p => p.Trim()).ToArray();

        Console.Write("[");
        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == "MedianFinder")
            {
                Console.Write("null");
            }
            else if (commands[i] == "addNum")
            {
                int num = int.Parse(paramStrings[i]);
                medianFinder.AddNum(num);
                Console.Write("null");
            }
            else if (commands[i] == "findMedian")
            {
                float median = MedianFinder.FindMedian(medianFinder.nums.ToArray());
                Console.Write(median);
            }

            if (i < commands.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

    }
}


