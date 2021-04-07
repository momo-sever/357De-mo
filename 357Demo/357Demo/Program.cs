using System;
using System.Linq;

namespace _357Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7 }; // 三行
            int[] sortArray; //排序后的
            bool game = true; //true 玩家一 false 玩家二
            string user; //声明变量存储玩家名字
            int num; //玩家输入
            int lint;//选择取出的行数
            while (true)//判断行里面的火柴是否取完和是否已经到最后一行
            {
                #region 粗略的显示 三行情况
                for (int ii = 0; ii < array.Length; ii++)
                {
                    for (int j = 0; j < array[ii]; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                #endregion
                user = game == true ? "一" : "二";
                Console.WriteLine($"玩家{user}：请输入要拿取得火柴行数：（1，2，3）");
                lint = Convert.ToInt32(Console.ReadLine()) - 1;//获取输入转成int
                while (lint > 3 || array[lint] == 0) // 判断输入的值是否合法
                {
                    Console.WriteLine($"只有三行或本行已经取完，请重新输入：");
                    lint = Convert.ToInt32(Console.ReadLine()) - 1;
                }
                Console.WriteLine($"玩家{user}：请输入要拿取得火柴数，第{lint + 1}行有{array[lint]}根火柴：");
                num = Convert.ToInt32(Console.ReadLine());//获取输入转成int
                while (num > array[lint]) // 判断输入的值是否合法
                {
                    Console.WriteLine($"只有{array[lint]}，请重新输入：");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                array[lint] -= num; //取走火柴
                game = !game; //切换玩家身份
                sortArray = array.OrderByDescending(n => n).ToArray(); //倒序排序
                if (sortArray[0] == 0)
                {
                    Console.WriteLine($"玩家{user}输了");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
