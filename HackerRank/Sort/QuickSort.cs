using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Sort
{
    public static class QuickSort
    {
        public static List<int> QuickSort1(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }
            var pivot = arr[0];
            var left = new List<int>();
            var right = new List<int>();
            for(int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }
                else
                {
                    right.Add(arr[i]);
                }
            }
            left.Add(pivot);
            left.AddRange(right);
            return left;
        }
    }
}
