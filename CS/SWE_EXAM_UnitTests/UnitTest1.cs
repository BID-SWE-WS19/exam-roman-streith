using System;
using BID.SWE.EXAM.Impl;
using NUnit.Framework;

namespace SWE_EXAM_UnitTests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void Cell_Alive_Red_Now()
        {
            var obj = new Printer();
            string state = obj.PrintState(true, DateTime.Today, "red");
            Assert.AreEqual(state, "Cell red born on " + DateTime.Today + " is alive");
        }

        [Test]
        public void Cell_Position() {
            var obj = new Printer();
            string state = obj.PrintPostion(1, 2);
            Assert.AreEqual(state, "Cell is on Position X:1 Y:2");
        }
    }
}