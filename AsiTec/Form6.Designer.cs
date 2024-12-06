namespace AsiTec
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.txtRegistrarAsistencia = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtComentarios = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRegistrarAsistencia
            // 
            this.txtRegistrarAsistencia.AutoSize = true;
            this.txtRegistrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarAsistencia.Location = new System.Drawing.Point(277, 9);
            this.txtRegistrarAsistencia.Name = "txtRegistrarAsistencia";
            this.txtRegistrarAsistencia.Size = new System.Drawing.Size(204, 25);
            this.txtRegistrarAsistencia.TabIndex = 0;
            this.txtRegistrarAsistencia.Text = "Registrar Asistencia";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.AutoSize = true;
            this.txtEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Location = new System.Drawing.Point(59, 64);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(92, 18);
            this.txtEstudiante.TabIndex = 1;
            this.txtEstudiante.Text = "Estudiante:";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(514, 64);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(59, 18);
            this.txtFecha.TabIndex = 2;
            this.txtFecha.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(579, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(62, 124);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(66, 18);
            this.txtEstado.TabIndex = 4;
            this.txtEstado.Text = "Estado:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.AutoSize = true;
            this.txtHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrada.Location = new System.Drawing.Point(62, 178);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(136, 18);
            this.txtHoraEntrada.TabIndex = 5;
            this.txtHoraEntrada.Text = "Hora de Entrada:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtComentarios
            // 
            this.txtComentarios.AutoSize = true;
            this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(62, 232);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(110, 18);
            this.txtComentarios.TabIndex = 7;
            this.txtComentarios.Text = "Comentarios:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 22);
            this.textBox2.TabIndex = 8;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(704, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBoxEstudiante
            // 
            this.cmbBoxEstudiante.FormattingEnabled = true;
            this.cmbBoxEstudiante.Location = new System.Drawing.Point(221, 64);
            this.cmbBoxEstudiante.Name = "cmbBoxEstudiante";
            this.cmbBoxEstudiante.Size = new System.Drawing.Size(193, 24);
            this.cmbBoxEstudiante.TabIndex = 11;
            this.cmbBoxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEstudiante_SelectedIndexChanged);
            // 
            // cmbBoxEstado
            // 
            this.cmbBoxEstado.FormattingEnabled = true;
            this.cmbBoxEstado.Location = new System.Drawing.Point(221, 117);
            this.cmbBoxEstado.Name = "cmbBoxEstado";
            this.cmbBoxEstado.Size = new System.Drawing.Size(193, 24);
            this.cmbBoxEstado.TabIndex = 12;
            this.cmbBoxEstado.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEstado_SelectedIndexChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.cmbBoxEstado);
            this.Controls.Add(this.cmbBoxEstudiante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtRegistrarAsistencia);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRegistrarAsistencia;
        private System.Windows.Forms.Label txtEstudiante;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Label txtHoraEntrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtComentarios;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBoxEstudiante;
        private System.Windows.Forms.ComboBox cmbBoxEstado;
    }
}