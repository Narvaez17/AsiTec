namespace AsiTec
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.txtRegistrarEstudiante = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.Label();
            this.txtBoxNombreApellido = new System.Windows.Forms.TextBox();
            this.txtBoxEdad = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbBoxCurso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRegistrarEstudiante
            // 
            this.txtRegistrarEstudiante.AutoSize = true;
            this.txtRegistrarEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarEstudiante.Location = new System.Drawing.Point(277, 9);
            this.txtRegistrarEstudiante.Name = "txtRegistrarEstudiante";
            this.txtRegistrarEstudiante.Size = new System.Drawing.Size(206, 25);
            this.txtRegistrarEstudiante.TabIndex = 0;
            this.txtRegistrarEstudiante.Text = "Registrar Estudiante";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.AutoSize = true;
            this.txtNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreApellido.Location = new System.Drawing.Point(78, 71);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(150, 18);
            this.txtNombreApellido.TabIndex = 1;
            this.txtNombreApellido.Text = "Nombre y Apellido:";
            // 
            // txtEdad
            // 
            this.txtEdad.AutoSize = true;
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(78, 126);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(51, 18);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.Text = "Edad:";
            // 
            // txtCurso
            // 
            this.txtCurso.AutoSize = true;
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(78, 181);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(59, 18);
            this.txtCurso.TabIndex = 4;
            this.txtCurso.Text = "Curso:";
            // 
            // txtBoxNombreApellido
            // 
            this.txtBoxNombreApellido.Location = new System.Drawing.Point(234, 71);
            this.txtBoxNombreApellido.Name = "txtBoxNombreApellido";
            this.txtBoxNombreApellido.Size = new System.Drawing.Size(138, 22);
            this.txtBoxNombreApellido.TabIndex = 5;
            this.txtBoxNombreApellido.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            // 
            // txtBoxEdad
            // 
            this.txtBoxEdad.Location = new System.Drawing.Point(234, 122);
            this.txtBoxEdad.Name = "txtBoxEdad";
            this.txtBoxEdad.Size = new System.Drawing.Size(138, 22);
            this.txtBoxEdad.TabIndex = 7;
            this.txtBoxEdad.TextChanged += new System.EventHandler(this.txtBoxEdad_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(701, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(605, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbBoxCurso
            // 
            this.cmbBoxCurso.FormattingEnabled = true;
            this.cmbBoxCurso.Items.AddRange(new object[] {
            "Primer Curso",
            "Segundo Curso",
            "Tercer Curso",
            "Cuarto Curso",
            "Quinto Curso"});
            this.cmbBoxCurso.Location = new System.Drawing.Point(234, 180);
            this.cmbBoxCurso.Name = "cmbBoxCurso";
            this.cmbBoxCurso.Size = new System.Drawing.Size(138, 24);
            this.cmbBoxCurso.TabIndex = 10;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBoxCurso);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBoxEdad);
            this.Controls.Add(this.txtBoxNombreApellido);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.txtRegistrarEstudiante);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRegistrarEstudiante;
        private System.Windows.Forms.Label txtNombreApellido;
        private System.Windows.Forms.Label txtEdad;
        private System.Windows.Forms.Label txtCurso;
        private System.Windows.Forms.TextBox txtBoxNombreApellido;
        private System.Windows.Forms.TextBox txtBoxEdad;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbBoxCurso;
    }
}