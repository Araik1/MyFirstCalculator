using System;
using System.IO;
using System.Windows.Forms;

namespace MyFirstCalculator
{
    public partial class History : Form
    {
        private string history = "";
        private string path = @"Журнал.txt";

        public string Path
        {
            get => path;
            set => path = value;
        }

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        textBox1.Text += line + @" " + Environment.NewLine;

                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                using (StreamWriter s = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    s.Write("");
                }
            }

        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textBox1.Text += line + @" " + Environment.NewLine;
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            using (StreamWriter s = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                s.Write("");
            }
            textBox1.ResetText();
        }

        private void History_Load_1(object sender, EventArgs e) {}
    }
}
