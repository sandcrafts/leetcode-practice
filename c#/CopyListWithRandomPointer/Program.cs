class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Node l1 = new Node(1);
    Node one = new Node(2);
    Node two = new Node(4);

    l1.next = one;
    one.next = two;


    Console.WriteLine($"Input: head = [[7,null],[13,0],[11,4],[10,2],[1,0]]");
    Node? output = solution.Solve(l1);

    Console.WriteLine($"Output: {string.Join(",", output.ToArray())}");
  }
}