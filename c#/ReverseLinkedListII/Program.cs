class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    ListNode head = new ListNode(1);
    ListNode one = new ListNode(2);
    ListNode two = new ListNode(3);
    ListNode three = new ListNode(4);
    ListNode four = new ListNode(5);

    head.next = one;
    one.next = two;
    two.next = three;
    three.next = four;
    int left = 2;
    int right =4;


    Console.WriteLine($"Input: head = [1,2,3,4,5], left = 2, right = 4");
    ListNode? output = solution.Solve(head, left, right);

    Console.WriteLine($"Output: {string.Join(",", output!.ToArray())}");
  }
}