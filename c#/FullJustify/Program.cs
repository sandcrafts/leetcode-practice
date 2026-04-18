class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();
    var output = solution.Solve(Solution.InputWords, Solution.MaxWidth);
    Console.WriteLine($"Input String: [{string.Join(", ", Solution.InputWords)}]");
    Console.WriteLine($"Input RowCount: {Solution.MaxWidth}");
    Console.WriteLine($"Output: [{string.Join(", ", output)}]");
  }
}