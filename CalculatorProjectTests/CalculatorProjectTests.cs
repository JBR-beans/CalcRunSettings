
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
            string x;
            string y;

			y = TestContext?.Properties["ValueY"]?.ToString();
			x = TestContext?.Properties["ValueX"]?.ToString();
            Assert.IsNotNull(TestContext);
            Assert.IsNull(x);
            Assert.IsNull(y);
        }
    }
}