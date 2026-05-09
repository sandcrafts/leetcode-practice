class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"N: {Solution.N}");
    Console.WriteLine("Output: " + solution.Solve(Solution.N));
  }
}