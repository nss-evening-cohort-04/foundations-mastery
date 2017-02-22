using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class SpaceXDragonTests
    {
        [TestMethod]
        public void EnsureSpaceXDragonInstance()
        {
            SpaceXDragonTests Dragon = new SpaceXDragonTests();

            Assert.IsNotNull(Dragon);
        }

        [TestMethod]
        public void EnsureSpaceXDragonFlySpaceCraft()
        {
            SpaceXDragon Dragon = new SpaceXDragon();

            var expected = "bbbbbbbblllllllllllassssssssssstttttttooooooooffffffff!!!!!!";
            var actual = Dragon.FlySpaceCraft();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureSpaceXDragonNumberOfEngines()
        {
            SpaceXDragon Dragon = new SpaceXDragon();

            var expected = 9;
            var actual = Dragon.NumberOfEngines;

            Assert.AreEqual(expected, actual);

        }
    }
}
