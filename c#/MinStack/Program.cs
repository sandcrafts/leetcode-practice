class Program
{
  static void Main(string[] args)
  {
    string[] ops = {
        "MinStack",
        "push",
        "push",
        "push",
        "getMin",
        "pop",
        "getMin",
        "pop",
        "getMin",
        "pop",
        "push",
        "push",
        "push",
        "getMin",
        "pop",
        "top",
        "getMin",
        "pop",
        "getMin",
        "pop"
    };

    int[][] input =
    [
        [],[0],[1],[0],[],[],[],[],[],[],[-2],[-1],[-2],[],[],[],[],[],[],[]
    ];

    var solution = new Solution();

    solution.Push(0);
    solution.Push(1);
    solution.Push(0);
    int param_1 = solution.GetMin();
    solution.Pop();
    int param_2 = solution.GetMin();
    solution.Pop();
    int param_3 = solution.GetMin();
    solution.Pop();
    solution.Push(-2);
    solution.Push(-1);
    solution.Push(-2);
    int param_4 = solution.GetMin();
    solution.Pop();
    int param_5 = solution.Top();
    int param_6 = solution.GetMin();
    solution.Pop();
    int param_7 = solution.GetMin();
    solution.Pop();

    int?[] output =
    [
        null,null,null,null,param_1,null,param_2,null,param_3,null,null,null,null,param_4, null, param_5, param_6, null, param_7, null
    ];

Console.WriteLine($"[{string.Join(", ", ops)}]");
    Console.WriteLine($"Input: [{string.Join(", ", input.Select(arr => $"[{string.Join(", ", arr)}]"))}]");
    Console.WriteLine("Output: " + $"[{string.Join(",", output)}]");
  }
}