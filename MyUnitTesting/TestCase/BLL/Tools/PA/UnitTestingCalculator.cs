using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.BLL.Tools.PA;

namespace MyUnitTesting.TestCase.BLL.Tools.PA
{
    [TestClass]
    public class UnitTestingCalculator
    {
        public UnitTestingCalculator()
        {
            //
            //TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        /// Gets or sets the test context which provides
        /// information about and functionality for current test run.
        /// </summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"BLL\Tools\PA\UnitTestingCalculatorDataResultTest.csv", "UnitTestingCalculatorDataResultTest#csv", DataAccessMethod.Sequential)]
        public void UnitTestingCalculator_Divide()
        {
            int dividend = Int32.Parse(this.testContextInstance.DataRow["dividend"].ToString());
            int divisor = Int32.Parse(this.testContextInstance.DataRow["divisor"].ToString());
            float output = float.Parse(this.testContextInstance.DataRow["output"].ToString());

            Calculator calculator = new Calculator();
            float result = calculator.Divide(dividend, divisor);

            Assert.AreEqual(output, result);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @"BLL\Tools\PA\UnitTestingCalculator_AddDataResultTest.csv", "UnitTestingCalculator_AddDataResultTest#csv", DataAccessMethod.Sequential)]
        public void UnitTestingCalculator_Add()
        {
            int number1 = Int32.Parse(this.testContextInstance.DataRow["number1"].ToString());
            int number2 = Int32.Parse(this.testContextInstance.DataRow["number2"].ToString());
            int output = Int32.Parse(this.testContextInstance.DataRow["output"].ToString());

            Calculator calculator = new Calculator();
            int result = calculator.Add(number1, number2);

            Assert.AreEqual(output, result);
        }
    }
}
