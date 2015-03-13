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
    }
}