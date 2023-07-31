using System.Collections;
namespace CodeChallenges
{
    public class CodeChallenge1
    {
        public static int[] ReverseArray(int[] array)
        {
          int[] secArray = new int[array.Length];
          int daLength = secArray.Length; //5
          for (int i = array.Length; i > 0; i--)
            {
              secArray[daLength - i] = array[i - 1];
            }
            return secArray;
        }
    }
}
