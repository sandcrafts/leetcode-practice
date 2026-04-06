class Program
{
  static void Main(string[] args)
  {
    string[] ops = {
        "RandomizedSet",
        "insert",
        "remove",
        "insert",
        "getRandom",
        "remove",
        "insert",
        "getRandom"
    };

    int[][] input =
    [
        [],
        [1],
        [2],
        [2],
        [],
        [1],
        [2],
        []
    ];

    var solution = new Solution();

    bool param_1 = solution.Insert(1);
    bool param_2 = solution.Remove(2);
    bool param_3 = solution.Insert(2);
    int param_4 = solution.GetRandom();
    bool param_5 = solution.Remove(1);
    bool param_6 = solution.Insert(2);
    int param_7 = solution.GetRandom();

Console.WriteLine($"[{string.Join(", ", ops)}]");
    Console.WriteLine($"Input: [{string.Join(", ", input.Select(arr => $"[{string.Join(", ", arr)}]"))}]");
    Console.WriteLine("Output: " + $"[null, {param_1}, {param_2}, {param_3}, {param_4}, {param_5}, {param_6}, {param_7}]");
  }
}