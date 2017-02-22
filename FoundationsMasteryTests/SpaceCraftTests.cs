using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class SpaceCraftTests
    {
        [TestMethod]
        public void EnsureSpaceCraftInstance()
        {
            SpaceCraft Falcon = new SpaceCraft("falcon");

            Assert.IsNotNull(Falcon);
        }

        [TestMethod]
        public void EnsureSpaceCraftFlySpaceCraft()
        {
            SpaceCraft Falcon = new SpaceCraft("falcon");

            string expected = "ppppppppppppphhhhhhhhhheeeeeeeeeeewwwwwwwwwwwwwwwwwww";
            string actual = Falcon.FlySpaceCraft();

            Assert.AreEqual(expected, actual);
        }
    }
}
