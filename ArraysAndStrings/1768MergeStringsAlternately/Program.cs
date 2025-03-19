using System.Text;

namespace _1768MergeStringsAlternately;

class Program
{
    static void Main(string[] args)
    {
        // link https://leetcode.com/problems/merge-strings-alternately/description/
    }

    public static string MergeAlternately(string word1, string word2) {
        StringBuilder ans = new StringBuilder();
        int word1Length = word1.Length;
        int word2Length = word2.Length;
        int totalLength = word1Length + word2Length;
        int a = 0;
        int b = 0;

        while(ans.Length < totalLength)
        {
            if (a < word1Length)
            {
                ans.Append(word1[a]);
                a++;
            }
            if (b < word2Length)
            {
                ans.Append(word2[b]);
                b++;
            }
        }
        return ans.ToString();
    }
}
