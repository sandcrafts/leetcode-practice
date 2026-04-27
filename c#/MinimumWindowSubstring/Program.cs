class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"s: {Solution.S}");
    Console.WriteLine($"t: {Solution.T}");
    Console.WriteLine("Output: " + solution.Solve(Solution.S, Solution.T));
  }
}