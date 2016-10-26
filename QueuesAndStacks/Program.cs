using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesAndStacks
{
    class Program
    {
        static void Main(String[] args)
        {
            Queue<String> mQ = new Queue<String>();
            mQ.Enqueue("Das");
            mQ.Enqueue("ist");
            mQ.Enqueue("eine");
            mQ.Enqueue("Queue");
            mQ.Enqueue(".");

            Console.WriteLine("Iterieren durch die Queue, Queue bleibt erhalten");
            foreach (var item in mQ)
            {
                Console.Write(item + $" ({mQ.Count}) ");
            }

            Console.WriteLine();
            Console.WriteLine("Iterieren durch die Queue, Queue wird abgearbeitet");
            while (0 < mQ.Count)
            {
                Console.Write(mQ.Dequeue() + $" ({mQ.Count}) ");
            }

            Stack<String> mS = new Stack<String>();
            mS.Push("Das");
            mS.Push("ist");
            mS.Push("ein");
            mS.Push("Stack");
            mS.Push(".");

            Console.WriteLine();
            Console.WriteLine(String.Empty.PadLeft(40, '#'));
            Console.WriteLine("Iterieren durch den Stack, Stack bleibt erhalten");
            foreach (var item in mS)
            {
                Console.Write(item + $" ({mS.Count}) ");
            }

            Console.WriteLine();
            Console.WriteLine("Iterieren durch den Stack, Stack wird abgearbeitet");
            while (0 < mS.Count)
            {
                Console.Write(mS.Pop() + $" ({mS.Count}) ");
            }
            
            Console.ReadLine();
       }
    }
}
