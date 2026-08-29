using System;

namespace App
{
    public class AtomicMonitor
    {
        private int _state;

        public AtomicMonitor(int seed) => _state = seed;

        public int fetch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 68) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new AtomicMonitor(68);
            Console.WriteLine(obj.fetch(68));
        }
    }
}
