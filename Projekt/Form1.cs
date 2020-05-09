using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string inputTxt = textBox1.Text;
            var result = MessageBox.Show("Mesazhi i Perdoruesit : "+ inputTxt, "Mesazh",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Shutdown the painting of the ListBox as items are added.
                listBox1.BeginUpdate();
                // Loop through and add 50 items to the ListBox.
                for (int x = 1; x <= 50; x++)
                {
                    listBox1.Items.Add("Item " + x.ToString());
                }
                // Allow the ListBox to repaint and display the new items.
                listBox1.EndUpdate();
            }else
            { 
                this.label1.Visible = true; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string x = textBox2.Text;
            string y = textBox3.Text;
            double vlear = Convert.ToDouble(x) + Convert.ToDouble(y);
            textBox4.Text = vlear.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (object itemChecked in checkedListBox1.Items)
            {
                if (itemChecked.ToString() == "Red" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Checked"))
                {
                    label5.ForeColor = Color.Red;
                }
                if (itemChecked.ToString() == "Red" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Unchecked"))
                {
                    label5.ForeColor = Color.Black;
                }
                if (itemChecked.ToString() == "Italic" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Checked"))
                {
                    label5.Font = new Font(label5.Font, FontStyle.Italic);
                }
                if (itemChecked.ToString() == "Italic" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Unchecked"))
                {
                    label5.Font = new Font(label5.Font, FontStyle.Regular);
                }
                if (itemChecked.ToString() == "Hide" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Checked"))
                {
                    label5.Visible = false;
                }
                if (itemChecked.ToString() == "Hide" && checkedListBox1.GetItemCheckState(checkedListBox1.Items.IndexOf(itemChecked)).ToString().Equals("Unchecked"))
                {
                    label5.Visible = true;
                }
            }
        }
    }
}
