using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue<int> aQueue = new Queue<int>();
            //aQueue.Enqueue(100);
            //aQueue.Enqueue(200);
            //aQueue.Enqueue(150);

            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());
            //Console.WriteLine(aQueue.Dequeue());

            //Console.ReadKey();

            Stack<int> numbers  = new Stack<int>();

            numbers.Push(50);
            numbers.Push(3);
            numbers.Push(4);

            throw new Exception();

            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Count);
            Console.ReadKey();



        }
    }
}
