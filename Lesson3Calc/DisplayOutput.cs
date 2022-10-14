using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson3Calc
{
    
    internal class DisplayOutput
    {
        static public Queue<double> queue = new Queue<double>();
        public double AddForList(double total)
        {
            var input = total;
            queue.Enqueue(input);
            if (queue.Count > 5)
            {
                queue.Dequeue();
            }
            return input;
        }
        public void DisplayHis()
        {
            Console.Write("Display the last 5 results?: ");
            var fiveElements = Convert.ToChar(Console.ReadLine());
            if (fiveElements == 'Y' || fiveElements == 'y')
            {
                //if (results.Length > 5)
                //{
                //    for (int i = results.Length - 5; i < results.Length - 1; i++)
                //    {
                //        Console.WriteLine($"Result {i + 1}: {results[i]}");
                //    }
                //}
                //else
                //{
                //    for (int i = 0; i < results.Length - 1; i++)
                //    {
                //        Console.WriteLine($"Result {i + 1}: {results[i]}");
                //    }
                //}

                int num = 0;
                foreach (var item in queue)
                {

                    ++num;
                    Console.WriteLine($"Result {num}:  {item}");
                }

            }
        }
    }
}
