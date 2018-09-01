using System;
using System.Collections;

namespace Iteration
{
    class CardValuesEnumerator : IEnumerator
    {
        private static string[] values = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        private int m_nCurr = -1;

        public CardValuesEnumerator() { }

        public object Current {
            get {
                if (m_nCurr < 0)
                    throw new InvalidOperationException("The enumerator is positioned before the first element. Use 'MoveNext' before calling 'Current'.");

                if (m_nCurr > 12)
                    throw new InvalidOperationException("The enumerator is positioned after the last element.");

                return values[m_nCurr];
            }
        }

        public bool MoveNext()
        {
            m_nCurr++;

            if (m_nCurr >= 13)
                return false;

            return true;
        }

        public void Reset()
        {
            m_nCurr = -1;
        }
    }
}
