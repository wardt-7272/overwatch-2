using System;

namespace App
{
    public class LiteDispatcher
    {
        private int _state;

        public LiteDispatcher(int seed) => _state = seed;

        public int run(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 28) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new LiteDispatcher(28);
            Console.WriteLine(obj.run(28));
        }
    }
}
