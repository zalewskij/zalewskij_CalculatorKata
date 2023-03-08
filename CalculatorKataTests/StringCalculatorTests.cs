using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorKata;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorKata.Tests {
  [TestClass()]
  public class StringCalculatorTests {
    [TestMethod()]
    public void ZeroTest() {
      int result = StringCalculator.Add("");
      Assert.AreEqual(0, result);
    }

    [TestMethod()]
    public void OneTest() {
      int result1 = StringCalculator.Add("5");
      Assert.AreEqual(5, result1);
      int result2 = StringCalculator.Add("2");
      Assert.AreEqual(2, result2);
    }

    [TestMethod()]
    public void TwoTest() {
      Tuple<string, int>[] testCases = new Tuple<string, int>[] {
        new Tuple<string, int>( "2,3", 5 ),
        new Tuple<string, int>( "7,0", 7 ),
        new Tuple<string, int>( "0,0", 0 ),
        new Tuple<string, int>( "4\n6", 10 ),
      };

      foreach (var testCase in testCases) {
        int result = StringCalculator.Add(testCase.Item1);
        Assert.AreEqual(testCase.Item2, result);
      }
    }

    [TestMethod()]
    public void ThreeTest() {
      Tuple<string, int>[] testCases = new Tuple<string, int>[] {
        new Tuple<string, int>( "2,3,5", 10 ),
        new Tuple<string, int>( "8,3\n3", 14 ),
        new Tuple<string, int>( "0,0\n+0", 0 ),
        new Tuple<string, int>( "14\n6\n10", 30 ),
      };

      foreach (var testCase in testCases) {
        int result = StringCalculator.Add(testCase.Item1);
        Assert.AreEqual(testCase.Item2, result);
      }
    }

    [TestMethod()]
    [ExpectedException(typeof(NotSupportedException), "Negative numbers should not be evaluated")]
    public void NegativeTest() {
      StringCalculator.Add("5,-2,4");
    }

    [TestMethod()]
    public void BigTest() {
      int result = StringCalculator.Add("2,1009,3");
      Assert.AreEqual(5, result);
    }
  }
}

namespace CalculatorKataTests {
  class StringCalculatorTests {
  }
}
