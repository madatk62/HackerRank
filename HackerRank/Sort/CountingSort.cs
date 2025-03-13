using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public static List<int> CountingSort2(List<int> arr)
        {
            var tmpArr = new int[101];
            foreach(int i in arr)
            {
                tmpArr[i]++;
            }
            var result = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                for(int j = 0; j < tmpArr[i]; j++)
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static string FullCountingSort(List<List<string>> arr)
        {
            string res = string.Empty;
            var result = new string[101];
            
            var half = arr.Count / 2;
            for (int i = 0; i < arr.Count; i++)
            {   var tmp = arr[i][1];
                if(i< half ) tmp = "-";
                int index = int.Parse(arr[i][0]);
                result[index] += !string.IsNullOrEmpty(result[index]) ? " " + tmp : tmp;
            }
            for(int i = 0; i< result.Length; i++)
            {
                if (!string.IsNullOrEmpty(result[i])) res += !string.IsNullOrEmpty(res) ? " " + result[i] : result[i];
            }
            return res;
        }
    }
}
