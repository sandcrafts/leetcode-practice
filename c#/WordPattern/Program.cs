class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Pattern: {Solution.Pattern}");
    Console.WriteLine($"S: {Solution.S}");
    Console.WriteLine("Output: " + solution.Solve(Solution.Pattern, Solution.S));
  }
}