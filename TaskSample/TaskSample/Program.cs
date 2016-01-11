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

            // First task. It is a bit slow task
           Task t1= Task.Run(() =>
            {
               
                while (i<=10)
                {
                    Console.WriteLine("Task 1 " + i++);
                    Task.Delay(1000); // Delay is set to 1 second. Delay is added to demonstrate the task is slow.
                }

            });

            // Second task. It is a long running task
           Task t2= Task.Run(() =>
            {
              
                while (j <= 50)
                {
                    Console.WriteLine("Task 2 " +j++);
                    Task.Delay(100); //Delay is set to 1/10 second. This makes the task faster than Task 1.
                }


            });

            t1.Wait(); // Makes the main thread to wait until the task 1 is completed.
            t2.Wait(); // Makes the main thread to wait until the task 2 is completed.

            // Prints the result of two tasks. This happens only after the two tasks are completed.
            Console.WriteLine("The output is i=>" + i + " j=> " + j);

            Console.Read();
        }
    }
}
