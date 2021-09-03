using FluentScheduler;

namespace Duplicate_Encoder
{
    public class FluentSchedulerFactory : Registry
    {
        public FluentSchedulerFactory()
        {
            //讓Job進行單執行緒跑，避免沒跑完時的重復執行，(全域)
            NonReentrantAsDefault();
            //讓Job進行單執行緒跑，避免沒跑完時的重復執行，(單個任務)
            //Schedule<DataSyncJob>().NonReentrant().ToRunNow().AndEvery(5).Seconds();

            //立即執行每5秒一次的計劃任務，（指定一個時間間隔運行，根據自己需求，可以是秒、分、時、天、月、年等，）
            Schedule<DataSyncJob>().ToRunNow().AndEvery(5).Seconds();
            Schedule<TestJob>().ToRunNow().AndEvery(10).Seconds();

            //Schedule<TestJob>().ToRunNow().AndEvery(1).Seconds();

            ////立即執行一個每個月第一個星期一18：00的計劃任務
            //Schedule<DataSyncJob>().ToRunNow().AndEvery(1).Months().OnTheFirst(DayOfWeek.Monday).At(18, 0);

            ////延遲5秒執行的一次計劃任務，（指定一個時間間隔運行，根據自己需求，可以是秒、分、時、天、月、年等，）
            //Schedule<DataSyncJob>().ToRunOnceIn(5).Seconds();

            ////指定時間執行計劃任務（最常用，這里是在每天18：00執行，）
            //Schedule(() => Console.WriteLine("It's 18:00 now.")).ToRunEvery(1).Days().At(18, 0);

            ////在同一個計劃中執行多個任務
            //Schedule<DataSyncJob>().AndThen<TestJob>().ToRunNow().AndEvery(5).Seconds();
        }
    }
}
