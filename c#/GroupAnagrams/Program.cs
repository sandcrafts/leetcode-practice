class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();
    var output = solution.Solve(Solution.Strs);
    Console.WriteLine($"Input String: [{string.Join(", ", Solution.Strs)}]");
    Console.WriteLine($"Output: [{string.Join(", ",
    output.Select(group => 
    $"[{string.Join(",", group.Select(word => $"\"{word}\""))}]"
    )
     )}]");
  }
}