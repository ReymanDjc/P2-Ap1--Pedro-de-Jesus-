namespace ParcialTech.Registros
{
    partial class RetencionesRegistroForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label retencionIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label valorLabel;
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.retencionIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.valorMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CamposVacioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            retencionIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(207, 3);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 29;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(207, 93);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 28;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(112, 93);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 27;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(15, 94);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 26;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // retencionIdLabel
            // 
            retencionIdLabel.AutoSize = true;
            retencionIdLabel.Location = new System.Drawing.Point(12, 9);
            retencionIdLabel.Name = "retencionIdLabel";
            retencionIdLabel.Size = new System.Drawing.Size(71, 13);
            retencionIdLabel.TabIndex = 20;
            retencionIdLabel.Text = "Retencion Id:";
            // 
            // retencionIdMaskedTextBox
            // 
            this.retencionIdMaskedTextBox.Location = new System.Drawing.Point(89, 6);
            this.retencionIdMaskedTextBox.Mask = "99999999";
            this.retencionIdMaskedTextBox.Name = "retencionIdMaskedTextBox";
            this.retencionIdMaskedTextBox.Size = new System.Drawing.Size(41, 20);
            this.retencionIdMaskedTextBox.TabIndex = 21;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(12, 35);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 22;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(89, 32);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(193, 20);
            this.descripcionTextBox.TabIndex = 23;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(12, 61);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 24;
            valorLabel.Text = "Valor:";
            // 
            // valorMaskedTextBox
            // 
            this.valorMaskedTextBox.Location = new System.Drawing.Point(89, 58);
            this.valorMaskedTextBox.Mask = "99999999999999999999999";
            this.valorMaskedTextBox.Name = "valorMaskedTextBox";
            this.valorMaskedTextBox.Size = new System.Drawing.Size(193, 20);
            this.valorMaskedTextBox.TabIndex = 25;
            // 
            // CamposVacioserrorProvider
            // 
            this.CamposVacioserrorProvider.ContainerControl = this;
            // 
            // RetencionesRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 133);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(retencionIdLabel);
            this.Controls.Add(this.retencionIdMaskedTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorMaskedTextBox);
            this.Name = "RetencionesRegistroForm";
            this.Text = "RetencionesRegistroForm";
            this.Load += new System.EventHandler(this.RetencionesRegistroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.MaskedTextBox retencionIdMaskedTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.MaskedTextBox valorMaskedTextBox;
        private System.Windows.Forms.ErrorProvider CamposVacioserrorProvider;
    }
}