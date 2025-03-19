namespace _2239FindClosestNumberToZero;

class Program
{
    static void Main(string[] args)
    {
        // link https://leetcode.com/problems/find-closest-number-to-zero/description/
    }

    public static int FindClosestNumber(int[] nums) 
    {
        int numsLength = nums.Length;
        if ( numsLength == 1)
        {
            return nums[0];
        }

        int currentClosest = nums[0];
        
        foreach(int num in nums)
        {
            // si el valor absoluto del elemento actual es menor que el valor
            // absoluto del numero mas cercano actual
            if(Math.Abs(num) < Math.Abs(currentClosest))
            {               
                currentClosest = num;
            }
            // si los valores absolutos de ambos son identicos
            if(Math.Abs(num) == Math.Abs(currentClosest))
            {
                // conservo el mas grande
                currentClosest = Math.Max(num, currentClosest);
            }
        }
        return currentClosest;        
    }
}
