using System.Runtime.Loader;

namespace ClassLibrary1
{
        /*
    This problem was asked by Apple.

    A fixed point in an array is an element whose value is equal to its index. Given a sorted array of distinct elements, 
        return a fixed point, if one exists. Otherwise, return False.

    For example, given [-6, 0, 2, 40], you should return 2. Given [1, 5, 7, 8], you should return False.
    */
    public class Class1
    {
        public static dynamic Solver(int[] arr)
        {
            if (arr.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr[i])
                {
                    return i;
                }
                
            }
            return false;
        }

    }
}