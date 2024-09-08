using ThreeSumInt;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [-1, 2, 1, -4];
            int target = 1;

            Solution solution = new Solution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [0, 0, 0];
            int target = 1;

            Solution solution = new Solution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = [-5, -7, -10, 3, 1, 2, 10];
            int target = -4;

            Solution solution = new Solution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.AreEqual(-4, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] nums = [-5, -7, -10, 3, 1, 2, 10];
            int target = -22;

            Solution solution = new Solution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.AreEqual(-22, result);
        }
    }
}