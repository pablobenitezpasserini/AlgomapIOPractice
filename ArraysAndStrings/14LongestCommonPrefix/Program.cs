namespace _14LongestCommonPrefix;

class Program
{
    static void Main(string[] args)
    {
        // link https://leetcode.com/problems/longest-common-prefix/description/
    }
    public static string LongestCommonPrefix(string[] strs) {

        string shortest = strs.OrderBy(s => s.Length).First();

        for(int i = 0; i < shortest.Length; i++)
        {
            if ( strs.Select( s => s[i]).Distinct().Count() > 1 )
            {
                return shortest[..i];
            }
        }
        return shortest;
    }
}
