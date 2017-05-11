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

        [TestMethod]
        public void Given_Mixed_1_1_1_5_1_Score_2050()
        {
            var expected = 2050;
            var result = this.greed.Score(new List<int> { 1, 1, 1, 5, 1 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Mixed_2_3_4_6_2_Score_0()
        {
            var expected = 0;
            var result = this.greed.Score(new List<int> { 2, 3, 4, 6, 2 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Mixed_3_4_5_3_3_Score_350()
        {
            var expected = 350;
            var result = this.greed.Score(new List<int> { 3, 4, 5, 3, 3 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Mixed_1_5_1_2_4_Score_250()
        {
            var expected = 250;
            var result = this.greed.Score(new List<int> { 1, 5, 1, 2, 4 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Mixed_5_5_5_5_5_Score_2000()
        {
            var expected = 2000;
            var result = this.greed.Score(new List<int> { 5, 5, 5, 5, 5 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_FourOfAKind2_Score_400()
        {
            var expected = 400;
            var result = this.greed.Score(new List<int> { 2,2,2,2 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_FiveOfAKind2_Score_800()
        {
            var expected = 800;
            var result = this.greed.Score(new List<int> { 2,2,2,2,2 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_SixOfAKind2_Score_1600()
        {
            var expected = 1600;
            var result = this.greed.Score(new List<int> { 2,2,2,2,2,2 });
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_ThreePairs_Score_800()
        {
            var expected = 800;
            var result = this.greed.Score(new List<int> { 2,2,3,3,4,4 });
            Assert.AreEqual(expected, result);
        }
    }
}
