public class Solution
{
    public bool IsAnagram(string s, string t)
    {
       char[] ns = s.ToCharArray();
        Array.Sort(ns);
        String sns = new string(ns);
        char[] nt = t.ToCharArray();
        Array.Sort(nt);
        String snt = new string(nt);

        if (sns == snt)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}