class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input: \n[\n " + 
        string.Join(",\n ", Solution.Board.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );

    solution.Solve(Solution.Board);

    Console.WriteLine($"Output: \n[\n " + 
        string.Join(",\n ", Solution.Board.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );
  }
}