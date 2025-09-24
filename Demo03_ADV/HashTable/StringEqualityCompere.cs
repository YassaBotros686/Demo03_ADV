using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03_ADV.HashTable
{
    internal class StringEqualityCompere : IEqualityComparer<String>
    {
        //public new bool Equals(object? x, object? y)
        //{
        //    string? X = x as string;
        //    string? Y = y as string;
        //    return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        //}

        //public int GetHashCode(object obj)
        //{
        //    string? X = obj as string;
        //    return X?.ToLower().GetHashCode() ?? 0;
        //}
        public bool Equals(string? X, string? Y)
        {
            return X?.ToLower().Equals(Y?.ToLower()) ?? false;
        }

        public int GetHashCode([DisallowNull] string X)
        {
                return X?.ToLower().GetHashCode() ?? 0;
        }
    }
}
