using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_test1
{
    public class User
    {
       public enum UserClass {
            ClassAdmin,
            ClassUser
        }
        public void AdminMethod() {
            Console.WriteLine("Admin Method has procceed!");
        }
        public void UserMethod() {
            Console.WriteLine("User Method has procceed!");
        }
        public void ExecuteFor(UserClass uc) {

            ThreadStart ts;
            //由于是静态的方法不需要实例化也可以进行访问
            ThreadStart tsAd = new ThreadStart(AdminMethod);
            ThreadStart tsUs = new ThreadStart(UserMethod);

            if (uc == UserClass.ClassAdmin)
            {
                ts = tsAd;
            }
            else {
                ts = tsUs;
            }

            Thread t = new Thread(ts);
            t.Start();
        }
    }
}
