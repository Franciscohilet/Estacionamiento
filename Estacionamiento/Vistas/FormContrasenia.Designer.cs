namespace Estacionamiento.Vistas
{
    partial class FormContrasenia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_preguntasecreta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lbl_preguntasecreta);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button22);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 383);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(272, 317);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(180, 60);
            this.button22.TabIndex = 7;
            this.button22.Text = "Aceptar";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 32);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña nueva:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(10, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 67);
            this.panel1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 32);
            this.textBox1.TabIndex = 7;
            // 
            // lbl_preguntasecreta
            // 
            this.lbl_preguntasecreta.AutoSize = true;
            this.lbl_preguntasecreta.Location = new System.Drawing.Point(9, 61);
            this.lbl_preguntasecreta.Name = "lbl_preguntasecreta";
            this.lbl_preguntasecreta.Size = new System.Drawing.Size(92, 23);
            this.lbl_preguntasecreta.TabIndex = 6;
            this.lbl_preguntasecreta.Text = "fdsafgsg";
            this.lbl_preguntasecreta.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormContrasenia";
            this.Text = "FormContrasenia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_preguntasecreta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button22;
    }
}