using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAPD
{
    public partial class Setari : UserControl
    {
        public Setari()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;
            for (int i = 0; i < count; ++i)
            {
                if (index != i)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
               
            }
            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked)
            {
                HomeCenter.Instance.BackColor = Color.FromArgb(53, 49, 49);
            }
            else if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked)
            {
                HomeCenter.Instance.BackColor = Color.FromArgb(255, 255, 255);
            }

        }
    }
}
