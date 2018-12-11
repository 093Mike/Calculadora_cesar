using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e){
            casilla1.Checked = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e){
            casilla1.Checked = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitarLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El enlace no esta disponible.");
            }
        }
        private void VisitarLink()
        {
            link1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
