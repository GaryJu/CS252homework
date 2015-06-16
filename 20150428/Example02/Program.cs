using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program  //如何限定一次只能輸入一個整數
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入四個整數中的第一個: ");
            int text1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第二個: ");
            int text2 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第三個: ");
            int text3 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第四個: ");
            int text4 = int.Parse(Console.ReadLine());

            string sum1 = (text1 * text2).ToString();
            string sum2 = (text3 + text4).ToString();

            Console.WriteLine("前兩個數加總是: {0}, 後兩個數加總是: {1}", sum1, sum2);
        }
    }
}