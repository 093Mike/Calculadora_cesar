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
    public partial class Configuracio : Form
    {
        public Configuracio()
        {
            InitializeComponent();
        }
        public void Configuracio_Load(object sender, EventArgs e)
        {
            ControlForm();  
        }

        private void ControlForm() {
            //Control de Group1 - Radio1_9
            if (radio1_9.Checked == true){
                numero1_1.Enabled = false;
                numero1_2.Enabled = false;
                Combo1_3.Enabled = false;

            }
            else {
                numero1_1.Enabled = true;
                numero1_2.Enabled = true;
                Combo1_3.Enabled = true;

            }
        }
        private void aceptar_Click(object sender, EventArgs e)
        {

        }

        private void radio1_9_CheckedChanged(object sender, EventArgs e) {ControlForm();}

        private void radio1_10_CheckedChanged(object sender, EventArgs e){ControlForm();}
    }
}
