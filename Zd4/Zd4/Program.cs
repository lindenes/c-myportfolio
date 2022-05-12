using System;
using System.Threading;
using System.Threading.Tasks;

namespace Zd4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Липатов ИСП-341 ЗАДАНИЕ 5");
            Console.WriteLine("Введите количество иттераций");
            int x = Convert.ToInt32(Console.ReadLine());
            SumAsync();
            Itteration(x);
            Console.ReadLine();
        }
        static void Sum()
        {
             Random first = new Random();
            Random second = new Random();
            int repeat = 0;
            int i = 0;
            while (i < 54982){
                int f = first.Next(100,500);
                int s = second.Next(100, 500);
                i += f + s;
                repeat = repeat + 1;
                Console.WriteLine(i);
            }
            Console.WriteLine(i);
            Console.WriteLine("Повторений:"+repeat);

            
        }
        static async void SumAsync()
        {
            await Task.Run(() => Sum());
            

        }
        static void Itteration(int x)
        {
            double summ = 0;
            for (int i = 0; i<x; i++)
            {
                summ = Math.Pow(1 + 1 / x, x);
            }
            Console.WriteLine("Сумма равна:"+summ);
        }
    }
}
