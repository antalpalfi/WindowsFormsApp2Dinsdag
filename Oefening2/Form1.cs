using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtNaam.Text,txtAdres.Text);
            //MessageBox.Show(numAge.Value.ToString());
            if (rdWestVlanderen.Checked)
            {
                if (rdMale.Checked)
                    MessageBox.Show("Jij bent een man!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "WestVlanderen");
                else
                    MessageBox.Show("Jij bent een vrouw!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text+" "+ "WestVlanderen");
            }
            if (rdOostvlanderen.Checked)
            {
                if (rdMale.Checked)
                    MessageBox.Show("Jij bent een man!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Oostvlanderen");
                else
                    MessageBox.Show("Jij bent een vrouw!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Oostvlanderen");
            }

            if (rdBrussel.Checked)
            {
                if (rdMale.Checked)
                    MessageBox.Show("Jij bent een man!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Brussel");
                else
                    MessageBox.Show("Jij bent een vrouw!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Brussel");
            }
            if (rdBrabant.Checked)
            {
                if (rdMale.Checked)
                    MessageBox.Show("Jij bent een man!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Brabant");
                else
                    MessageBox.Show("Jij bent een vrouw!", "Hello" + " " + txtNaam.Text + "!!! " + "Je bent" + numAge.Value.ToString() + " " + "old" + ". " + "Je woont in" + " " + txtAdres.Text + " " + "Brabant");
            }
        }

        private void rdVrouw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTime.Value.ToString());
        }
    }
}
