namespace Estacionamiento.Vistas
{
    partial class FormAdministracion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button24);
            this.panel1.Controls.Add(this.button22);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 264);
            this.panel1.TabIndex = 1;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(37, 158);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(180, 60);
            this.button24.TabIndex = 2;
            this.button24.Text = "Facturacion";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(37, 34);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(180, 60);
            this.button22.TabIndex = 0;
            this.button22.Text = "Tarifas";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 464);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button22;
    }
}