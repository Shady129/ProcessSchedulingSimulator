namespace ProcessSchedulingSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Scheduler scheduler = new Scheduler();


            scheduler.AllProcesses.Add(

                new Process

                {

                    Name = "P1",
                    ArrivalTime = 0,
                    BurstTime = 5,
                    RemainingTime = 5

                }
                );


        
            scheduler.AllProcesses.Add(

                new Process

                {

                    Name = "P2",
                    ArrivalTime = 1,
                    BurstTime = 3,
                    RemainingTime = 3

                }
                );



            scheduler.AllProcesses.Add(

                new Process

                {

                    Name = "P3",
                    ArrivalTime = 2,
                    BurstTime = 1,
                    RemainingTime = 1
                }

                );


            while (!scheduler.IsFinished())
            {

                scheduler.RunOneUnit();


            }


        }
    }
}
