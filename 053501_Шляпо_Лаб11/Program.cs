using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using Proj1;
using Auto;
namespace _053501_Шляпо_Лаб11

{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Первое задание
            /*Int calc = new Int();
            calc.Result += calc.InfRes;
            Thread first = new Thread(new ThreadStart(calc.Integ));
            first.Priority = ThreadPriority.Highest;
            Thread second = new Thread(new ThreadStart(calc.Integ));
            second.Priority = ThreadPriority.Lowest;
            first.Start();
            second.Start();*/

            //Второе задание
            MemoryStream stream = new MemoryStream();
            StreamService service = new StreamService();
            var firstMethod = service.WriteToStream(stream);
            var secondMethod = service.CopyFromStream(stream, "fff.txt");
            //await Task.WhenAll(firstMethod, secondMethod);
            Task.WaitAll(firstMethod, secondMethod);
            Func<Autopark, bool> checking = Autopark.Checks;
            await service.GetStatisticsAsync("fff.txt", checking);


        }
    }
}