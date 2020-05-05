using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Tests
{
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            Assert.Fail();
            var bubble = new BubbleSort<int>();



           
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                bubble.Items.Add(rnd.Next(0, 100));
            }
            

            bubble.Sort();
        }
    }
}