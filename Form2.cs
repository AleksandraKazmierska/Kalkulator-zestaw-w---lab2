using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_zestawów___lab2
{
    public partial class Form2 : Form
    {
        private Dictionary<string, decimal> cenyElementow = new Dictionary<string, decimal>();

        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(new string[] { "Procesor 1", "Procesor 2", "Procesor 3" });

            cenyElementow.Add("Element 1", 1032m);
            cenyElementow.Add("Element 2", 975m);
            cenyElementow.Add("Element 3", 1575m);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox2.Text = "40.00"; 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedElement = comboBox1.SelectedItem.ToString();

            if (cenyElementow.ContainsKey(selectedElement))
            {
                decimal cena = cenyElementow[selectedElement];

                textBox2.Text = cena.ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Text = "50.00"; 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Text = "30.00"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal cenaComboBox = 0;
            if (comboBox1.SelectedItem != null && cenyElementow.ContainsKey(comboBox1.SelectedItem.ToString()))
            {
                cenaComboBox = cenyElementow[comboBox1.SelectedItem.ToString()];
            }

            decimal cenaRadioButton = 0;
            if (radioButton1.Checked)
            {
                cenaRadioButton = 50.00m;
            }
            else if (radioButton2.Checked)
            {
                cenaRadioButton = 30.00m;
            }
            else if (radioButton3.Checked)
            {
                cenaRadioButton = 40.00m;
            }

            decimal sumaCen = cenaComboBox + cenaRadioButton;

            Form1 form1 = new Form1();
            form1.SumaCenZForm2 = sumaCen;

            form1.WyswietlCeneMonitora();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
