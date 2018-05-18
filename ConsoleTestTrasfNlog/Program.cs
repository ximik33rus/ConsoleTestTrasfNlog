using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using ConsoleApplication;

namespace ConsoleTestTrasfNlog
{
    class Program
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger(); ////+NLog

        static void Main(string[] args)
        {
        Console.WriteLine("Сечас начнем писать логи");
       // Log.Error("Трынь");
        Log.Info("Трынь");
        Log.Debug("Трынь");
        Log.Warn("Трынь");
        Console.WriteLine("Конец логам");
            ConsoleApplication.Program CA = new ConsoleApplication.Program();
            string app = CA.Run();
            Console.WriteLine(app);
            Console.ReadKey();
        }
    }
}
