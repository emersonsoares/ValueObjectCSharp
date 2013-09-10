using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DDDLibrary.Tests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void AreaInSquareMetersMustBeReturnSquareMeters()
        {
            var area = Area.FromSquareMeters(1000);
            const int expected = 1000;

            Assert.AreEqual(expected, area.InSquareMeters());
        }

        [TestMethod]
        public void AreaWithIdenticSquareMetersEqualsMustBeReturnTrue()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(1000);

            Assert.IsTrue(area1.Equals(area2));
        }

        [TestMethod]
        public void AreaWithDiferentSquareMetersEqualsMustBeReturnFalse()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(2000);

            Assert.IsFalse(area1.Equals(area2));
        }

        [TestMethod]
        public void AreaWithIdenticSquareMetersEqualsOperatorMustBeReturnTrue()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(1000);

            Assert.IsTrue(area1 == area2);
        }

        [TestMethod]
        public void AreaWithDiferentSquareMetersEqualsOperatorMustBeReturnTrue()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(2000);

            Assert.IsFalse(area1 == area2);
        }

        [TestMethod]
        public void AreaWithIdenticSquareMetersDiferentOperatorMustBeReturnFalse()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(1000);

            Assert.IsFalse(area1 != area2);
        }

        [TestMethod]
        public void AreaWithDiferentSquareMetersDiferentOperatorMustBeReturnTrue()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(2000);

            Assert.IsTrue(area1 != area2);
        }

        [TestMethod]
        public void AreaComparationWithADiferentObjectEqualsMustBeReturnFalse()
        {
            var area = Area.FromSquareMeters(1000);
            var obj = new Object();

            Assert.IsFalse(area.Equals(obj));
        }

        [TestMethod]
        public void AreaComparationWithAObjectOfTypeAreaMustBeReturnTrue()
        {
            var area = Area.FromSquareMeters(1000);
            object area2 = Area.FromSquareMeters(1000);

            Assert.IsTrue(area.Equals(area2));
        }

        [TestMethod]
        public void HashCodeOfTwoAreasWithEqualSquareMetersMustBeTheSame()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(1000);

            Assert.AreEqual(area1.GetHashCode(), area2.GetHashCode());
        }

        [TestMethod]
        public void HashCodeOfTwoAreasWithDiferentSquareMetersMustBeDiferent()
        {
            var area1 = Area.FromSquareMeters(1000);
            var area2 = Area.FromSquareMeters(2000);

            Assert.AreNotEqual(area1.GetHashCode(), area2.GetHashCode());
        }

        [TestMethod]
        public void AreaFromHectaresMustBeReturnAnAreaWithValidSquareMeters()
        {
            var area = Area.FromHectares(1);
            var area2 = Area.FromSquareMeters(10000);

            Assert.AreEqual(area, area2);
        }

        [TestMethod]
        public void AreaFromAcresMustBeReturnAnAreaWithValidSquareMeters()
        {
            var area = Area.FromAcres(1);
            var area2 = Area.FromSquareMeters(4046.856422m);

            Assert.AreEqual(area, area2);
        }

        [TestMethod]
        public void AreaFromAlqueiresDoNorteMustBeReturnAnAreaWithValidSquareMeters()
        {
            var area = Area.FromAlqueiresDoNorte(1);
            var area2 = Area.FromSquareMeters(27000.225m);

            Assert.AreEqual(area, area2);
        }

        [TestMethod]
        public void AreaFromAlqueiresPaulistaMustBeReturnAnAreaWithValidSquareMeters()
        {
            var area = Area.FromAlqueiresPaulista(1);
            var area2 = Area.FromSquareMeters(24000.200m);

            Assert.AreEqual(area, area2);
        }

        [TestMethod]
        public void AreaFromAlqueiresMineiroMustBeReturnAnAreaWithValidSquareMeters()
        {
            var area = Area.FromAlqueiresMineiro(1);
            var area2 = Area.FromSquareMeters(48000.400m);

            Assert.AreEqual(area, area2);
        }

        [TestMethod]
        public void AreaInHectaresMustBeReturnHectaresOfArea()
        {
            var area = Area.FromSquareMeters(10000);
            var area2 = Area.FromHectares(2);

            Assert.AreEqual(1, area.InHectares());
            Assert.AreEqual(2, area2.InHectares());
        }

        [TestMethod]
        public void AreaInAcresMustBeReturnAcresOfArea()
        {
            var area = Area.FromSquareMeters(4046.856422m);
            var area2 = Area.FromAcres(2);

            Assert.AreEqual(1, area.InAcres());
            Assert.AreEqual(2, area2.InAcres());
        }

        [TestMethod]
        public void AreaInAlqueiresDoNorteMustBeReturnAlqueiresDoNorteOfArea()
        {
            var area = Area.FromSquareMeters(27000.225m);
            var area2 = Area.FromAlqueiresDoNorte(2);

            Assert.AreEqual(1, area.InAlqueiresDoNorte());
            Assert.AreEqual(2, area2.InAlqueiresDoNorte());
        }

        [TestMethod]
        public void AreaInAlqueiresPaulistaMustBeReturnAlqueiresPaulistaOfArea()
        {
            var area = Area.FromSquareMeters(24000.200m);
            var area2 = Area.FromAlqueiresPaulista(2);

            Assert.AreEqual(1, area.InAlqueiresPaulista());
            Assert.AreEqual(2, area2.InAlqueiresPaulista());
        }

        [TestMethod]
        public void AreaInAlqueiresMineiroMustBeReturnAlqueiresMineiroOfArea()
        {
            var area = Area.FromSquareMeters(48000.400m);
            var area2 = Area.FromAlqueiresMineiro(2);

            Assert.AreEqual(1, area.InAlqueiresMineiro());
            Assert.AreEqual(2, area2.InAlqueiresMineiro());
        }

        [TestMethod]
        public void MustBePossibleSumTwoAreas()
        {
            var area = Area.FromSquareMeters(10);
            var area2 = Area.FromSquareMeters(10);

            var expected = Area.FromSquareMeters(20);

            Assert.AreEqual(expected, area + area2);
        }

        [TestMethod]
        public void MustBePossibleSumAnAreaWithSquareMeters()
        {
            var area = Area.FromSquareMeters(10);

            var expected = Area.FromSquareMeters(20);

            Assert.AreEqual(expected, area + 10);
        }

        [TestMethod]
        public void MustBePossibleSubtractTwoAreas()
        {
            var area = Area.FromSquareMeters(10);
            var area2 = Area.FromSquareMeters(5);

            var expected = Area.FromSquareMeters(5);

            Assert.AreEqual(expected, area - area2);
        }

        [TestMethod]
        public void MustBePossibleSubtractSquareMetersFromAnArea()
        {
            var area = Area.FromSquareMeters(10);

            var expected = Area.FromSquareMeters(5);

            Assert.AreEqual(expected, area - 5);
        }

        [TestMethod]
        public void MustBePossibleMultiplyTwoAreas()
        {
            var area = Area.FromSquareMeters(10);
            var area2 = Area.FromSquareMeters(10);

            var expected = Area.FromSquareMeters(100);

            Assert.AreEqual(expected, area * area2);
        }

        [TestMethod]
        public void MustBePossibleMultiplyAnAreaToADecimalNumber()
        {
            var area = Area.FromSquareMeters(10);

            var expected = Area.FromSquareMeters(100);

            Assert.AreEqual(expected, area * 10);
        }

        [TestMethod]
        public void MustBePossibleDivideTwoAreas()
        {
            var area = Area.FromSquareMeters(100);
            var area2 = Area.FromSquareMeters(50);

            var expected = Area.FromSquareMeters(2);

            Assert.AreEqual(expected, area / area2);
        }

        [TestMethod]
        public void MustBePossibleDivideAnAreaToADecimalNumber()
        {
            var area = Area.FromSquareMeters(100);

            var expected = Area.FromSquareMeters(2);

            Assert.AreEqual(expected, area / 50);
        }

        [TestMethod]
        public void MustBePossibleCompareIfAnAreaIsGreaterOrEqualOtherArea()
        {
            var area = Area.FromSquareMeters(100);
            var area2 = Area.FromSquareMeters(50);
            var area3 = Area.FromSquareMeters(100);

            Assert.IsTrue(area >= area2);
            Assert.IsTrue(area >= area3);
            Assert.IsFalse(area2 >= area3);
        }

        [TestMethod]
        public void MustBePossibleCompareIfAnAreaIsLessThanOrEqualOtherArea()
        {
            var area = Area.FromSquareMeters(50);
            var area2 = Area.FromSquareMeters(50);
            var area3 = Area.FromSquareMeters(100);

            Assert.IsTrue(area <= area2);
            Assert.IsTrue(area <= area3);
            Assert.IsFalse(area3 <= area2);
        }

        [TestMethod]
        public void MustBePossibleCompareIfAnAreaIsGreaterThanOtherArea()
        {
            var area = Area.FromSquareMeters(100);
            var area2 = Area.FromSquareMeters(50);

            Assert.IsTrue(area > area2);
            Assert.IsFalse(area2 > area);
        }

        [TestMethod]
        public void MustBePossibleCompareIfAnAreaIsLessThanOtherArea()
        {
            var area = Area.FromSquareMeters(50);
            var area2 = Area.FromSquareMeters(100);

            Assert.IsTrue(area < area2);
            Assert.IsFalse(area2 < area);
        }
    }
}
