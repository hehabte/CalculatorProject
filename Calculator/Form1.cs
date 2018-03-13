using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HHabteHW5._5
{
    public partial class Form1 : Form
    {
        private decimal inputinterger;
        private bool add; //determining if we are adding or subtracting
        private bool multiply; //determining if we are multiplying or dividing

        public Form1 ( )
        {
            InitializeComponent();
        }

        private void Form1_Load ( object sender, EventArgs e )
        {
            
        }


        //Button Functions
        private void oneButton_Click ( object sender, EventArgs e )
        {
            outputTextBox.AppendText("1");
        }

        private void twoButton_Click ( object sender, EventArgs e )
        {
            outputTextBox.AppendText("2");
        }

        private void threeButton_Click ( object sender, EventArgs e )
        {
            outputTextBox.AppendText("3");
        }

        private void fourButton_Click ( object sender, EventArgs e )
        {
            outputTextBox.AppendText("4");
        }
    
        //ErrorMessageFunction

        public Boolean ErrorMessageFunc ( )
        {
            if (outputTextBox.Text == "")
            {
                messagelabel.Text = "Click Clear";
                messagelabel.Visible = true;
                return true;
            }

            return false;
        }
        
        //state functions when choosing mathmatical operations
        private void addButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;

            inputinterger = decimal.Parse(outputTextBox.Text);
            add = true;
            multiply = false;
            outputTextBox.Clear();
        }

        private void multipleButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;
            
            inputinterger = decimal.Parse(outputTextBox.Text);
            multiply = true;
            add = false;
            outputTextBox.Clear();
        }

        private void subButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;
            
            inputinterger = decimal.Parse(outputTextBox.Text);
            add = false;
            multiply = false;
            outputTextBox.Clear();
        }

        private void divideButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;

            inputinterger = decimal.Parse(outputTextBox.Text);
            multiply = true;
            add = true;
            outputTextBox.Clear();
        }

        //computation button "="
        private void compButton_Click ( object sender, EventArgs e )
        {
            //Determing the correct computation w/ [multiply, add] booleans
                //[multiply, add]
                // true, false = multiply
                // false, true = addition
                // false, false = subtraction
                // true, true = division

            if (add && !multiply)
            {
                inputinterger += decimal.Parse(outputTextBox.Text);
                outputTextBox.Text = inputinterger.ToString();
            }
            else if (multiply && !add)
            {
                //System.Diagnostics.Debug.WriteLine(multiply + "-" + inputinterger + "-" + outputTextBox.Text);
                inputinterger *= decimal.Parse(outputTextBox.Text);
                outputTextBox.Text = inputinterger.ToString();
            }
            else if (multiply && add)
            {
                //System.Diagnostics.Debug.WriteLine(inputinterger);
                //System.Diagnostics.Debug.WriteLine(outputTextBox.Text);
                inputinterger = inputinterger / (decimal.Parse(outputTextBox.Text));

                //System.Diagnostics.Debug.WriteLine(inputinterger);
                outputTextBox.Text = inputinterger.ToString("##.####");
            }
            else if (!multiply && !add)
            {
                inputinterger -= decimal.Parse(outputTextBox.Text);
                outputTextBox.Text = inputinterger.ToString();
            }   

        }

        private void clearButton_Click ( object sender, EventArgs e )
        {
            messagelabel.Visible = false;
            outputTextBox.Clear();
        }

        private void exitButton_Click ( object sender, EventArgs e )
        {
            Application.Exit();
        }

    }
}
