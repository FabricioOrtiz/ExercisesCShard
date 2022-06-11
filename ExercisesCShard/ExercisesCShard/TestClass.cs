using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCShard
{
    public class TestClass
    {
        public List<int> hackerCards(List<int> collection, int d)
        {
            int card = 0;
            collection.OrderBy(x => x).ToList();
            List<int> newCollection = new List<int>();
            for (int i = 1; i < collection[collection.Count - 1]; i++)
            {
                card = i;

                bool NotValidCard = (newCollection.Sum() + card) > d;
                if (newCollection.Sum() <= d && NotValidCard)
                    break;


                if (!collection.Contains(card))
                {
                    newCollection.Add(card);
                }

            }

            return newCollection;
        }
    }
}
