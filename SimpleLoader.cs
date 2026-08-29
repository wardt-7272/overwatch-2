using System;

namespace App
{
    public class RemoteResolver
    {
        private int _state;

        public RemoteResolver(int seed) => _state = seed;

        public int handle(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 48) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new RemoteResolver(48);
            Console.WriteLine(obj.handle(48));
        }
    }
}
