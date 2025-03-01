using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sort
{
    public static class CountingSort
    {
        public static List<int> CountingSort1(List<int> arr)
        {
            var result = new int[101];
            for(int i =0; i < arr.Count; i++)
            {
                result[arr[i]]++;
            }
            return result.ToList();
        }
    }
}
