/*
* Program: FtoC_C#
* Purpose: Converts a temperature to Celsius or Fahrenheit
* Author: Mark Albanese
* Date: 29 March 2013
* Version: 1.0
* Release: 1
* Language: C#
* Compiler: Visual Studios 2010
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FtoC_CS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {    
            try
            {
                if (txt_temperature.Text!="")
                {
                    double temperature = Double.Parse(txt_temperature.Text);

                    if (radCelsius.Checked)
                    {
                        temperature = (temperature - 32) * 5 / 9;
                        txt_result.Text = temperature.ToString("0.000000");
                    }
                    else if (radFahrenheit.Checked)
                    {
                        temperature = temperature * 9 / 5 + 32;
                        txt_result.Text = temperature.ToString("0.000000");
                    }

                }
                else
                {
                  MessageBox.Show("Please insure the temperature entered is valid.",
                         "Celsius to Fahrenheit",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please insure the temperature entered is valid.",
                        "Celsius to Fahrenheit",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
            txt_temperature.Text = "";
        }
    }
}
