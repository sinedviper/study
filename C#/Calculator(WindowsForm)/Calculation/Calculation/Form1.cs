using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
                if (m == 0) {
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button21.Enabled = false;
                }
            memory.Text = "M = " + m;
        }

        public double a,b,c,m,p;
        public int operation;
        //Button number
        private void buttonNumber(object sender, EventArgs e) {
            Button butt = (Button)sender;
            if (display.Text == "00")
                display.Text = "0";
           
            if (butt.Text == ",") {
                    if (!display.Text.Contains(","))
                        display.Text += butt.Text;
                } else display.Text += butt.Text;
            if (display.Text != "")
                button19.Enabled = true;
        }
        //Button operation
        private void negative(object sender, EventArgs e) {
            if (display.Text != "") {
                if (display.Text[0] == '-') {
                    display.Text = display.Text.Remove(0, 1);
                } else 
                    display.Text = "-" + display.Text;     
            }
        }
        private void clear(object sender, EventArgs e) {
            button19.Enabled = false;
            display.Clear();
            displayHistory.Text = "";
            a = 0;
            b = 0;
            c = 0;
            p = 0;
            operation = 0;
            button4.Enabled = true;
            button8.Enabled = true;
            button12.Enabled = true;
            button15.Enabled = true;
        }
        private void clearDisplay(object sender, EventArgs e) {
            button19.Enabled = false;
            display.Clear();
            a = 0;
            b = 0;
            c = 0;
            p = 0;
        }
        private void delete(object sender, EventArgs e) {
            try {
                string s = display.Text;
                s = s.Substring(0, s.Length - 1);
                display.Text = s;
                if (display.Text == "")
                    button19.Enabled = false;
            } catch (ArgumentOutOfRangeException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        private void division(object sender, EventArgs e) {
            try {
                a = Convert.ToDouble(display.Text);
                if (display.Text != "")
                    button19.Enabled = false;
                display.Clear();
                operation = 4;
                displayHistory.Text += a.ToString() + "/";
                button4.Enabled = false;
                button8.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
            } catch (FormatException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        private void multipclication(object sender, EventArgs e) {
            try {
                a = Convert.ToDouble(display.Text);
                if (display.Text != "")
                button19.Enabled = false;
                display.Clear();
                operation = 3;
                displayHistory.Text += a.ToString() + "*";
                button4.Enabled = false;
                button8.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
            } catch (FormatException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        private void minus(object sender, EventArgs e) {
            try {
                a = Convert.ToDouble(display.Text);
                if (display.Text != "")
                button19.Enabled = false;
                display.Clear();
                operation = 2;
                displayHistory.Text += a.ToString() + "-";
                button4.Enabled = false;
                button8.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
            } catch (FormatException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        private void plus(object sender, EventArgs e) {
            try {
                a = Convert.ToDouble(display.Text);
                if (display.Text != "")
                button19.Enabled = false;
                display.Clear();
                operation = 1;
                displayHistory.Text += a.ToString() + "+";
                button4.Enabled = false;
                button8.Enabled = false;
                button12.Enabled = false;
                button15.Enabled = false;
            } catch(FormatException){
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        private void procent(object sender, EventArgs e) {
            try {
                p = Convert.ToDouble(display.Text);
                p *= 0.01;
                display.Clear();
                display.Text = Convert.ToString(p);
            } catch (FormatException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                m = 0;
                p = 0;
                operation = 0;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            }
        }
        //Operation
        private void exactly(object sender, EventArgs e) {
            try {
                button19.Enabled = false;
                b = Convert.ToDouble(display.Text);
                switch (operation) {
                    case 1:
                        displayHistory.Text += b;
                        c = a + b;
                        display.Text = Convert.ToString(c);
                        displayHistory.Text += "=" + Convert.ToString(c) + ";\r\n";
                        a = 0;
                        b = 0;
                        c = 0;
                        p = 0;
                        button4.Enabled = true;
                        button8.Enabled = true;
                        button12.Enabled = true;
                        button15.Enabled = true;
                        break;
                    case 2:
                        displayHistory.Text += b;
                        c = a - b;
                        display.Text = Convert.ToString(c);
                        displayHistory.Text += "=" + Convert.ToString(c) + ";\r\n";
                        a = 0;
                        b = 0;
                        c = 0;
                        p = 0;
                        button4.Enabled = true;
                        button8.Enabled = true;
                        button12.Enabled = true;
                        button15.Enabled = true;
                        break;
                    case 3:
                        displayHistory.Text += b;
                        c = a * b;
                        display.Text = Convert.ToString(c);
                        displayHistory.Text += "=" + Convert.ToString(c) + ";\r\n";
                        a = 0;
                        b = 0;
                        c = 0;
                        p = 0;
                        button4.Enabled = true;
                        button8.Enabled = true;
                        button12.Enabled = true;
                        button15.Enabled = true;
                        break;
                    case 4:
                        displayHistory.Text += b;
                        c = a / b;
                        display.Text = Convert.ToString(c);
                        displayHistory.Text += "=" + Convert.ToString(c) + ";\r\n";
                        a = 0;
                        b = 0;
                        c = 0;
                        p = 0;
                        button4.Enabled = true;
                        button8.Enabled = true;
                        button12.Enabled = true;
                        button15.Enabled = true;
                        break;
                }
                display.Clear();
            } catch (FormatException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                c = 0;
                p = 0;
                m = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show(" An error occurred,\n Enter the data correctly");
            } catch (OverflowException) {
                display.Clear();
                displayHistory.Text += "(Error);\r\n";
                a = 0;
                b = 0;
                c = 0;
                p = 0;
                m = 0;
                operation = 0;
                button4.Enabled = true;
                button8.Enabled = true;
                button12.Enabled = true;
                button15.Enabled = true;
                MessageBox.Show("Too many numbers!");
            }
        }
        //Memory operation
        private void memoryMinus(object sender, EventArgs e) {
            try {
                if (display.Text == m.ToString()) {
                    m -= Convert.ToDouble(display.Text);
                    memory.Text = "M = " + m;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button21.Enabled = false;
                } else {
                    memory.Text = "";
                    m -= Convert.ToDouble(display.Text);
                    memory.Text = "M = " + m;
                }
            } catch (FormatException) {
                display.Clear();
                a = 0;
                b = 0;
                c = 0;
                p = 0;
                m = 0;
                operation = 0;
                button24.Enabled = false;
                button25.Enabled = false;
                button21.Enabled = false;
                MessageBox.Show("Error Memory");
            }
        }
        private void memoryPlus(object sender, EventArgs e) {
            try {
                if (display.Text != "0") {
                    m += Convert.ToDouble(display.Text);
                    memory.Text = "M = " + m;
                    button24.Enabled = true;
                    button25.Enabled = true;
                    button21.Enabled = true;
                } 
                if (m == 0) {
                    memory.Text = "M = " + m;
                    button24.Enabled = false;
                    button25.Enabled = false;
                    button21.Enabled = false;
                }
            } catch (FormatException) {
                MessageBox.Show("Error Memory");
            }
        }
        private void memoryRead(object sender, EventArgs e) {
            if (m != 0) 
                display.Text = Convert.ToString(m);           
        }
        private void memoryClean(object sender, EventArgs e) {
            m = 0;
            memory.Text = "M = " + m;
            button24.Enabled = false;
            button25.Enabled = false;
            button21.Enabled = false;
        }
    }
}