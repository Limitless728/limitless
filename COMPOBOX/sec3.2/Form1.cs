using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sec3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            string[] a = new string[] { "CR7", "Real madrid" };
            foreach (string i in a)
            {
                comboBox1.Items.Add(i);
            }

        }

        




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                comboBox2.Items.Clear();
                if (comboBox1.SelectedItem.ToString() == "CR7")
                {
                    comboBox2.Items.Add("The goal scorer");
                    comboBox2.Items.Add("GOAT");
                    comboBox2.Items.Add("The History");
                }
                
                if (comboBox1.SelectedItem.ToString() == "Real madrid")
                {
                    comboBox2.Items.Add("Club of the Century");
                    comboBox2.Items.Add("Kings of Europe");
                }
                

            }
        }
    }
}

