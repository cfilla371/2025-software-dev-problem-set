public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        int[] isAnagram = new int[26];
        Array.Fill(isAnagram, 0);

        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            isAnagram[s[i] - 'a']++;
            isAnagram[t[i] - 'a']--;
        }
        foreach (int item in isAnagram)
        {
            if (item != 0)
            {
                return false;
            }
        }
        return true;
    }
}