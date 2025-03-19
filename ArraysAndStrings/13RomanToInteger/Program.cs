namespace _13RomanToInteger;

class Program
{
    static void Main(string[] args)
    {
        // link https://leetcode.com/problems/roman-to-integer/
    }
     public static int RomanToInt(string s) {
        //Reglas
        /* 
        I can be placed before V (5) and X (10) to make 4 and 9. 
        X can be placed before L (50) and C (100) to make 40 and 90. 
        C can be placed before D (500) and M (1000) to make 400 and 900.
        */
        char next;
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            next = (i + 1 < s.Length) ? s[i + 1] : '\0';

            switch (s[i])
            {
                case 'M':
                    total = total + 1000;
                    break;
                case 'D':
                    total = total + 500;
                    break;
                case 'C':
                    total = total + 100 * NextChar(next, 'D', 'M');
                    break;
                case 'L':
                    total = total + 50;
                    break;
                case 'X':
                    total = total + 10 * NextChar(next, 'L', 'C');
                    break;
                case 'V':
                    total = total + 5;
                    break;
                case 'I':
                    total = total + 1 * NextChar(next, 'V', 'X');
                    break;
            }
        }
        return total;
    }
    private static int NextChar(char next, char letter1, char letter2)
    {
        if (next == letter1 || next == letter2)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }
}
