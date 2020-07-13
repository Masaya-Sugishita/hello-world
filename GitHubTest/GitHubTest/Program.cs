using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("数字を二つ入力してください。");
            double[] num=new double[2];

            for (int i = 0; i < 2; i++)
            {
                num[i] = inputNumber(i+1);
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(num[0]+"+"+num[1]+"="+Add(num));
            Console.WriteLine(num[0] + "-" + num[1] + "=" + minus(num));
            Console.WriteLine("計算終了");
            Console.Read();
        }

        public static double inputNumber(int i)
        {
            string inputString;
            double input;

            while (true)
            {
                Console.Write(i+"番目の数字を入力してください：");
                inputString = Console.ReadLine();
                if(double.TryParse(inputString,out input))
                {
                    break;
                }
            }
            return input;
        }

        public static double Add(double[] num)
        {
            return num[0] + num[1];
        }

        public static double minus(double[] num)
        {
            return num[0] - num[1];
        }
    }
}
