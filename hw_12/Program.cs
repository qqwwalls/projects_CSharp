using System.Diagnostics;

namespace hw_12
{
    class Program
    {
        static void Main()
        {
            RunTest(100000);
            RunTest(500000);
            RunTest(1000000);

            Console.ReadLine();
        }

        static void RunTest(int count)
        {
            Stopwatch stopwatch = new Stopwatch();

            using (MemoryAllocator allocator = new MemoryAllocator(count))
            {
                stopwatch.Start();
                allocator.AllocateMemory(count);
                stopwatch.Stop();

                Console.WriteLine("Objects: " + count);
                Console.WriteLine("Allocation time: " + stopwatch.ElapsedMilliseconds + " ms");
                Console.WriteLine("Generation before GC: " + allocator.GetGeneration());

                stopwatch.Restart();
                allocator.SimulateMemoryLoad();
                allocator.ForceGarbageCollection();
                stopwatch.Stop();

                Console.WriteLine("GC time: " + stopwatch.ElapsedMilliseconds + " ms");
                Console.WriteLine("Generation after GC: " + allocator.GetGeneration());
                Console.WriteLine();
            }
        }
    }
}
