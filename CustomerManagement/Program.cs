using System;
using TurboCollections;

namespace CustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var turboList = new TurboList<float>();
            var turboStack = new TurboStack<int>();
            turboStack.Push(4);
            turboStack.Push(5);
            turboStack.Push(6);
            Console.WriteLine(turboStack.Pop());
            Console.WriteLine(turboStack.Peek());
            
            Console.WriteLine(GC.GetTotalMemory(true));
        }
    }
}