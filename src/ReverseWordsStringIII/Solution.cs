using System.Text;

namespace ReverseWordsStringIII;

public class Solution {
    public string ReverseWords(string s)
    {
        var words = s.Split(' ')
            .Select(x => x.ToCharArray())
            .ToArray();

        foreach (var word in words)
        {
            for (int i = 0, j = word.Length - i - 1; i < word.Length / 2; i++, j--)
            {
                (word[i], word[j]) = (word[j], word[i]);
            }
        }

        return string.Join(' ', words.Select(x => new string(x)));
    }
}