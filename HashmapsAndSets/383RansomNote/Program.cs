namespace _383RansomNote;

class Program
{
    static void Main(string[] args)
    {
        // link: https://leetcode.com/problems/ransom-note/
    }
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> lettersPool = new Dictionary<char, int>();

        foreach (char letter in magazine)
        {
            if (lettersPool.ContainsKey(letter))
            {
                lettersPool[letter]++;
            }
            else
            {
                lettersPool.Add(letter, 1);
            }
        }

        foreach (char letter in ransomNote)
        {
            if (lettersPool.ContainsKey(letter))
            {
                if (lettersPool[letter] == 0)
                {
                    return false;
                }
                else
                {
                    lettersPool[letter]--;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}
