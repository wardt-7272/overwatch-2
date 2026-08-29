using System;

namespace App
{
    public class LocalCollector
    {
        private int _state;

        public LocalCollector(int seed) => _state = seed;

        public int decode(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 10) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LocalCollector(10);
            Console.WriteLine(obj.decode(10));
        }
    }
}
