using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AsiTec
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LlenarEstudiante(); // Llenar el ComboBox
            ConfigurarListView(); // Configurar el ListView
        }

        private void LlenarEstudiante()
        {
            string filePath = "estudiantes.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lineas = File.ReadAllLines(filePath);

                    foreach (var linea in lineas)
                    {
                        string nombre = linea.Split(',')[0].Trim(); // Extraer el nombre del estudiante
                        cmbBoxEstudiante.Items.Add(nombre); // Añadir al ComboBox
                    }

                    if (cmbBoxEstudiante.Items.Count == 0)
                    {
                        MessageBox.Show("No hay estudiantes en el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo estudiantes.txt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El archivo estudiantes.txt no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarListView()
        {
            // Configuración básica del ListView
            listView1.View = View.Details;
            listView1.Columns.Add("Nombre", 100);
            listView1.Columns.Add("Edad", 50);
            listView1.Columns.Add("Curso", 100);
            listView1.Columns.Add("Fecha", 100);
            listView1.Columns.Add("Estado", 100);
            listView1.Columns.Add("Hora", 100);
            listView1.Columns.Add("Comentario", 200);
        }

        private void cmbBoxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxEstudiante.SelectedItem != null)
            {
                string estudianteSeleccionado = cmbBoxEstudiante.SelectedItem.ToString().Trim();
                CargarDatosDesdeArchivo(estudianteSeleccionado);
            }
        }

        private void CargarDatosDesdeArchivo(string estudianteSeleccionado)
        {
            string datosFilePath = "datos.txt";
            listView1.Items.Clear(); // Limpiar el ListView antes de cargar datos nuevos

            if (File.Exists(datosFilePath))
            {
                try
                {
                    string[] lineasDatos = File.ReadAllLines(datosFilePath);

                    // Filtrar las líneas que pertenecen al estudiante seleccionado
                    var datosFiltrados = lineasDatos
                        .Select(linea => linea.Split(','))
                        .Where(campos => campos.Length >= 7 && campos[0].Trim() == estudianteSeleccionado);

                    foreach (var campos in datosFiltrados)
                    {
                        ListViewItem item = new ListViewItem(campos.Select(c => c.Trim()).ToArray());
                        listView1.Items.Add(item); // Agregar al ListView
                    }

                    if (!datosFiltrados.Any())
                    {
                        MessageBox.Show($"No se encontraron registros para el estudiante: {estudianteSeleccionado}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar {datosFilePath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"El archivo datos.txt no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
