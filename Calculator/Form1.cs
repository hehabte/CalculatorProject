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
        private string operation;

           
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
            operation = "add";
            outputTextBox.Clear();
        }

        private void multipleButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;
            
            inputinterger = decimal.Parse(outputTextBox.Text);
            operation = "multiply";
            outputTextBox.Clear();
        }

        private void subButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;
            
            inputinterger = decimal.Parse(outputTextBox.Text);
            operation = "subtract";
            outputTextBox.Clear();
        }

        private void divideButton_Click ( object sender, EventArgs e )
        {
            if (ErrorMessageFunc())
                return;

            inputinterger = decimal.Parse(outputTextBox.Text);
            operation = "divide";
            outputTextBox.Clear();
        }

        //computation button "="
        private void compButton_Click ( object sender, EventArgs e )
        {
            switch(operation)       
            {         
               case "add":   
                    inputinterger += decimal.Parse(outputTextBox.Text);
               break;    
                
               case "subtract:            
                    inputinterger -= decimal.Parse(outputTextBox.Text);
               break;      
                  
               case "divide":            
                    inputinterger = inputinterger / (decimal.Parse(outputTextBox.Text));
               break;
                
               case "multiply":
                     inputinterger *= decimal.Parse(outputTextBox.Text);
               break;
                  
               default:            
                  Console.WriteLine("Invalid selection!");            
               break;      
             }
             
             outputTextBox.Text = inputinterger.ToString();
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
