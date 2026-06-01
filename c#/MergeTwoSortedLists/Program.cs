class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode l1 = new ListNode(1);
    ListNode one = new ListNode(2);
    ListNode two = new ListNode(4);

    l1.next = one;
    one.next = two;

    ListNode l2 = new ListNode(1);
    ListNode three = new ListNode(3);
    ListNode four = new ListNode(4);

    l2.next = three;
    three.next = four;

    Console.WriteLine($"Input: list1 = [1,2,4], list2 = [1,3,4]");
    ListNode? output = solution.Solve(l1,l2);

    Console.WriteLine($"Output: {string.Join(",", output.ToArray())}");
  }
}