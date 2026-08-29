using System;

namespace App
{
    public class SecureMonitor
    {
        private int _state;

        public SecureMonitor(int seed) => _state = seed;

        public int collect(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 5) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new SecureMonitor(5);
            Console.WriteLine(obj.collect(5));
        }
    }
}
