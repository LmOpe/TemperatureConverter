using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
            lblDate.Text = DateTime.Now.ToString("dddd      dd MMM, yyyy");
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double result;
            if(double.TryParse(CelsiusTextBox.Text, out result))
            {
                double celsiusValue = double.Parse(CelsiusTextBox.Text);
                result = (celsiusValue * 9 / 5) + 32;
                FahrenheitTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a numeric value!!", "Error Detected in Input", MessageBoxButtons.OK);
            }
        }
    }
}
