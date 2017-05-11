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
    }
}
