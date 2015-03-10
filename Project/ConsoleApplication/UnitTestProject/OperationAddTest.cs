using ConsoleApplication.Calculator;
using NUnit.Framework;
using System;
namespace UnitTestProject
{
    [TestFixture]
    public class OperationAddTest
    {
        [TestCase("1", "2", 3)]
        [TestCase("2", "2", 4)]
        [TestCase("0", "0", 0)]
        [TestCase("1", "0", 1)]
        [TestCase("1", "-2", -1)]
        [TestCase("1.2", "2", 3.2f)]
        [TestCase("1,2", "2.3", 3.5f)]
        [TestCase("1.2", "2.3", 3.5f)]
        [TestCase("1,2", "2,3", 3.5f)]
        public void TestPossitiveAdd(string inputA, string inputB, float expected)
        {
            var method = new OperationAdd();
            var result = method.Calculate(inputA, inputB);

            Assert.AreEqual(expected, result);
        }
    }
}
