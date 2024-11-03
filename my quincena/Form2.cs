using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_quincena
{
    public partial class frmMayores : Form
    {
        public int chambitas = 0;
        public int Days1 = 0;
        public int SB1 = 0;
        public string g = "";
        public int sueldoBruto = 0;
        public int Descuento = 0;
        public int SueldoNeto = 0;
        public frmMayores()
        {
            InitializeComponent();
        }

        private void rbtnDirector_CheckedChanged(object sender, EventArgs e)
        {




        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            g = Dechambitas.Text;
            chambitas = int.Parse(g);
            if (rbtnDirector.Checked == true)
            {
                Days1 = 60000;
                SB1 = 4000 * chambitas;
                sueldoBruto = Days1 - SB1;
                txtsueldobruto.Text = sueldoBruto.ToString();
                if (sueldoBruto >= 10000 && sueldoBruto < 20000)
                {

                    Descuento = 15;
                    SueldoNeto = (sueldoBruto * 100) / 15;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                    lblISR.Text = "15%";
                }
                if (sueldoBruto >= 20000 && sueldoBruto < 30000)
                {

                    Descuento = 20;
                    SueldoNeto = (sueldoBruto * 100) / 20;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                    lblISR.Text = "20%";
                }
                if (sueldoBruto >= 30000 && sueldoBruto < 40000)
                {

                    Descuento = 25;
                    SueldoNeto = (sueldoBruto * 100) / 25;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                    lblISR.Text = "25%";
                }
                if (sueldoBruto >= 40000)
                {

                    Descuento = 30;
                    SueldoNeto = (sueldoBruto * 100) / 30;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                    lblISR.Text = "30%";
                }






            }
            if (rbtnGerente.Checked == true)
            {
                Days1 = 48000;
                SB1 = 3200 * chambitas;
                sueldoBruto = Days1 - SB1;
                txtsueldobruto.Text = sueldoBruto.ToString();
                if (sueldoBruto >= 10000 && sueldoBruto < 20000)
                {

                    Descuento = 15;
                    SueldoNeto = (sueldoBruto * 100) / 15;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                }
                if (sueldoBruto >= 20000 && sueldoBruto < 30000)
                {

                    Descuento = 20;
                    SueldoNeto = (sueldoBruto * 100) / 20;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                }
                if (sueldoBruto >= 30000 && sueldoBruto < 40000)
                {

                    Descuento = 25;
                    SueldoNeto = (sueldoBruto * 100) / 25;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                }
                if (sueldoBruto >= 40000)
                {

                    Descuento = 30;
                    SueldoNeto = (sueldoBruto * 100) / 30;
                    txtSueldoNeto.Text = SueldoNeto.ToString();
                    txtTotalMay.Text = Descuento.ToString() + "%";
                }





                txtSueldoNeto.Text = SueldoNeto.ToString();
            }



        }

        private void rbtnGerente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBdiastrabajados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFaltas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoMay_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void txtsueldobruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblISR_Click(object sender, EventArgs e)
        {

        }
    }
}
