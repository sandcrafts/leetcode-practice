class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"N: {solution.N}");
    Console.WriteLine("Output: " + Solution.Solve(Solution.N));
  }
}