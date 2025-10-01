using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComplexCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void CE_Click(object sender, EventArgs e)
        {
            box.Text = "0";
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (box.Text.Length > 1)
            {
                box.Text = box.Text.Substring(0, box.Text.Length - 1);
            }
            else
            {
                box.Text = "0";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (box.Text != "0")
                box.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "1";
            else
                box.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "2";
            else
                box.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "3";
            else
                box.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "4";
            else
                box.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "5";
            else
                box.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "6";
            else
                box.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "7";
            else
                box.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "8";
            else
                box.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (box.Text == "0")
                box.Text = "9";
            else
                box.Text += "9";
        }

        private void dota_Click(object sender, EventArgs e)
        {
            if (!box.Text.EndsWith("."))
                box.Text += ".";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            if (box.Text.Length != 0 && char.IsDigit(box.Text.Last()))
                box.Text += "+";
        }

        private void diff_Click(object sender, EventArgs e)
        {
            if (box.Text.Length != 0 && char.IsDigit(box.Text.Last()))
            {
                if (box.Text == "0")
                    box.Text = "-";
                else
                    box.Text += "-";
            }

        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (box.Text.Length != 0 && char.IsDigit(box.Text.Last()))
                box.Text += "x";
        }
        private void div_Click(object sender, EventArgs e)
        {
            if (box.Text.Length != 0 && char.IsDigit(box.Text.Last()))
                box.Text += "/";
        }
        private void mood_Click(object sender, EventArgs e)
        {
            if (box.Text.Length != 0 && char.IsDigit(box.Text.Last()))
                box.Text += "%";
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double result = double.Parse(box.Text);
                if (result < 0)
                {
                    MessageBox.Show("Mənfi ədədden kvadrat kök alınmır!");
                    return;
                }
                result = Math.Sqrt(result);
                box.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Düzgün ədəd daxil edin");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = box.Text.Replace("x", "*").Replace(",", ".");
                if (expression.Contains("/0"))
                {
                    MessageBox.Show("0-a bölmək mümkün deyil!");
                    return;
                }

                var result = new System.Data.DataTable().Compute(expression, null);
                box.Text = result.ToString();
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Daxil edilmiş ifadə düzgün deyil.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
        }
        double firstNumber = 0;

        private void mood_Click_1(object sender, EventArgs e) // % düyməsi
        {

        }

    }
}







