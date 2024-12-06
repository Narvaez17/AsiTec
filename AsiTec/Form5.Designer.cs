namespace AsiTec
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.txtAsistencia = new System.Windows.Forms.Label();
            this.btnConsultarAsistencia = new System.Windows.Forms.Button();
            this.btnRegistrarAsistencia = new System.Windows.Forms.Button();
            this.btnVOlver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAsistencia
            // 
            this.txtAsistencia.AutoSize = true;
            this.txtAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsistencia.Location = new System.Drawing.Point(324, 9);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(132, 29);
            this.txtAsistencia.TabIndex = 0;
            this.txtAsistencia.Text = "Asistencia";
            // 
            // btnConsultarAsistencia
            // 
            this.btnConsultarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAsistencia.Location = new System.Drawing.Point(305, 127);
            this.btnConsultarAsistencia.Name = "btnConsultarAsistencia";
            this.btnConsultarAsistencia.Size = new System.Drawing.Size(189, 30);
            this.btnConsultarAsistencia.TabIndex = 1;
            this.btnConsultarAsistencia.Text = "Consultar Asistencia";
            this.btnConsultarAsistencia.UseVisualStyleBackColor = true;
            this.btnConsultarAsistencia.Click += new System.EventHandler(this.btnConsultarAsistencia_Click);
            // 
            // btnRegistrarAsistencia
            // 
            this.btnRegistrarAsistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAsistencia.Location = new System.Drawing.Point(305, 215);
            this.btnRegistrarAsistencia.Name = "btnRegistrarAsistencia";
            this.btnRegistrarAsistencia.Size = new System.Drawing.Size(189, 30);
            this.btnRegistrarAsistencia.TabIndex = 2;
            this.btnRegistrarAsistencia.Text = "Registrar Asistencia";
            this.btnRegistrarAsistencia.UseVisualStyleBackColor = true;
            this.btnRegistrarAsistencia.Click += new System.EventHandler(this.btnRegistrarAsistencia_Click);
            // 
            // btnVOlver
            // 
            this.btnVOlver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVOlver.Location = new System.Drawing.Point(305, 293);
            this.btnVOlver.Name = "btnVOlver";
            this.btnVOlver.Size = new System.Drawing.Size(189, 30);
            this.btnVOlver.TabIndex = 3;
            this.btnVOlver.Text = "Volver";
            this.btnVOlver.UseVisualStyleBackColor = true;
            this.btnVOlver.Click += new System.EventHandler(this.btnVOlver_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVOlver);
            this.Controls.Add(this.btnRegistrarAsistencia);
            this.Controls.Add(this.btnConsultarAsistencia);
            this.Controls.Add(this.txtAsistencia);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAsistencia;
        private System.Windows.Forms.Button btnConsultarAsistencia;
        private System.Windows.Forms.Button btnRegistrarAsistencia;
        private System.Windows.Forms.Button btnVOlver;
    }
}