class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: [{string.Join(", ", Solution.Input)}]");
    Console.WriteLine($"Output: [{string.Join(", ", solution.Solve(Solution.Input))}]");
  }
}