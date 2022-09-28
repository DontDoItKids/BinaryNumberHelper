namespace BinaryNumberHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk8_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk16_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk32_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk64_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }

        private void chk128_CheckedChanged(object sender, EventArgs e)
        {
            //convert the text status of the checkbox which will be a boolean a true or false turn it into a 1 or 0
            int bin1 = Convert.ToInt32(chk1.Checked);
            int bin2 = Convert.ToInt32(chk2.Checked);
            int bin4 = Convert.ToInt32(chk4.Checked);
            int bin8 = Convert.ToInt32(chk8.Checked);
            int bin16 = Convert.ToInt32(chk16.Checked);
            int bin32 = Convert.ToInt32(chk32.Checked);
            int bin64 = Convert.ToInt32(chk64.Checked);
            int bin128 = Convert.ToInt32(chk128.Checked);

            //Display in each label for Binary
            lbl1.Text = bin1.ToString();
            lbl2.Text = bin2.ToString();
            lbl4.Text = bin4.ToString();
            lbl8.Text = bin8.ToString();
            lbl16.Text = bin16.ToString();
            lbl32.Text = bin32.ToString();
            lbl64.Text = bin64.ToString();
            lbl128.Text = bin128.ToString();

            //setup each number
            int one = bin1 * 1;
            int two = bin2 * 2;
            int four = bin4 * 4;
            int eight = bin8 * 8;
            int sixteen = bin16 * 16;
            int thirtytwo = bin32 * 32;
            int sixtyfour = bin64 * 64;
            int onetwentyeight = bin128 * 128;

            //Add them together
            int result = one + two + four + eight + sixteen + thirtytwo + sixtyfour + onetwentyeight;

            //Display the result
            lblNumberValue.Text = result.ToString();
        }
    }
}