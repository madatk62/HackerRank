using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sort
{
    public static class BigSorting
    {
       private static string TrimLeadingZeroes(string s)
        {
            if(string.IsNullOrEmpty(s)) return "0";
            return string.IsNullOrEmpty(s.TrimStart('0')) ? "0" : s.TrimStart('0');
        }
        public static List<string> BigSort1(List<string> arr)
        {
            var arrNew = arr.Select(x => new {Value = TrimLeadingZeroes(x), Origin= x})
                            .OrderBy(x => x.Value.Length)
                            .ThenBy(x => x.Value, Comparer<string>.Create((a,b)=> a.CompareTo(b)))
                            .Select(x => x.Origin).ToList();
            return arrNew;
        }
    }
}
