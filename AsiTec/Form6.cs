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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void cmbBoxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEstudiantes();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadEstudiantes();
            LoadEstados();
        }
        private void LoadEstudiantes() 
        {
            string filePath = "estudiantes.txt";
            if (File.Exists(filePath))
            {
                string[] estudiantes = File.ReadAllLines(filePath);
                cmbBoxEstudiante.Items.AddRange(estudiantes);
            }
        }
        private void LoadEstados() 
        {
            cmbBoxEstado.Items.Add("Presente");
            cmbBoxEstado.Items.Add("Ausente");
            cmbBoxEstado.Items.Add("Falta Justificada");
        }

        private void cmbBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxEstado.Items.Add("Presente");
            cmbBoxEstado.Items.Add("Ausente");
            cmbBoxEstado.Items.Add("Falta Justificada");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbBoxEstudiante.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante.");
                return;
            }

            string nombreApellido = cmbBoxEstudiante.SelectedItem.ToString();
            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd"); 
            string curso = cmbBoxEstado.SelectedItem?.ToString(); 
            string horaEntrada = textBox1.Text;
            string comentario = textBox2.Text;

            if (string.IsNullOrEmpty(nombreApellido) || string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(curso) || string.IsNullOrEmpty(horaEntrada) || string.IsNullOrEmpty(comentario))
            {
                MessageBox.Show("Por favor, complete todos los campos");
                return;
            }

            string filePath = "datos.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{nombreApellido}, {fecha}, {curso}, {horaEntrada}, {comentario}");
                }
                MessageBox.Show("Datos guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }
    }
}
