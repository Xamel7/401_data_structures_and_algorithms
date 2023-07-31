using System.Runtime.CompilerServices;

namespace CodeChallenges
{
  public class Node
  {
    public T Value { get; set; }
    public Node Next { get; set; }
    public Node(T value)
    {
      Value = value;
      Next = null;
    }

  }
  private Node top;
  private int count;
  private T defaultValue;

  public class Stack(T defaultValue)
  {
    this.defaultValue = defaultValue;
    top = null;
    count = 0;
  }

  public

  public class Queue
  {
  }
}
