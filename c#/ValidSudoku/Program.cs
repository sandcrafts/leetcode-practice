class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"Input:\n[\n " + 
        string.Join(",\n ", Solution.Board.Select(row => $"[{string.Join(",", row)}]"))
        + "\n]"
    );
    Console.WriteLine("Output: " + solution.Solve(Solution.Board));
  }
}