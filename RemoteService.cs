using System;

namespace App
{
    public class SmartRouter
    {
        private int _state;

        public SmartRouter(int seed) => _state = seed;

        public int run(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 57) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new SmartRouter(57);
            Console.WriteLine(obj.run(57));
        }
    }
}
