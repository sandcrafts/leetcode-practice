class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"InputNumbers: [{string.Join(", ", Solution.InputNumbers)}]");
    Console.WriteLine($"InputTarget:  {Solution.Target}");
    Console.WriteLine($"Output: [{string.Join(",", solution.Solve(Solution.InputNumbers, Solution.Target))}]");
  }
}