namespace AsiTec
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.txtConsultarAsistencia = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbBoxEstudiante = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtConsultarAsistencia
            // 
            this.txtConsultarAsistencia.AutoSize = true;
            this.txtConsultarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultarAsistencia.Location = new System.Drawing.Point(289, 9);
            this.txtConsultarAsistencia.Name = "txtConsultarAsistencia";
            this.txtConsultarAsistencia.Size = new System.Drawing.Size(211, 25);
            this.txtConsultarAsistencia.TabIndex = 0;
            this.txtConsultarAsistencia.Text = "Consultar Asistencia";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.AutoSize = true;
            this.txtEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.Location = new System.Drawing.Point(48, 71);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(92, 18);
            this.txtEstudiante.TabIndex = 1;
            this.txtEstudiante.Text = "Estudiante:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(694, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbBoxEstudiante
            // 
            this.cmbBoxEstudiante.FormattingEnabled = true;
            this.cmbBoxEstudiante.Location = new System.Drawing.Point(175, 64);
            this.cmbBoxEstudiante.Name = "cmbBoxEstudiante";
            this.cmbBoxEstudiante.Size = new System.Drawing.Size(234, 24);
            this.cmbBoxEstudiante.TabIndex = 3;
            this.cmbBoxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEstudiante_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(694, 229);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Estado";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora de Entrada";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comentario";
            this.columnHeader4.Width = 200;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbBoxEstudiante);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtEstudiante);
            this.Controls.Add(this.txtConsultarAsistencia);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtConsultarAsistencia;
        private System.Windows.Forms.Label txtEstudiante;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbBoxEstudiante;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}