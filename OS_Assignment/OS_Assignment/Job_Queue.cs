using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS_Assignment
{
    public class Job_Queue 
    {
        public string name;
        public int arrivalTime;
        public int burstTime;
        public int priortyNumber;


        public Job_Queue() { }
        public void Job_Queue_priority(string n , int arr ,int burst ,int pri) {
            name = n;
            arrivalTime = arr;
            burstTime = burst;
            priortyNumber = pri; 
        }

        public void Job_Queue_non_priority(string n, int arr, int burst )
        {
            name = n;
            arrivalTime = arr;
            burstTime = burst;
        }

       
    }

}
