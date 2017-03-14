using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_test1
{
    class ThreadState
    {
        public void WorkFunction() {
            string ThreadState;
            for (int i = 1; i < 100000; i++) {
                if (i % 5000 == 0) {
                    ThreadState = Thread.CurrentThread.ThreadState.ToString();
                    Console.WriteLine("Worker :"+ThreadState);
                }
            }
            Console.WriteLine("Worker function Completed!");
        }
    }
}
