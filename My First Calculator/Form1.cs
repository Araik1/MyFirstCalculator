using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace MyFirstCalculator
{
    public partial class calculator : Form
    {
        private System.Drawing.Point mouseOffset;
        private bool isMouseDown = false;

        readonly History his = new History();

        bool res = false;
        string operate;
        calculate c = new calculate();

        public calculator()
        {
            InitializeComponent();
        }

        private void calc_Load(object sender, System.EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new System.Drawing.Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                System.Drawing.Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {

            labelResult.Text = "";
            labelFirst.Text = "";
            operate = "";

        }

        private void digit_pressed(object sender, EventArgs e)
        {
            if (res) //получен ли результат
            {
                labelResult.Text = "";
                res = false;
            }

            Button button = (Button)sender;
            if (labelResult.Text.Length < 14)
            {
                labelResult.Text += button.Text;
            }
        }

        private void unary_operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "±":
                    try
                    {
                        labelResult.Text = Convert.ToString(Convert.ToDouble(labelResult.Text) * -1);
                    }
                    catch
                    {
                        clearData();
                    }
                    break;

                case ",":
                    if (!labelResult.Text.Contains(","))
                        if (labelResult.Text == "")
                        {
                            labelResult.Text += "0,";
                        }
                        else
                        {
                            labelResult.Text += ",";
                        }
                    break;
            }
        }

        private void binary_operation(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                if (labelResult.Text != "")
                {
                    operate = button.Text;

                    labelFirst.Text = labelResult.Text + operate;
                    labelResult.Text = "";
                }
            }
            catch
            {
                clearData();
            }
        }

        private void trig_operation(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                operate = "t";

                labelFirst.Text = button.Text + @"(" + labelResult.Text + @")";

                if ((button.Text == "sin" || button.Text == "cos" || button.Text == "tan") && checkBox_deg.Checked)
                {
                    //если надо в градусах
                    labelResult.Text = Convert.ToString(Math.Round(Convert.ToDouble(c.res(Convert.ToString(Convert.ToDouble(labelResult.Text) * Math.PI / 180) + operate + button.Text)), 5));
                    labelFirst.Text += "°";
                }
                else
                {
                    labelResult.Text = Convert.ToString(Math.Round(Convert.ToDouble(c.res(labelResult.Text + operate + button.Text)), 5));
                }

                labelFirst.Text += @"=" + labelResult.Text + '\n';
                using (var sw = new StreamWriter(his.Path, true, System.Text.Encoding.Default))
                {
                    sw.Write(labelFirst.Text);
                }
            }
            catch
            {
                clearData();
            }
        }

        private void buttonEqually_Click(object sender, EventArgs e)
        {
            try
            {
                labelFirst.Text += labelResult.Text;
                labelResult.Text = c.res(labelFirst.Text);

                labelFirst.Text += @"=" + labelResult.Text + '\n';
                using (var sw = new StreamWriter(his.Path, true, System.Text.Encoding.Default))
                {
                    sw.Write(labelFirst.Text);
                }

                labelFirst.Text = "";
                operate = "";
                res = true;
            }
            catch (DivideByZeroException)
            {
                labelResult.Text = "Ошибка!";
            }
            catch
            {
                //clearData();
            }
        }

        private void math_const(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Text)
            {
                case "Pi":
                    labelResult.Text = Convert.ToString(Math.PI);
                    break;
                case "e":
                    labelResult.Text = Convert.ToString(Math.E);
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void buttonMult_KeyDown(object sender, EventArgs e) { }

        private void calculator_KeyPress(object sender, KeyPressEventArgs e) { }

        private void calculator_KeyDown(object sender, KeyEventArgs e)
        {
            Key(sender, e);
        }

        //Выводит соответствующую клавишу 0-9, ввод с клавиатуры
        void printNum(int str)
        {
            labelResult.Text += Convert.ToString(str - 96);
        }

        //Выводит соответствующую клавишу /, *, -, +, ввод с клавиатуры
        void printOperation(int str)
        {
            labelFirst.Text += labelResult.Text + Convert.ToChar(str - 64);
            labelResult.Text = "";
        }

        private void Key(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.NumPad1) || (e.KeyCode == Keys.NumPad2) || (e.KeyCode == Keys.NumPad3) || (e.KeyCode == Keys.NumPad4)
                 || (e.KeyCode == Keys.NumPad5) || (e.KeyCode == Keys.NumPad6) || (e.KeyCode == Keys.NumPad7) || (e.KeyCode == Keys.NumPad8)
                 || (e.KeyCode == Keys.NumPad9) || (e.KeyCode == Keys.NumPad0))
            {
                printNum(e.KeyValue);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                clearData();
            }
            else if ((e.KeyCode == Keys.Add) || (e.KeyCode == Keys.Subtract) || (e.KeyCode == Keys.Multiply) || (e.KeyCode == Keys.Divide))
            {
                printOperation(e.KeyValue);
            }
            else if (e.KeyValue == 110)
            {
                if (!labelResult.Text.Contains(","))
                    if (labelResult.Text == "")
                    {
                        labelResult.Text += "0,";
                    }
                    else
                    {
                        labelResult.Text += ",";
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!his.IsDisposed)
            {
                his.Show();
            }
            else if (!his.Created)
            {
                History his = new History();
                his.Show();
            }
        }
    }
}
