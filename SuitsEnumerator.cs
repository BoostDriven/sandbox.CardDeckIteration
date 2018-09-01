using System;
using System.Collections;

namespace Iteration
{
    internal class SuitsEnumerator : IEnumerator
    {
        private static string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };

        private int m_nCurr = -1;

        public SuitsEnumerator()
        {
        }

        public object Current
        {
            get
            {
                if (m_nCurr < 0)
                    throw new InvalidOperationException("The enumerator is positioned before the first element. Use 'MoveNext' before calling 'Current'.");

                if (m_nCurr > 3)
                    throw new InvalidOperationException("The enumerator is positioned after the last element.");

                return suits[m_nCurr];
            }
        }

        public bool MoveNext()
        {
            m_nCurr++;

            if (m_nCurr >= 4)
                return false;

            return true;
        }

        public void Reset()
        {
            m_nCurr = -1;
        }
    }
}