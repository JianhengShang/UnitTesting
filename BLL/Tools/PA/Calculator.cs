using System;

namespace UnitTesting.BLL.Tools.PA
{
    public class Calculator
    {
        public float Divide(int dividend, int divisor)
        {
            float result;
            if (divisor != 0)
            {
                result = (float)dividend / divisor;
            }
            else
            {
                throw new ArgumentException("divisor cannot be 0.");
            }

            return result;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
