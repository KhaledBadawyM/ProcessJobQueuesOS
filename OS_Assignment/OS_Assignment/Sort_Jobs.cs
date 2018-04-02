using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Assignment
{
    public class Arrival_Sort : IComparer<Job_Queue>
    {
        public int Compare(Job_Queue x, Job_Queue y)
        {
            if (x.arrivalTime > y.arrivalTime)
                return 1;
            else if (x.arrivalTime < y.arrivalTime)
                return -1;
            else
                return 0;
        }
    }

    public class Short_Sort : IComparer<Job_Queue>
    {
        public int Compare(Job_Queue x, Job_Queue y)
        {
            if (x.burstTime > y.burstTime)
                return 1;
            else if (x.burstTime < y.burstTime)
                return -1;
            else
                return 0;
        }
    }

    public class Priority_Sort : IComparer<Job_Queue>
    {
        public int Compare(Job_Queue x, Job_Queue y)
        {
            if (x.priortyNumber > y.priortyNumber)
                return 1;
            else if (x.priortyNumber < y.priortyNumber)
                return -1;
            else
                return 0;
        }
    }

    public struct printedList
    {
        public string name;
        public int duration;
    }
}
