class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input S: {Solution.S}");
    Console.WriteLine("Output: " + solution.Solve(Solution.S));
  }
}