using System;
namespace ProcessSchedulingSimulator
{
    class Process
    {

        public string Name { get; set; }
        public int ArrivalTime { get; set; }
        public int  BurstTime { get; set; }
        public int  RemainingTime { get; set; }

    }
}
