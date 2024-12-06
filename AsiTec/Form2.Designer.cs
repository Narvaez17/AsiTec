namespace AsiTec
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtMenu = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.txtBoxClave = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMenu
            // 
            this.txtMenu.AutoSize = true;
            this.txtMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(321, 9);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(172, 29);
            this.txtMenu.TabIndex = 0;
            this.txtMenu.Text = "Iniciar Sesión";
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(107, 112);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(34, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "ID:";
            // 
            // txtClave
            // 
            this.txtClave.AutoSize = true;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(107, 183);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(62, 20);
            this.txtClave.TabIndex = 2;
            this.txtClave.Text = "Clave:";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(206, 109);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(138, 22);
            this.txtBoxId.TabIndex = 3;
            this.txtBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBoxClave
            // 
            this.txtBoxClave.Location = new System.Drawing.Point(206, 180);
            this.txtBoxClave.Name = "txtBoxClave";
            this.txtBoxClave.Size = new System.Drawing.Size(138, 22);
            this.txtBoxClave.TabIndex = 4;
            this.txtBoxClave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(696, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(563, 401);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(115, 23);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBoxClave);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtMenu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtMenu;
        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.Label txtClave;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.TextBox txtBoxClave;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}