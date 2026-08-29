using System;

namespace App
{
    public class HybridLoader
    {
        private int _state;

        public HybridLoader(int seed) => _state = seed;

        public int handle(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 7) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new HybridLoader(7);
            Console.WriteLine(obj.handle(7));
        }
    }
}
