using System;
using System.IO;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine("Засекаем время синхронного метода");
            Console.WriteLine(date1);
            InBin();
            OutBin();
            DateTime date2 = DateTime.Now;
            Console.WriteLine(date2);
            Console.WriteLine(date1.Subtract(date2));
           Console.WriteLine("Время выполнение синхронного метода");
            DateTime date3 = DateTime.Now;
            Console.WriteLine("Засекаем время выполнения асинхронного метода");
            Console.WriteLine(date3);
            AskInputBin();
            DateTime date4 = DateTime.Now;
            Console.WriteLine(date4);
            AskOutBin();
            Console.WriteLine(date3.Subtract(date4));
           Console.WriteLine("Время выполнение асинхронного метода");
            Console.WriteLine("Использование асинхронного метода ускоряет работу программы в 2-3 раза");
            Console.ReadLine();
        }
        static void InBin()
        {
            int[] massive = new int[1000];
            string file = "massibe.dat";
            Random x = new Random();
            for (int i = 0; i<1000; i++)
            {
                int r = x.Next(0, 100);
                massive[i] = r;
            }
            try
            {
                
                using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.OpenOrCreate)))
                {
                    foreach(int i in massive)
                    {
                        writer.Write(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Чета не робэ во вводи");
            }

        }
        static void OutBin()
        {
            string file = "massibe.dat";

            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
                {
                    // пока не достигнут конец файла
                    // считываем каждое значение из файла
                    while (reader.PeekChar() > -1)
                    {
                        int Inside = reader.ReadInt32();
                        Console.Write(Inside);
                        
                    }
                }
            }
            catch
            {
                Console.WriteLine("Чета неробэ");
            }
        }
        /*static async void ReadWriteAsync()
        {
            string s = "";
            int[] massive = new int[1000];
            string file = "massibe.dat";
            Random x = new Random();
           for (int i = 0; i < 1000; i++)
           {
                int r = x.Next(0, 100);
                massive[i] = r;
            }
            
            using (StreamWriter writer = new StreamWriter(file, false))
           {
                await writer.WriteLineAsync(s);  // асинхронная запись в файл
            }
           using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.OpenOrCreate)))
            {
                 foreach (int i in massive)
                {
                    s = s + massive[i];
                }
                 await writer.WriteAsync(s);
            }
            using (BinaryReader reader = new BinaryReader(file))
            {
                string result = await reader.ReadToEndAsync();  // асинхронное чтение из файла
                Console.WriteLine(result);
            }
        }*/
        static async void AskInputBin()
          {
            
          await Task.Run(() => InBin());
          

           }
          static async void AskOutBin()
         {
            
            await Task.Run(() => OutBin());
          
          }
    }
    
}
