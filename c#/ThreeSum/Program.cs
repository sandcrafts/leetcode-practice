class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: [{string.Join(", ", Solution.Nums)}]");
    var result = solution.Solve(Solution.Nums);
    var formatted = "[" + string.Join(", ", result.Select(inner => "[" + string.Join(", ", inner) + "]")) + "]";
    Console.WriteLine("Output: " + formatted);
  }
}