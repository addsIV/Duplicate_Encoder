using FluentScheduler;
using System.Threading;
using System.Timers;

namespace Duplicate_Encoder
{
    public class polling//輪詢
    {
        public void Run()
        {
            var aThread = new Thread(TaskLoop);
            aThread.IsBackground = true;
            aThread.Priority = ThreadPriority.BelowNormal;  // 避免此背景工作拖慢 ASP.NET 處理 HTTP 請求.
            aThread.Start();
        }

        private void TaskLoop()
        {
            JobManager.Initialize(new FluentSchedulerFactory());
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Enabled = true;
            //timer.Interval = 1000;
            //timer.Start();
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(test);

            //var stopFlag = Console.ReadKey();
            //if (stopFlag.Key == ConsoleKey.Enter) JobManager.Stop();
        }
        private static void test(object source, ElapsedEventArgs e)
        {
            JobManager.Initialize(new FluentSchedulerFactory());
        }

        private static void stop(object source, ElapsedEventArgs e)
        {
            JobManager.Stop();
        }
    }
}
