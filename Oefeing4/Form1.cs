using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefeing4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> NotitieLijst = new List<string>();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVoeg_Click(object sender, EventArgs e)
        {
            if (txtNotitename.Text != "")
            {
                NotitieLijst.Add(txtNotitename.Text);
                listBoxNB.Items.Add(txtNotitename.Text);
                txtNotitename.Clear();
            }
            //NotitieLijst.Add(txtNotitename.Text);
            //listBoxNB.Items.Add(txtNotitename.Text);
            //txtNotitename.Clear();
        }

        private void btLami_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btUit.Enabled = false;
            btVoeg.Enabled = false;
            btLami.Enabled = false;
            txtBijsc.Enabled = false;
            txtNotitename.Enabled = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {


        }

        private void btUit_Click(object sender, EventArgs e)
        {
            listBoxNB.Items.Remove(listBoxNB.SelectedItem);
        }
    }
   
}
