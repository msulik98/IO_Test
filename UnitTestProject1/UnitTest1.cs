using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO_Test;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculate_EmptyString()
        {
            int result = Calculator.Calculate("");
            Assert.AreEqual(0,result);
        }
        [TestMethod]
        public void TestCalculate_SingleString()
        {
            int result = Calculator.Calculate("1");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestCalculate_NullString()
        {
            int result = Calculator.Calculate(null);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestCalculate_CorrectString()
        {
            int result = Calculator.Calculate("1,2");
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void TestCalculate_CorrectString2()
        {
            int result = Calculator.Calculate("1\n2");
            Assert.AreEqual(3, result);
        }
        
        //[TestMethod]
        //public void TestCalculate_CorrectString3()
        //{
        //    int result = Calculator.Calculate("1,2,3");
        //    Assert.AreEqual(3, result);
        //}
        //[TestMethod]
        //public void TestCalculate_CorrectString4()
        //{
        //    int result = Calculator.Calculate("1,2,3");
        //    Assert.AreEqual(3, result);
        //}
        //[TestMethod]
        //[DataRow("1,2,3", 6)]
        //[DataRow("1,2\n,3", 6)]
        //[DataRow("1\n,2,3", 6)]
        //[DataRow("1\n2\n3\n", 6)]
        //public void TestCalculate_CorrectString5(string before, int expected)
        //{
        //    int result = Calculator.Calculate(before);
        //    Assert.AreEqual(expected, result);
        //}
        //[TestMethod]
        //public void TestCalculate_InCorrectString_NegativeNumber()
        //{
        //    Assert.ThrowsException<Exception>(() => Calculator.Calculate("-1"));
        //}
        //[TestMethod]
        //public void TestCalculate_IncorrectString_GreaterThan1000()
        //{
        //    Assert.ThrowsException<Exception>(() => Calculator.Calculate("1001"));
        //}
        //[TestMethod]
        //public void TestCalculate_CorrectString_Custom_Delimiter()
        //{
        //    int result = Calculator.Calculate("//#2#3");
        //    Assert.AreEqual(5, result);
        //}
        //[TestMethod]
        //public void TestCalculate_IncorrectString_Custom_Delimiter()
        //{
        //    Assert.ThrowsException<Exception>(() => Calculator.Calculate("//#2!#3"));
        //}
        //[TestMethod]
        //public void TestCalculate_CorrectString_Custom_Delimiter2()
        //{
        //    int result = Calculator.Calculate("//[#@%]2[#@%]3");
        //    Assert.AreEqual(5, result);
        //}
        //[TestMethod]
        //[DataRow("//[#@%][^&@$!][!@#!@#]2[#@%]3", 5)]
        //[DataRow("//[#@%][^&@$!][!@#!@#]2[^&@$!]3", 5)]
        //[DataRow("//[#@%][^&@$!][!@#!@#]2[!@#!@#]3", 5)]

        //public void TestCalculate_CorrectString_Custom_Delimiter3(string before, int expected)
        //{
        //    int result = Calculator.Calculate(before);
        //    Assert.AreEqual(expected, result);
        //}

    }
}
