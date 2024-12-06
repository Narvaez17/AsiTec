using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiTec
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtBoxClave.UseSystemPasswordChar = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtBoxId.Text == "123456" && txtBoxClave.Text == "1234") {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario o Clave Incorrectos");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
