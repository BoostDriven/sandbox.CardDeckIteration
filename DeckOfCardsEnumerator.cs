using System;
using System.Collections;

namespace Iteration
{
    /// <summary>
    /// As this class simply enumerates over all the possible cards
    /// in a deck of cards, no data about cards is stored here, however
    /// this class does reference two other enumerators, the suitsEnumerator
    /// and the cardValueEnumerator.
    /// </summary>
    class DeckOfCardsEnumerator : IEnumerator
    {
        private SuitsEnumerator m_suits = new SuitsEnumerator();
        private CardValuesEnumerator m_values = new CardValuesEnumerator();

        public DeckOfCardsEnumerator() {
            m_suits.MoveNext();
        }

        public object Current
        {
            get {

                return String.Format("{0} of {1}", m_values.Current, m_suits.Current);
            }
        }

        public bool MoveNext()
        {
            // Move the suits on as well as the values are exhausted this turn.
            if (!m_values.MoveNext()) { 
                // No more suits - So no more data to return.
                if (!m_suits.MoveNext())
                    return false;

                // Reset the values after moving to the next suit.
                m_values.Reset();
                m_values.MoveNext();
            }

            return true; // There are still values in the enumerator.
        }

        public void Reset()
        {
            m_values.Reset();
            m_suits.Reset();
            m_suits.MoveNext();
        }
    }
}
