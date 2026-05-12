class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();
    var output = solution.Solve(Solution.InputNums);
    Console.WriteLine($"Input String: [{string.Join(", ", Solution.InputNums)}]");
    Console.WriteLine($"Output: [{string.Join(", ", output)}]");
  }
}