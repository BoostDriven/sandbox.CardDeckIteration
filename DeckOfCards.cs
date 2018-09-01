using System;
using System.Collections;

namespace Iteration
{
    class DeckOfCards : IEnumerable
    {
        /// <summary>
        /// Creates an enumerator to use.
        /// </summary>
        /// <returns>IEnumerator based class</returns>
        public IEnumerator GetEnumerator()
        {
            return new DeckOfCardsEnumerator();
        }
    }
}
