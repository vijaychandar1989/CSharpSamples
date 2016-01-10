using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0, j = 0;
           Task t1= Task.Run(() =>
            {
               
                while (i<=10)
                {
                    Console.WriteLine("Thread 1 " + i++);
                    Task.Delay(1000);
                }

            });
           Task t2= Task.Run(() =>
            {
              
                while (j <= 50)
                {
                    Console.WriteLine("Thread 2 " +j++);
                    Task.Delay(100);
                }


            });

            t1.Wait();
            t2.Wait();
            Console.WriteLine("The output is i=>" + i + " j=> " + j);

            Console.Read();
        }
    }
}
