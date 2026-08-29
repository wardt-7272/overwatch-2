using System;

namespace App
{
    public class AtomicFactory
    {
        private int _state;

        public AtomicFactory(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 56) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new AtomicFactory(56);
            Console.WriteLine(obj.dispatch(56));
        }
    }
}
