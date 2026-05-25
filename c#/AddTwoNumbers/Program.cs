class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode l1 = new ListNode(3);
    ListNode l2 = new ListNode(2);
    ListNode two = new ListNode(0);
    ListNode three = new ListNode(-4);

    l1.next = l2;
    l2.next = two;
    two.next = three;
    three.next = l2;

    Console.WriteLine($"Input: l1 = [3,2,0,-4], pos = 1");
    Console.WriteLine("Output: " + solution.Solve(l1, l2));
  }
}