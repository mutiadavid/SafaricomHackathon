using Microsoft.VisualStudio.TestTools.UnitTesting;
using SafaricomHackathon.LeftRotation;

namespace SafaricomHackathon.LeftRotationTests
{
    [TestClass]
    public class LeftRotationUnitTest
    {
        [TestMethod]
        public void TestRotateToLeft()
        {
            var arrayToTest = new int[] { 1, 2, 3, 4 };
            var n = 2;
            var expectedResult = new int[] { 3, 4, 1, 2 };
            var rotation = new Rotation();
            var result = rotation.RotateToLeft(arrayToTest,n);
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}
