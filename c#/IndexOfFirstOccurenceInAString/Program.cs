class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input Haystack: {Solution.HAYSTACK}");
    Console.WriteLine($"Input Needle: {Solution.NEEDLE}");
    Console.WriteLine("Output: " + solution.Solve(Solution.HAYSTACK, Solution.NEEDLE));
  }
}