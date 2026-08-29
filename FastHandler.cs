using System;

namespace App
{
    public class LocalContext
    {
        private int _state;

        public LocalContext(int seed) => _state = seed;

        public int sync(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 92) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new LocalContext(92);
            Console.WriteLine(obj.sync(92));
        }
    }
}
