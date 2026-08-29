using System;

namespace App
{
    public class DynamicResolver
    {
        private int _state;

        public DynamicResolver(int seed) => _state = seed;

        public int run(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 61) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new DynamicResolver(61);
            Console.WriteLine(obj.run(61));
        }
    }
}
