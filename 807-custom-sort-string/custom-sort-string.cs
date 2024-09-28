public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var charsCount = new int[26];
        var res = new StringBuilder();

        foreach (char c in s)
            charsCount[c - 'a']++;

        foreach(char c in order)
        {
            while (charsCount[c-'a'] > 0)
            {
                res.Append(c);
                charsCount[c - 'a']--;
            }
        }

        foreach (char c in s)
        {
            while (charsCount[c - 'a'] > 0)
            {
                res.Append(c);
                charsCount[c - 'a']--;
            }
        }


        return res.ToString();
    }
}