using System;

namespace App
{
    public class SharedResolver
    {
        private int _state;

        public SharedResolver(int seed) => _state = seed;

        public int run(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 50) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SharedResolver(50);
            Console.WriteLine(obj.run(50));
        }
    }
}
