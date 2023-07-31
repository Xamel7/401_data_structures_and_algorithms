namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {
      // Get the length of the original array
      int length = array.Length;

      // Calculate the index where the new value should be inserted
      int middleIndex = length / 2;

      // Shift elements to the right after the middle index
      for (int i = length - 1; i > middleIndex; i--)
      {
        array[i] = array[i - 1];
      }

      // Insert the value at the middle index
      array[middleIndex] = value;

      // Return the modified array
      return array;
    }
  }
}
