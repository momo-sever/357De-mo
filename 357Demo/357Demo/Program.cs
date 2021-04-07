using System;

namespace _357Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 7 }; // 三行
            int i = 0; //游戏开始时 从第一行开始拿
            bool game = true; //true 玩家一 false 玩家二
            string user; //声明变量存储玩家名字
            int num; //玩家输入
            while (array[i] > 0 && i <= 2)//判断行里面的火柴是否取完和是否已经到最后一行
            {
                user = game == true ? "玩家一" : "玩家二";
                Console.WriteLine($"玩家{user}：请输入要拿取得火柴根数：");
                num = Convert.ToInt32(Console.ReadLine());//获取输入转成int
                while (num > array[i]) // 判断输入的值是否合法
                {
                    Console.WriteLine($"第{i}行只有{array[i]}根火柴，请重新输入：");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                array[i] -= num; //取走火柴
                game = !game; //切换玩家身份
                if (array[i] == 0) //是否取完本行
                {
                    if (i == 2) //是否是最后一行
                    {
                        Console.WriteLine($"{user}输了");
                        break;
                    }
                    i++;
                }
            }
            Console.ReadLine();
        }
    }
}
