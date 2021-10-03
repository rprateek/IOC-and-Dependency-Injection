using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int [] _elements)
        {
            elements = _elements;          


        }
        public void computeDifference()
        {

            int retVal=0;
            int max = elements.Max();
            int min = elements.Min();

            retVal = max - min;
            maximumDifference = retVal;

        }
    }
}
