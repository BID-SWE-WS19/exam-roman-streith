using System;
using System.IO;
using BID.SWE.EXAM.Impl;
using NUnit.Framework;
using static BID.SWE.EXAM.Impl.Exercise3;

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

        [Test]
        public void Cell_Not_Null() {
            var obj = new MyCell();
            Assert.IsNotNull(obj);
        }


        [Test] // Dieser Test verhindert das Compilieren
        public void Cell_Grow() {
            var obj = new MyCell();
            int result = obj.Grow();
            Assert.AreEqual(result, 2);
        }

        [Test]
        public void BidMap_Get() {
            var obj = new Map1();
            string name = obj.GetMapName();
            Assert.AreEqual(name, "BID-Map");
        }

        [Test]
        public void BidMap_Size() {
            var obj = new Map1();
            float size = obj.GetMapSize(2.0f);
            Assert.AreEqual(size, 4.0f);
        }

        [Test]
        public void BidMap_Count() {
            var obj = new Map1();
            int year = obj.AddNewCells(2019);
            Assert.AreEqual(year, 2019);
        }

        [Test]
        public void Bewegung_Springen_Move() {
            var obj = new Springen();
            string move = obj.Move();
            Assert.AreEqual(move, "Up");
        }

        /*[Test] Funktionieren nicht sind aber sinnhaftig
        public void Stream_Write()
        {
            var obj = new Exercise4();
            object mem = obj.Method1();
            BinaryReader reader = new BinaryReader((MemoryStream)mem);
            string str = reader.ReadString();
            Assert.AreEqual(str, "Frohe Weihnachten");
        }

        [Test]
        public void Stream_Reader() {
            var obj = new Exercise4();
            object mem = obj.Method2(new MemoryStream());
            string result = mem.ToString();
            Assert.AreEqual(result, "Frohe Weihnachten");
        }*/
    }
}