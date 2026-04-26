class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"S: {Solution.S}");
    Console.WriteLine($"Words: [{string.Join(", ", Solution.Words)}]");
    Console.WriteLine($"Output: [{string.Join(", ", solution.Solve(Solution.S, Solution.Words))}]");

    Console.WriteLine($"S2: {Solution.S2}");
    Console.WriteLine($"Words2: [{string.Join(", ", Solution.Words2)}]");
    Console.WriteLine($"Output2: [{string.Join(", ", solution.Solve(Solution.S2, Solution.Words2))}]");

    Console.WriteLine($"S3: {Solution.S3}");
    Console.WriteLine($"Words3: [{string.Join(", ", Solution.Words3)}]");
    Console.WriteLine($"Output3: [{string.Join(", ", solution.Solve(Solution.S3, Solution.Words3))}]");
  }
}