class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"InputNumbers: [{string.Join(", ", Solution.Nums)}]");
    Console.WriteLine($"InputTarget:  {Solution.Target}");
    Console.WriteLine($"Output: {solution.Solve(Solution.Target, Solution.Nums)}");
  }
}