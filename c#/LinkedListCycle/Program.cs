class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode head = new ListNode(3);
    ListNode one = new ListNode(2);
    ListNode two = new ListNode(0);
    ListNode three = new ListNode(-4);

    head.next = one;
    one.next = two;
    two.next = three;
    three.next = one;

    Console.WriteLine($"Input: head = [3,2,0,-4], pos = 1");
    Console.WriteLine("Output: " + solution.Solve(head));
  }
}