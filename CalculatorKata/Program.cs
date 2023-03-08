using System;

namespace CalculatorKata {
  public class StringCalculator {
    public static int Add(string numbers) {
      string[] summands = numbers.Split(new char[] { ',', '\n' });
      int sum = 0;

      foreach (var summand in summands) {
        if (!int.TryParse(summand, out int result))
          result = 0;

        if (result < 0)
          throw new NotSupportedException();

        if (result > 1000)
          result = 0;

        sum += result;
      }

      return sum;
    }
  }

  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");
    }
  }
}
