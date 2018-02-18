using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void In_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenStr_Click(object sender, EventArgs e)
        {
            int cur;
            if (Int32.TryParse(In.Text, out cur))
            {
                if (cur > 32)
                {
                    MessageBox.Show(this, "Number is too big!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string str = "";
                    if ((cur & 1) == 1)
                    {
                        str = "1";
                    }
                    else
                    {
                        str = "2";
                    }
                    for (int i = 3; i <= cur; i += 2)
                    {
                        str += "*" + (i + 1 - (cur & 1)).ToString();
                    }
                    Out.Text = str;
                }
            }
            else
            {
                MessageBox.Show(this, "Not a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
