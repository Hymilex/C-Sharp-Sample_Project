using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_test1
{
    class Program
    {
        /// <summary>
        /// 线程的属性和方法
        /// Sleep()方法和IsAlive属性
        /// 线程可以睡眠一段时间的，直到发生时钟中断为止。
        /// 使用线程睡眠，只需要静态方法Sleep即可。
        /// 将使用IsAlive判断线程是否执行完毕
        /// 
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            /*
            Person ps = new Person();
            ThreadStart p = new ThreadStart(ps.sports);
            ThreadStart p2 = new ThreadStart(ps.Thread_person);
            Thread p1 = new Thread(p);
            for (int i = 0; i < 200; i ++) {
                Console.WriteLine("Primary id is "+i.ToString());
            }
            Thread p3 = new Thread(p2);

            p1.Start();
            p3.Start();
            */
            string st;
            ThreadState ww = new ThreadState();
           
            Thread t = new Thread(new ThreadStart(ww.WorkFunction));

            t.Start();

            while (t.IsAlive) {
                ThreadState pp = new ThreadState();
                Thread t2 = new Thread(new ThreadStart(pp.WorkFunction));
                t2.Start();
                if (t2.IsAlive) {
                    Console.WriteLine("Please wait a min...");
                    Thread.Sleep(5000);
                }
                Console.WriteLine("still wating...");
                Thread.Sleep(200);
            }

            st = t.ThreadState.ToString();
            Console.WriteLine("He's finally done!Thread static is :"+st);
            /*
            User c = new User();
            c.ExecuteFor(User.UserClass.ClassAdmin);
            */
            Console.ReadLine();
        }
    }
}
