using System;

namespace UnitTesting.Tools.PA
{
    public partial class Default : UnitTesting.UI.Tools.PA.Default
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string dividend = this.TextBox1.Text;
            string divisor = this.TextBox2.Text;
            int tmpDividend = 0;
            int tmpDivisor = 0;
            Int32.TryParse(dividend, out tmpDividend);
            Int32.TryParse(divisor, out tmpDivisor);

            this.Label1.Text = base.Divide(tmpDividend, tmpDivisor).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string num1 = this.TextBox3.Text;
            string num2 = this.TextBox4.Text;
            int tmpNumber1 = 0;
            int tmpNumber2 = 0;
            Int32.TryParse(num1, out tmpNumber1);
            Int32.TryParse(num2, out tmpNumber2);

            this.Label2.Text = base.Add(tmpNumber1, tmpNumber2).ToString();
        }
    }
}