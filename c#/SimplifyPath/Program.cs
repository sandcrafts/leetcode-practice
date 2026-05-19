class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input Path: {Solution.Path}");
    Console.WriteLine("Output: " + solution.Solve(Solution.Path));
  }
}