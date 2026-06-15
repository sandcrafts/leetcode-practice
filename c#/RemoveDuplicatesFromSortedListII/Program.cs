class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode head = new ListNode(1);
    ListNode one = new ListNode(2);
    ListNode two = new ListNode(3);
    ListNode three = new ListNode(3);
    ListNode four = new ListNode(4);
    ListNode five = new ListNode(4);
    ListNode six = new ListNode(5);

    head.next = one;
    one.next = two;
    two.next = three;
    three.next = four;
    four.next = five;
    five.next = six;


    Console.WriteLine($"Input: head = [1,2,3,3,4,4,5]");
    ListNode? output = solution.Solve(head);

    Console.WriteLine($"Output: {string.Join(",", output!.ToArray())}");
  }
}