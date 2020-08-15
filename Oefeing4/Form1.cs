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

        public List<string> myNotitieLijst = new List<string>();
        public int teller = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btVoeg_Click(object sender, EventArgs e)
        {
            listBoxNB.Items.Add($"Notitie {teller++}");
            myNotitieLijst.Add(teller.ToString());
        }

        private void btLami_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btUit.Enabled = false;
            btVoeg.Enabled = false;
            btLami.Enabled = false;
            txtBijsc.Enabled = false;
           
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            myNotitieLijst[listBoxNB.SelectedIndex] += " " + txtBijsc.Text;
            txtBijsc.Clear();
            txtBnotitie.Text = myNotitieLijst[listBoxNB.SelectedIndex];

        }

        private void btUit_Click(object sender, EventArgs e)
        {
            myNotitieLijst.RemoveAt(listBoxNB.SelectedIndex);
            listBoxNB.Items.Remove(listBoxNB.SelectedItem);
            txtBnotitie.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxNB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNB.SelectedIndex >= 0)
                txtBnotitie.Text = myNotitieLijst[listBoxNB.SelectedIndex];

        }
    }
   
}
