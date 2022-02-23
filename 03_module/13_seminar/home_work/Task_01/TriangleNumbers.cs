using System.Collections;

namespace Task_01
{
    internal class TriangleNumbers
    {
        private double _current;

        public IEnumerable GetNextMember(int limit)
        {
            for (var i = 0; i < limit; i++)
            {
                yield return 1 / 2.0 * _current * (_current + 1);
                _current++;
            }
        }
    }
}