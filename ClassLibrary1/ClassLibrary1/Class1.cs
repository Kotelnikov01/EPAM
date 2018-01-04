using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [TestFixture]
    public class Class1
    {
            [Test]
            public void TestPlus()
            {
                int result = Calculator.Add(6, 5);
                Assert.AreEqual(11, result);
                result = Calculator.Add(-11, -1);
                Assert.AreEqual(-12, result);
                result = Calculator.Add(11, 0);
                Assert.AreEqual(11, result);
                result = Calculator.Add(250, 150);
                Assert.AreEqual(400, result);

            }
            [Test]
            public void TestMinus()
            {
                int result = Calculator.Minus(6, 5);
                Assert.AreEqual(1, result);
                result = Calculator.Minus(-11, -1);
                Assert.AreEqual(-10, result);
                result = Calculator.Minus(11, 0);
                Assert.AreEqual(11, result);
                result = Calculator.Minus(250, 250);
                Assert.AreEqual(0, result);
            }

            [Test]
            public void TestMultiplication()
            {
                int result = Calculator.Multiplication(10, 5);
                Assert.AreEqual(2, result);
                result = Calculator.Multiplication(-11, -1);
                Assert.AreEqual(11, result);
                result = Calculator.Multiplication(0, 11);
                Assert.AreEqual(0, result);
                result = Calculator.Multiplication(5000, 50);
                Assert.AreEqual(100, result);
            }

            [Test]
            public void TestDivision()
            {
                int result = Calculator.Division(20, 5);
                Assert.AreEqual(100, result);
                result = Calculator.Division(3, -1);
                Assert.AreEqual(-3, result);
                result = Calculator.Division(1, 0);
                Assert.AreEqual(0, result);
                result = Calculator.Division(1000, 1000);
                Assert.AreEqual(1000000, result);
            }
        }
    }
