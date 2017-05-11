using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GreedKata
{
    [TestClass]
    public class GreedTests
    {
        private Greed greed;

        [TestInitialize]
        public void Setup()
        {
            greed = new Greed();
        }

        [TestMethod]
        public void Given_Single1_Score_100()
        {
            var expected = 100;
            var result = this.greed.Score(new List<int> {1});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Single5_Score_50()
        {
            var expected = 50;
            var result = this.greed.Score(new List<int> {5});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple1_Score_1000()
        {
            var expected = 1000;
            var result = this.greed.Score(new List<int> {1,1,1});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple2_Score_200()
        {
            var expected = 200;
            var result = this.greed.Score(new List<int> {2,2,2});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple3_Score_300()
        {
            var expected = 300;
            var result = this.greed.Score(new List<int> {3,3,3});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple4_Score_400()
        {
            var expected = 400;
            var result = this.greed.Score(new List<int> {4,4,4});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple5_Score_500()
        {
            var expected = 500;
            var result = this.greed.Score(new List<int> {5,5,5});
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Triple6_Score_600()
        {
            var expected = 600;
            var result = this.greed.Score(new List<int> {6,6,6});
            Assert.AreEqual(expected, result);
        }
    }
}
