using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exPolymorhpine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object obj;
            if (rbA.Checked)
            {
                obj = new A();
            }
           else if (rbB.Checked)
            {
                obj = new B();
            }
            else
            {
                obj = new C();
            }

            if (obj is B)
            {
                Text.Text = "Obj är av typ B";
            }
            if (obj is A)
            {
                Text.Text = "Obj är av typ A";
            }
            if (obj is C)
            {
                Text.Text = "Obj är av typ C";
            }
        }
    }
}
