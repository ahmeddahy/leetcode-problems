public class Solution
{
    public string MinRemoveToMakeValid(string s)
    {
        bool[] arr = new bool[s.Length];
        StringBuilder result = new StringBuilder();
        int bracketsNumber = 0;

        for(int i = 0; i < s.Length; i++)
        {
            if (Char.IsLetter(s[i]))
                continue;
            else
            {
                if (s[i] == ')')
                    bracketsNumber--;
                else
                    bracketsNumber++;
            }

            if(bracketsNumber >= 0)
                continue;
            else
            {
                bracketsNumber = 0;
                arr[i] = true;
            }
        }

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if (bracketsNumber <= 0)
                break;

            if (s[i] ==  '(')
            {
                arr[i] = true;
                bracketsNumber--;
            }
        }

        for(int i =0; i<s.Length;i++)
        {
            if (!arr[i])
                result.Append(s[i]);
        }

        return result.ToString();
    }
}