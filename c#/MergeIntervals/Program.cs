class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: \n[\n " + 
        string.Join(",\n ", Solution.Intervals.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );

    var output = solution.Solve(Solution.Intervals);

    Console.WriteLine($"Output: \n[\n " + 
        string.Join(",\n ", output.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );
  }
}