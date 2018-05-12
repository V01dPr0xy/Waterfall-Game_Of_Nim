using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfNim.Models;

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
    }
}
