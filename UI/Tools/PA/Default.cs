using System.Web.UI;
using UnitTesting.BLL.Tools.PA;

namespace UnitTesting.UI.Tools.PA
{
    public class Default : Page
    {
        public float Divide(int dividend, int divisor)
        {
            Calculator calculator = new Calculator();
            return calculator.Divide(dividend, divisor);
        }

        public int Add(int num1, int num2)
        {
            Calculator calculator = new Calculator();
            return calculator.Add(num1, num2);
        }
    }
}
