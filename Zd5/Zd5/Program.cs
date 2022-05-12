using Microsoft.Office.Interop.Excel;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Zd5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Введите интервал");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = await SumTh(a,b);
            await SummSec(a, b);
            await SummFr(a, b);
            Console.WriteLine(c);
            Console.ReadLine();
        }
        static int Summ(int a, int b)
        {
           
            int c = a - b;
            int rez = 0;
            for (int i = 1; i<c; i++)
            {
                rez = rez + i;
            }
            return rez;
           
        }
        static async Task SummFr(int a, int b)
        {
            int otvet = await Task.Run(() => Summ(a, b));
            Console.WriteLine(otvet);
        }
        static async Task<int> SummSec(int a,int b)
        {
            int otvet = await Task.Run(() => Summ(a, b));
            return otvet;
            Console.WriteLine(otvet);
        }
        static async Task<int> SumTh(int a, int b)
        {
            return await Task.Run(() => Summ(a,b));
        }
    }
}
