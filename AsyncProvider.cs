using System;

namespace App
{
    public class SharedGateway
    {
        private int _state;

        public SharedGateway(int seed) => _state = seed;

        public int render(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 88) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedGateway(88);
            Console.WriteLine(obj.render(88));
        }
    }
}
