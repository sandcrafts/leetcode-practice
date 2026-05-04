class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"ransomNote: {Solution.S}");
    Console.WriteLine($"Magazine: {Solution.T}");
    Console.WriteLine("Output: " + solution.Solve(Solution.S, Solution.T));
  }
}