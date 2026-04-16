class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input String: {Solution.InputString}");
    Console.WriteLine($"Input RowCount: {Solution.NumRows}");
    Console.WriteLine("Output: " + solution.Solve(Solution.InputString, Solution.NumRows));
  }
}