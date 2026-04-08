class Program
{
  static void Main(string[] args)
  {
    var solution = new Solution();
    int[] gas = {1,2,3,4,5}; 
    int[] cost = {3,4,5,1,2}; 

    Console.WriteLine($"gas: [{string.Join(", ", gas)}]");
    Console.WriteLine($"cost: [{string.Join(", ", cost)}]");
    Console.WriteLine("Output: " + solution.Solve(gas, cost));
  }
}