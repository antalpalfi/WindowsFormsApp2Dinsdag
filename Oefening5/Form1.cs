using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Oefening5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(fileName))
            {
                File.Create(fileName);

            }
        }
        public string fileName = "text.txt";
        private void btAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtAdd.Text);
            txtAdd.Clear();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
               
            }
        }
    }
}
