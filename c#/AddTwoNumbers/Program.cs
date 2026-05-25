class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode l1 = new ListNode(2);
    ListNode one = new ListNode(4);
    ListNode two = new ListNode(3);

    l1.next = one;
    one.next = two;

    ListNode l2 = new ListNode(5);
    ListNode three = new ListNode(6);
    ListNode four = new ListNode(4);

    l2.next = three;
    three.next = four;

    Console.WriteLine($"Input: l1 = [2,4,3], l2 = [5,6,4]");
    ListNode? output = solution.Solve(l1,l2);
    int value = 0;
    int count = 0;

    while (output != null)
    {
      value += (int) Math.Pow(10, count) * output.val;
      output = output.next;
      count++;
    }

    Console.WriteLine($"Output: {value}");
  }
}