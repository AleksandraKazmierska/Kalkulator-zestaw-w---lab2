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
    public partial class Form3 : Form
    {
        private Dictionary<string, decimal> cenyMonitorow = new Dictionary<string, decimal>()
        {
            { "Monitor A", 300m },
            { "Monitor B", 400m },
            { "Monitor C", 500m }
        };

        public Form3()
        {
            InitializeComponent();

            foreach (string monitor in cenyMonitorow.Keys)
            {
                listView1.Items.Add(monitor);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedMonitor = listView1.SelectedItems[0].Text;
                if (cenyMonitorow.ContainsKey(selectedMonitor))
                {
                    textBox1.Text = cenyMonitorow[selectedMonitor].ToString("C");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedMonitor = listView1.SelectedItems[0].Text;
                if (cenyMonitorow.ContainsKey(selectedMonitor))
                {
                    decimal cenaMonitora = cenyMonitorow[selectedMonitor];
                    Form1 form1 = new Form1();
                    form1.CenaMonitora = cenaMonitora; 
                    form1.WyswietlCeneMonitora();
                    form1.Show();
                    this.Hide();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
