
using CalculatorProject;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {
        public TestContext? TestContext { get; set; }

        [TestMethod]
        public void CalculatorProjectAdd_2_4_returns_6()
        {
            int x;
            int y;

			y = (int)Convert.ChangeType(TestContext?.Properties["ValueY"]?.ToString(), typeof(int));
			x = (int)Convert.ChangeType(TestContext?.Properties["ValueX"]?.ToString(), typeof(int));

			Calculator c = new Calculator();
            int result = c.Add(x, y);
            Assert.AreEqual(14, result);
        }
    }
}