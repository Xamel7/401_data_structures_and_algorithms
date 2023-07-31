namespace CodeChallenges
{
  public class CodeChallenge3
  {
    public static int BinarySearch(int[] array, int key)
    {
      // Initialize the east and west pointers to the start and end of the array, respectively
      int east = 0;
      int west = array.Length - 1;

      // Perform binary search until the east pointer is less than or equal to the west pointer
      while (east <= west)
      {
        // Calculate the index of the element in the middle of the current search space
        int equator = east + (west - east) / 2;

        // Check if the middle element is equal to the key
        if (array[equator] == key)
        {
          return equator; // Element found, return the index
        }
        // If the middle element is less than the key, search in the right half
        else if (array[equator] < key)
        {
          east = equator + 1;
        }
        // If the middle element is greater than the key, search in the left half
        else
        {
          west = equator - 1;
        }
      }

      return -1; // Element not found in the array
    }
  }
}
