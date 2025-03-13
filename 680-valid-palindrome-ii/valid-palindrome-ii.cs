public class Solution
{
    public bool ValidPalindrome(string s)
    {
        var lastIndex = s.Length - 1;
        for (int i = 0; i < s.Length / 2; i++) {
            if (s[i] == s[lastIndex])
            {
                lastIndex--;
                continue;
            }
            else
            {
                var firstApprochLastIndex = lastIndex;
                var firstApprochBeginIndex = i + 1;
                var isFirstApprochValid = true;
                while(firstApprochBeginIndex <= firstApprochLastIndex)
                {
                    if (s[firstApprochBeginIndex] != s[firstApprochLastIndex])
                    {
                        isFirstApprochValid = false;
                        break;
                    }
                    firstApprochLastIndex--;
                    firstApprochBeginIndex++;
                }

                var secondApprochLastIndex = lastIndex - 1;
                var secondApprochBeginIndex = i;
                var isSecondApprochValid = true;
                while (secondApprochBeginIndex <= secondApprochLastIndex)
                {
                    if (s[secondApprochBeginIndex] != s[secondApprochLastIndex])
                    {
                        isSecondApprochValid = false;
                        break;
                    }
                    secondApprochLastIndex--;
                    secondApprochBeginIndex++;
                }

                return isFirstApprochValid || isSecondApprochValid;
            }
        }

        return true;
    }
}