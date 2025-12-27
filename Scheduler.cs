using System;
using System.Collections.Generic;


namespace ProcessSchedulingSimulator
{
    class Scheduler
    {

        public int CurrentTime { get; set; }

        public List<Process> AllProcesses;
        public List<Process> ReadyQueue;
        public List<Process> CompletedProcesses;





        public Scheduler()
        {

           AllProcesses = new List<Process>();
           ReadyQueue = new List<Process>();
           CompletedProcesses = new List<Process>();

        }




        public Process SelectNextProcess()
        {
           
            if(ReadyQueue.Count == 0)
            {

                return null;
            }


            Process process = ReadyQueue[0];



            foreach (var item in ReadyQueue)
            {
                if(process.RemainingTime > item.RemainingTime)
                {

                    process = item;

                }
                
            }


            return process;

        }


        public void AddArrivedProcesses()
        {

            foreach (var item in AllProcesses)
            {
                if (item.ArrivalTime == CurrentTime)
                {
                   ReadyQueue.Add(item);

                }
            }
        }



        public void RunOneUnit()
        {
            Process currentProcess;


            AddArrivedProcesses();

            currentProcess =  SelectNextProcess(); 

            if(currentProcess == null)
            {

                CurrentTime++;
                return;

            }

            Console.WriteLine(CurrentTime);
            Console.WriteLine(currentProcess.Name);


            currentProcess.RemainingTime--;

            CurrentTime++;


            if(currentProcess.RemainingTime == 0)
            {

                ReadyQueue.Remove(currentProcess);
                CompletedProcesses.Add(currentProcess);
            }
        }



        public bool IsFinished()
        {


            if(CompletedProcesses.Count == AllProcesses.Count)
            {
                return true;
            }
            return false;

        }

    }
}
