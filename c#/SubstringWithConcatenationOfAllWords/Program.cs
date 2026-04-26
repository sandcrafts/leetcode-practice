class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"S: {Solution.S}");
    Console.WriteLine($"Words: [{string.Join(", ", Solution.Words)}]");
    Console.WriteLine($"Output: [{string.Join(", ", solution.Solve(Solution.S, Solution.Words))}]");
  }
}