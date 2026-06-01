public class Node
{
  public int val;
  public Node? next;

  public Node? random;
  public Node(int _val)
  {
    val = _val;
    next = null;
    random = null;
  }

  public int[] ToArray()
  {
    int count = 0;
    Node? current = this;
    while (current != null)
    {
      count++;
      current = current.next;
    }

    int[] result = new int[count];
    current = this;
    for (int i = 0; i < count; i++)
    {
      result[i] = current!.val;
      current = current.next;
    }
    return result;
  }
}
