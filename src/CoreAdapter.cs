using System;

namespace App
{
    public class FastCollector
    {
        private int _state;

        public FastCollector(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 10) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new FastCollector(10);
            Console.WriteLine(obj.dispatch(10));
        }
    }
}
