using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請問您的大名是: ");
            string name = Console.ReadLine();

            Console.WriteLine("{0} 您好 ~", name);

            Random random = new Random();
            int randonNumber = random.Next(0, 2);
            string gender = (randonNumber == 0) ? "女" : "男";

            Console.WriteLine("{0} 您好，我猜您一定是 {1}生 !", name, gender);

            Console.Write("請問您的性別是(男/女): ");
            string sex = Console.ReadLine();
            string resault = (sex == gender) ? "哈哈，我猜對了吧 !" : "哎呀，我猜錯了 !";
            Console.WriteLine(resault);
        }
    }
}