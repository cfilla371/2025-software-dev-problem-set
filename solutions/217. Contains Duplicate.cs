public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {

        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int item in nums)
        {
            if (!count.ContainsKey(item))
            {
                count.Add(item, 1);
            }
            else
            {
                count[item]++;
            }
        }
        foreach (KeyValuePair<int, int> item in count)
        {
            if (item.Value > 1)
            {
                return true;
            }
        }
        return false;
    }
}