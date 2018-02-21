using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class task5 : Form
    {
        int cntr = 13, cntl = 0;
        public task5()
        {
            InitializeComponent();
        }

        private void LR_Click(object sender, EventArgs e)
        {
            cntl -= ListLeft.SelectedItems.Count;
            cntr += ListLeft.SelectedItems.Count;
            LeftCnt.Text = (cntl).ToString();
            RightCnt.Text = (cntr).ToString();
            foreach (var i in ListLeft.SelectedItems)
            {
                ListRight.Items.Add(i);
            }
            while (ListLeft.SelectedItems.Count > 0)
            {
                ListLeft.Items.Remove(ListLeft.SelectedItems[0]);
            }
        }

        private void AllRL_Click(object sender, EventArgs e)
        {
            cntl += cntr;
            cntr = 0;
            RightCnt.Text = (cntr).ToString();
            LeftCnt.Text = (cntl).ToString();
            foreach (var i in ListRight.Items) {
                ListLeft.Items.Add(i);
            }
            ListRight.Items.Clear();
        }

        private void AllLR_Click(object sender, EventArgs e)
        {
            cntr += cntl;
            cntl = 0;
            LeftCnt.Text = (cntl).ToString();
            RightCnt.Text = (cntr).ToString();
            foreach (var i in ListLeft.Items)
            {
                ListRight.Items.Add(i);
            }
            ListLeft.Items.Clear();
        }

        private void RL_Click(object sender, EventArgs e)
        {
            cntr -= ListRight.SelectedItems.Count;
            cntl += ListRight.SelectedItems.Count;
            RightCnt.Text = (cntr).ToString();
            LeftCnt.Text = (cntl).ToString();
            foreach (var i in ListRight.SelectedItems) {
                ListLeft.Items.Add(i);
            }
            while (ListRight.SelectedItems.Count > 0)
            {
                ListRight.Items.Remove(ListRight.SelectedItems[0]);
            }
        }
    }
}
