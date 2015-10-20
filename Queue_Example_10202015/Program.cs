//Joshua Pickenpaugh, IN2017
//October 20th, 2015
//Queue example

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Queue_Example_10202015
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue1 = new Queue();
            queue1.Enqueue(1);
            queue1.Enqueue(3);
            queue1.Enqueue(5);
            queue1.Enqueue(7);
            queue1.Enqueue(9);

            QueueMethod(queue1);

            Console.ReadKey();
        }

        static void QueueMethod(Queue methQueue)
        {
            while (methQueue.Count > 0)
            {
                Console.WriteLine("Now serving customer number: ");
                Console.WriteLine(methQueue.Dequeue());
            }
        }
        
    }
}

