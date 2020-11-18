using System;
using System.Collections.Generic;

namespace Sorting
{
    class ElementsEventArgs : EventArgs
    {
        public List<int> Elements;
        public int IterationCount;

        public ElementsEventArgs(List<int> Elements, int IterationCount)
        {
            this.Elements = Elements;
            this.IterationCount = IterationCount;
        }
    }
}
