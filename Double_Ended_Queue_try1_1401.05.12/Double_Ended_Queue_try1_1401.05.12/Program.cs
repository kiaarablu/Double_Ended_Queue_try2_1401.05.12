using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Ended_Queue_try1_1401._05._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleEndedQueue a = new DoubleEndedQueue(10);
            a.index1_enqueue(20);
            a.index1_enqueue(30);
            a.index2_enqueue(400);
            a.index2_enqueue(45);
            a.index2_enqueue(450);
            Console.WriteLine("-------------------------");
            a.print_array();
            Console.WriteLine("-------------------------");


            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_enqueue(500);
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index2_dequeue();
            a.index1_dequeue();
            a.index1_dequeue();
            a.index1_dequeue();
            a.index1_enqueue(500);
            a.index1_dequeue();
            a.index1_dequeue();
            a.index1_dequeue();
            a.index2_enqueue(800);
           

            Console.ReadKey();

        }
    }
}
