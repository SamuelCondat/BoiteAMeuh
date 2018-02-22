using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoiteAMeuh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<string> mylist = new List<string>(new string[] {"Veaux", "Vaches", "Génisses",
                "Taureaux", "Cochons", "Poulet", "Chapons", "Oies", "Dindes" });

            foreach (string item in mylist)
            {
                listBox1.Items.Add(item);
            }
        }

        string bidule;

        public void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            bidule = (string)listBox1.SelectedItem;
            DragDropEffects Event;

            if (radioButton1.Checked)
            {
              Event = DragDropEffects.Copy;
            }
            else
            {
               Event = DragDropEffects.Move;
            }

            listBox1.DoDragDrop("Pouet", Event);
        }

        public void textBox1_DragEnter(object sender, DragEventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        public void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            textBox1.Text = bidule;

            if (radioButton1.Checked == false)
            {
                listBox1.Items.Remove(bidule);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
