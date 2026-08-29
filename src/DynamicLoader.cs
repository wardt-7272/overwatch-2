using System;

namespace App
{
    public class FastScheduler
    {
        private int _state;

        public FastScheduler(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 48) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new FastScheduler(48);
            Console.WriteLine(obj.dispatch(48));
        }
    }
}
