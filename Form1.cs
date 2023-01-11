using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFFM_Technical_Exercises
{
    public partial class Form1 : Form
    {
        private string lowerValue;
        private string upperValue;
        public Form1()
        {
            InitializeComponent();
        }

        public void runButton_Click(object sender, EventArgs e)
        {

            lowerValue = lowerText.Text;
            upperValue = upperText.Text;
            //MessageBox.Show("Low Value = " + lowerValue + " and High Value = " + upperValue);
            try
            {
                int lowVal = Int32.Parse(lowerValue);
                int highVal = Int32.Parse(upperValue);

                for (int i = lowVal; i <= highVal; i++)
                {
                    if ((i % 3 == 0) && (i % 7 == 0))
                    {
                        displayResults.Text += "Goldy Gopher" + Environment.NewLine;
                    } else if (i % 3 == 0)
                    {
                        displayResults.Text += "Goldy" + Environment.NewLine;
                    } else if (i % 7 == 0)
                    {
                        displayResults.Text += "Gopher" + Environment.NewLine;
                    }
                    else
                    {
                        displayResults.Text += i.ToString() + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
