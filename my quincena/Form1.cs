using System.Linq.Expressions;

namespace my_quincena
{
    public partial class Form1 : Form
    {
        public int chambita89 = 0;
        public string empleado = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            empleado = "";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {





            if (rbtEMAN.Checked == true)
            {
                frmMayores tabla1 = new frmMayores();
                this.Hide();
                tabla1.Show();


            }

            if (rbtEMEN.Checked == true)
            {
                FrmMenores tabla2 = new FrmMenores();
                this.Hide();
                tabla2.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
