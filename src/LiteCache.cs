using System;

namespace App
{
    public class SmartCollector
    {
        private int _state;

        public SmartCollector(int seed) => _state = seed;

        public int handle(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 38) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SmartCollector(38);
            Console.WriteLine(obj.handle(38));
        }
    }
}
