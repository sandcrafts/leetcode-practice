class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Node head = new Node(7);
    Node one = new Node(13);
    Node two = new Node(11);
    Node three = new Node(10);
    Node four = new Node(1);

    head.next = one;
    one.next = two;
    two.next = three;
    three.next = four;

    one.random = head;
    two.random = four;
    three.random = two;
    four.random = head;


    Console.WriteLine($"Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]");
    Node? output = solution.Solve(head);

    Console.WriteLine($"Output: {string.Join(",", output.ToArray())}");
  }
}