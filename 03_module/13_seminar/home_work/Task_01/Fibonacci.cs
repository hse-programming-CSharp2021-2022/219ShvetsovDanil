using System.Collections;

namespace Task_01
{
    internal class Fibonacci
    {
        private int _current = 0;
        private int _next = 1;

        public IEnumerable GetNextMember(int limit)
        {
            for (var i = 0; i < limit; i++)
            {
                yield return _current;
                (_current, _next) = (_next, _current + _next);
            }
        }
    }
}