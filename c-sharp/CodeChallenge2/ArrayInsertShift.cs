namespace CodeChallenges
{
  public class CodeChallenge2
  {
    public static int[] InsertShiftArray(int[] array, int value)
    {

      //insert the value into the middle of the array
      int[] newArray = new int[array.Length + value];
      int midIndex = array.Length / 2;

      for (int i = 0; i < newArray.Length; i++)
      {
        if(i < midIndex)
        {
        newArray[i] = array[i];
        }else if (i == midIndex)
        {
          newArray[i] = value;
        }else
        {
          newArray[i] = value [i - 1];
        }
      }
      newArray[midIndex] = value;
      for(int i = midIndex + 1; i < value.Length; i++)
      {
        newArray[i] = array[i];
      }
      return array;
    }
  }
}
