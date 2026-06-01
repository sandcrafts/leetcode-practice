public class ListNode
{
  public int val;
  public ListNode? next;
  public ListNode(int x, ListNode? next = null)
  {
    val = x;
    this.next = next;
  }

  public int[] ToArray()
  {
    int count = 0;
    ListNode? current = this;
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
