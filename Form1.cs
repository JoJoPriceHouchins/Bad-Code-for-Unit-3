using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void HelloButton_Click(object sender, EventArgs e)
        {
            outputLabel = ToString ("Hello, " + textBox1.Text + "!");
        }

        private Label ToString(string v)
        {
            throw new NotImplementedException();
        }

        private void GoodbyeButton_Click(object sender, EventArgs e)
        {
            outputLabel = ToString ("Goodbye, " + textBox1.Text + "!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
