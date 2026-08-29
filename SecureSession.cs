using System;

namespace App
{
    public class LiteProvider
    {
        private int _state;

        public LiteProvider(int seed) => _state = seed;

        public int sync(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 69) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new LiteProvider(69);
            Console.WriteLine(obj.sync(69));
        }
    }
}
