using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfNim.Models;
using System.Collections.Generic;


namespace GameOfNimUnitTesting
{
    [TestClass]
    public class HeapTests
    { 
        [TestMethod]
        public void HeapIsEmpty_Test1()
        {
            Heap heap = new Heap("Heap", 1);

            Assert.IsFalse(heap.IsEmpty);
        }

        [TestMethod]
        public void HeapIsEmpty_Test2()
        {
            Heap heap = new Heap("Heap", 0);

            Assert.IsTrue(heap.IsEmpty);
        }

        [TestMethod]
        public void HeapTakeAmount_Test1()
        {
            Heap heap = new Heap("Heap", 0);

            Assert.IsFalse(heap.TakeAmount(0));
        }

        [TestMethod]
        public void HeapTakeAmount_Test2()
        {
            Heap heap = new Heap("Heap", 1);

            Assert.IsFalse(heap.TakeAmount(0));
        }

        [TestMethod]
        public void HeapTakeAmount_Test3()
        {
            Heap heap = new Heap("Heap", 0);

            Assert.IsFalse(heap.TakeAmount(1));
        }

        [TestMethod]
        public void HeapTakeAmount_Test4()
        {
            Heap heap = new Heap("Heap", 1);

            Assert.IsFalse(heap.TakeAmount(2));
        }

        [TestMethod]
        public void HeapToString_Test()
        {
            Heap heap = new Heap("Heap", 1);
            
            Assert.AreEqual("Heap : 1", heap.ToString());
        }

        [TestMethod]
        public void CPUTakesWinningMove()
        {
            Dictionary<string, Heap> heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 100) }, { "B", new Heap("B", 0) } };

            CPU cpu = new CPU();
            cpu.TakeTurn(heaps);
            Assert.IsTrue(heaps["A"].Amount == 1);
        }

        [TestMethod]
        public void CPUTakesValidTurn()
        {
            Dictionary<string, Heap> heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 5) }, { "B", new Heap("B",7) } };
            CPU cpu = new CPU();
            cpu.TakeTurn(heaps);
            Assert.IsTrue(heaps["A"].Amount != 5 || heaps["B"].Amount != 7);
        }
        [TestMethod]
        public void CPUTakesLosingTurn()
        {
            Dictionary<string, Heap> heaps = new Dictionary<string, Heap> { { "A", new Heap("A", 1) }, { "B", new Heap("B", 0) } };
            CPU cpu = new CPU();
            cpu.TakeTurn(heaps);
            Assert.IsTrue(heaps["A"].Amount == 0);
        }
    }
}
