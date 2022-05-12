using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Липатов Олег ИСП-341 задание 3");
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Console.WriteLine("Введите число иттераций");
            int itteration = Convert.ToInt32(Console.ReadLine());
            Task task1 = new Task(() => Func(itteration, token));
            task1.Start();

            Console.WriteLine("Введите y для отмены операции:");
            string s = Console.ReadLine();
            if (s == "y")
            {
                cancelTokenSource.Cancel();
            }
               
            
        }

        static void Func(int n, CancellationToken token)
        {

            double res = 1;
            for (int i = 1; i<n; i++)
            {
                res += Math.Pow(1 + 1 / i, i);
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана");
                    Console.WriteLine("Задача была завершена по токену");
                    Console.WriteLine(res);
                    return;
                }
               
                   

            }
            Console.WriteLine("Задача была завершена");
            Console.Write("Ответ:");
            Console.WriteLine(res);

        }
    }
}
