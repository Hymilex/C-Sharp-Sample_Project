using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread_test1
{
    public class Person
    {
        //成员变量
        private string name;
        private string id;
        //构造器
        public Person() {
            name = "Kitty";
            id = "0516";
        }

        public Person(string a_id,string a_name) {
            name = a_name;
            id = a_id;
        }
        //成员函数
        public void sports() {
            Console.WriteLine("There is a girl called "+name+" doing sports!");
        }

        public void Thread_person() {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine("Person id is " + i.ToString());
            }
            Console.WriteLine("There is a thread calling that called :"+AppDomain.GetCurrentThreadId().ToString());
        }
    }
}
