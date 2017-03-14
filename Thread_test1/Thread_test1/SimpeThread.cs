using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_test1
{
  public  class SimpeThread
    {
        public void Thread_1()
        {
            int i = 5;
            int x = 10;
            int result = i * x;//原来的方法：+AppDomain.GetCurrentThreadId().ToString()
            for (int isp = 0; isp< 200; isp++)
            {
                Console.WriteLine("Primary id is " + isp.ToString());
            }
            Console.WriteLine("From the thread ID is:"+AppDomain.GetCurrentThreadId().ToString());
            Console.WriteLine("This code caculate the value " + result.ToString() + "from thread ID:" + Thread.CurrentThread.ManagedThreadId.ToString());
        }
    }
}
