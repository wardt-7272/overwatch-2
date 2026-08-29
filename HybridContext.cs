using System;

namespace App
{
    public class SharedRegistry
    {
        private int _state;

        public SharedRegistry(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 93) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SharedRegistry(93);
            Console.WriteLine(obj.dispatch(93));
        }
    }
}
