class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: \n[\n " + 
        string.Join(",\n ", Solution.Points.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );

    var output = solution.Solve(Solution.Points);

    Console.WriteLine($"Output: {output}"
    );
  }
}