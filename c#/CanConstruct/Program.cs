class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();

    Console.WriteLine($"ransomNote: {Solution.RansomNote}");
    Console.WriteLine($"Magazine: {Solution.Magazine}");
    Console.WriteLine("Output: " + solution.Solve(Solution.RansomNote, Solution.Magazine));
  }
}