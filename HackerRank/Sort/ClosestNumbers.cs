namespace HackerRank.Sort
{
    public static class ClosestNumbers
    {
        public static List<int> Handle(List<int> arr)
        {
            int minDiff = int.MaxValue;
            List<int> result = new List<int>();
            arr.Sort();
            for (int i = 1; i < arr.Count; i++)
            {
                var tmp = Math.Abs(arr[i] - arr[i - 1]);
                if (minDiff > tmp)
                {
                    minDiff = tmp;
                    result = new List<int> { arr[i - 1], arr[i] };
                }
                else if (minDiff == tmp)
                {
                    result.AddRange(new List<int> { arr[i - 1], arr[i] });
                }
            }
            return result;
        }
    }
}
