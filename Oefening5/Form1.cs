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
    public partial class txtFileName : Form
    {
        public txtFileName()
        {
            InitializeComponent();
            //if (!File.Exists(fileName))
            //{
            //    File.Create(fileName);
            //igy is lehet
            //}
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
            using (StreamWriter writer = new StreamWriter($"{textName.Text}.txt")) // ezzel irunk a fajlba
            {
                foreach (var item in listBox1.Items) // minden elemet hozza adunk a fajlhoz
                {
                    writer.WriteLine(item);
                }
            }
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!File.Exists($"{textName.Text}.txt"))
            {
                File.Create($"{textName.Text}.txt").Dispose(); //Dispose bezarja a fajlt. Mindig be kell zarni kulonben hiba kod lesz
            }
            using (StreamReader reader = new StreamReader($"{textName.Text}.txt")) // igy olvasunk ki a fajlbol
            {
                while (! reader.EndOfStream) // hozza adjuk az osszes elemet a txt.fajlhoz
                {
                    listBox1.Items.Add(reader.ReadLine());
                }
            }
        }
    }
}
