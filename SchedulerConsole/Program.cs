using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSchedulerLog();
        }

        private static void WriteSchedulerLog()
        {
            var logFilePath = Path.GetFullPath(@"D:\ConsoleSchedulerDemo\")+ DateTime.Now.ToString("MM_dd_yyyy_HH_mm")+"_log.txt";
            try
            {
                if(!File.Exists(logFilePath))
                {
                    File.Create(logFilePath);
                }
            }
            catch (Exception ex)
            {

                var errorFilePath = @"D:\ConsoleSchedulerDemo";
                File.AppendAllText(errorFilePath, Environment.NewLine + ex.Message);
            }
        }
    }
}
