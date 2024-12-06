namespace AsiTec
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.txtCursos = new System.Windows.Forms.Label();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.btnCuarto = new System.Windows.Forms.Button();
            this.btnQuinto = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCursos
            // 
            this.txtCursos.AutoSize = true;
            this.txtCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCursos.Location = new System.Drawing.Point(323, 9);
            this.txtCursos.Name = "txtCursos";
            this.txtCursos.Size = new System.Drawing.Size(95, 29);
            this.txtCursos.TabIndex = 0;
            this.txtCursos.Text = "Cursos";
            // 
            // btnPrimero
            // 
            this.btnPrimero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(67, 72);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(90, 23);
            this.btnPrimero.TabIndex = 1;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.Location = new System.Drawing.Point(67, 130);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(90, 25);
            this.btnSegundo.TabIndex = 2;
            this.btnSegundo.Text = "Segundo";
            this.btnSegundo.UseVisualStyleBackColor = true;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTercero.Location = new System.Drawing.Point(67, 182);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(90, 23);
            this.btnTercero.TabIndex = 3;
            this.btnTercero.Text = "Tercero";
            this.btnTercero.UseVisualStyleBackColor = true;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // btnCuarto
            // 
            this.btnCuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuarto.Location = new System.Drawing.Point(67, 237);
            this.btnCuarto.Name = "btnCuarto";
            this.btnCuarto.Size = new System.Drawing.Size(90, 23);
            this.btnCuarto.TabIndex = 4;
            this.btnCuarto.Text = "Cuarto";
            this.btnCuarto.UseVisualStyleBackColor = true;
            this.btnCuarto.Click += new System.EventHandler(this.btnCuarto_Click);
            // 
            // btnQuinto
            // 
            this.btnQuinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuinto.Location = new System.Drawing.Point(67, 304);
            this.btnQuinto.Name = "btnQuinto";
            this.btnQuinto.Size = new System.Drawing.Size(90, 23);
            this.btnQuinto.TabIndex = 5;
            this.btnQuinto.Text = "Quinto";
            this.btnQuinto.UseVisualStyleBackColor = true;
            this.btnQuinto.Click += new System.EventHandler(this.btnQuinto_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(678, 401);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnQuinto);
            this.Controls.Add(this.btnCuarto);
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtCursos);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCursos;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnTercero;
        private System.Windows.Forms.Button btnCuarto;
        private System.Windows.Forms.Button btnQuinto;
        private System.Windows.Forms.Button btnVolver;
    }
}