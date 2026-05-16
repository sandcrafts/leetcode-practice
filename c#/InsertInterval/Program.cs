class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Intervals: \n[\n " + 
        string.Join(",\n ", Solution.Intervals.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );

    Console.WriteLine($"NewInterval: [{string.Join(", ", Solution.NewIntervals)}]");

    var output = solution.Solve(Solution.Intervals, Solution.NewIntervals);

    Console.WriteLine($"Output: \n[\n " + 
        string.Join(",\n ", output.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );
  }
}