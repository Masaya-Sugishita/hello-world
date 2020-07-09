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
            int[] num=new int[2];

            for (int i = 0; i < 2; i++)
            {
                num[i] = inputNumber(i+1);
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(num[0]+"+"+num[1]+"="+Add(num));
            Console.Read();
            
        }

        public static int inputNumber(int i)
        {
            string inputString;
            int input;

            while (true)
            {
                Console.Write(i+"番目の数字を入力してください：");
                inputString = Console.ReadLine();
                if(int.TryParse(inputString,out input))
                {
                    break;
                }
            }
            return input;
        }

        public static int Add(int[] num)
        {
            return num[0] + num[1];
        }
    }
}
