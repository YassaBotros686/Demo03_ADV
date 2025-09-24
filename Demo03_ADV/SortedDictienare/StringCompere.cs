using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_ADV.SortedDictienare
{
    internal class StringCompere : IComparer<String>
    {
        public int Compare(string? x, string? y)
        {
            return y.CompareTo(x);
        }
    }
}
