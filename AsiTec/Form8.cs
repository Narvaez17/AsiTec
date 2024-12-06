using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsiTec
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form8_Load(object sender, EventArgs e)
        {   
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxEdad_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreApellido = txtBoxNombreApellido.Text;
            string edad = txtBoxEdad.Text;
            string curso = cmbBoxCurso.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(nombreApellido) || string.IsNullOrWhiteSpace(edad) || cmbBoxCurso.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            if (!int.TryParse(edad, out int edadInt))
            {
                MessageBox.Show("La edad debe ser un número");
                return;
            }

            string filePath = "estudiantes.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{nombreApellido}, {edad}, {curso}");
                }
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al guardar los datos: " +  ex.Message);
            }
        }

    }
}
