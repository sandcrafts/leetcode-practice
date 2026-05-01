class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: \n[\n " + 
        string.Join(",\n ", Solution.Matrix.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );

    solution.Solve(Solution.Matrix);

    Console.WriteLine($"Output: \n[\n " + 
        string.Join(",\n ", Solution.Matrix.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );
  }
}