using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciLibrary.Tests
{
    [TestClass()]
    public class FibonacciLogicTests
    {
        [TestMethod()]
        public void FibonacciLogicMustReturn8()
        {

            FibonacciLogic fibonacciLogic = new FibonacciLogic();

            Int64 result = fibonacciLogic.ComputeFibonacci(6);

            Assert.AreEqual(8,result);
        }


        [TestMethod()]
        public void FibonacciLogicMustReturn55()
        {

            FibonacciLogic fibonacciLogic = new FibonacciLogic();

            Int64 result = fibonacciLogic.ComputeFibonacci(10);

            Assert.AreEqual(55, result);
        }


        [TestMethod()]
        public void FibonacciLogicMustReturn46368()
        {

            FibonacciLogic fibonacciLogic = new FibonacciLogic();

            Int64 result = fibonacciLogic.ComputeFibonacci(24);

            Assert.AreEqual(46368, result);
        }



        [TestMethod()]
        public void FibonacciLogicMustReturMinus1()
        {

            FibonacciLogic fibonacciLogic = new FibonacciLogic();

            Int64 result = fibonacciLogic.ComputeFibonacci(100);

            Assert.AreEqual(-1, result);
        }
    }
}