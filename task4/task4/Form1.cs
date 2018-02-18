using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            Out.Text = "";
            string cur = In.Text;
            if (cur.Length != 1 || !Char.IsLetter(cur[0]))
            {
                MessageBox.Show(this, "Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (string i in List.Items)
                {
                    if (Char.ToUpper(i[0]) == Char.ToUpper(cur[0])) {
                        Out.Text += i + "\n";
                    }
                }
            }
        }
    }
}
