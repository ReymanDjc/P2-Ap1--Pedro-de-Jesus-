namespace ParcialTech.Registros
{
    partial class EmpleadosRegistroForm
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
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label retencionesLabel;
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.empleadoIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DetalleRetencionesgroupBox = new System.Windows.Forms.GroupBox();
            this.RetencionesdataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarRetencionesbutton = new System.Windows.Forms.Button();
            this.retencionesComboBox = new System.Windows.Forms.ComboBox();
            this.DetalleEmailsgroupBox = new System.Windows.Forms.GroupBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TipoIdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TipotextBox = new System.Windows.Forms.TextBox();
            this.AgragarEmailsbutton = new System.Windows.Forms.Button();
            this.TiposEmailsdataGridView = new System.Windows.Forms.DataGridView();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.CamposVacioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            retencionesLabel = new System.Windows.Forms.Label();
            this.DetalleRetencionesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionesdataGridView)).BeginInit();
            this.DetalleEmailsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposEmailsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(327, 15);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 31;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(100, 21);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 23;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // empleadoIdMaskedTextBox
            // 
            this.empleadoIdMaskedTextBox.Location = new System.Drawing.Point(202, 18);
            this.empleadoIdMaskedTextBox.Mask = "9999999";
            this.empleadoIdMaskedTextBox.Name = "empleadoIdMaskedTextBox";
            this.empleadoIdMaskedTextBox.Size = new System.Drawing.Size(54, 20);
            this.empleadoIdMaskedTextBox.TabIndex = 24;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(100, 47);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(52, 13);
            nombresLabel.TabIndex = 25;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Location = new System.Drawing.Point(202, 44);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombresTextBox.TabIndex = 26;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(100, 74);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 27;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.fechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(202, 70);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 28;
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(100, 99);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 29;
            sueldoLabel.Text = "Sueldo:";
            // 
            // sueldoMaskedTextBox
            // 
            this.sueldoMaskedTextBox.Location = new System.Drawing.Point(202, 96);
            this.sueldoMaskedTextBox.Mask = "999999999999";
            this.sueldoMaskedTextBox.Name = "sueldoMaskedTextBox";
            this.sueldoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoMaskedTextBox.TabIndex = 30;
            // 
            // DetalleRetencionesgroupBox
            // 
            this.DetalleRetencionesgroupBox.Controls.Add(this.RetencionesdataGridView);
            this.DetalleRetencionesgroupBox.Controls.Add(this.AgregarRetencionesbutton);
            this.DetalleRetencionesgroupBox.Controls.Add(retencionesLabel);
            this.DetalleRetencionesgroupBox.Controls.Add(this.retencionesComboBox);
            this.DetalleRetencionesgroupBox.Location = new System.Drawing.Point(2, 139);
            this.DetalleRetencionesgroupBox.Name = "DetalleRetencionesgroupBox";
            this.DetalleRetencionesgroupBox.Size = new System.Drawing.Size(529, 217);
            this.DetalleRetencionesgroupBox.TabIndex = 32;
            this.DetalleRetencionesgroupBox.TabStop = false;
            this.DetalleRetencionesgroupBox.Text = "Detalle Retenciones";
            // 
            // RetencionesdataGridView
            // 
            this.RetencionesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RetencionesdataGridView.Location = new System.Drawing.Point(9, 63);
            this.RetencionesdataGridView.Name = "RetencionesdataGridView";
            this.RetencionesdataGridView.Size = new System.Drawing.Size(514, 142);
            this.RetencionesdataGridView.TabIndex = 3;
            // 
            // AgregarRetencionesbutton
            // 
            this.AgregarRetencionesbutton.Location = new System.Drawing.Point(322, 20);
            this.AgregarRetencionesbutton.Name = "AgregarRetencionesbutton";
            this.AgregarRetencionesbutton.Size = new System.Drawing.Size(75, 23);
            this.AgregarRetencionesbutton.TabIndex = 2;
            this.AgregarRetencionesbutton.Text = "Agregar";
            this.AgregarRetencionesbutton.UseVisualStyleBackColor = true;
            this.AgregarRetencionesbutton.Click += new System.EventHandler(this.AgregarRetencionesbutton_Click);
            // 
            // retencionesLabel
            // 
            retencionesLabel.AutoSize = true;
            retencionesLabel.Location = new System.Drawing.Point(101, 25);
            retencionesLabel.Name = "retencionesLabel";
            retencionesLabel.Size = new System.Drawing.Size(70, 13);
            retencionesLabel.TabIndex = 0;
            retencionesLabel.Text = "Retenciones:";
            // 
            // retencionesComboBox
            // 
            this.retencionesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.retencionesComboBox.FormattingEnabled = true;
            this.retencionesComboBox.Location = new System.Drawing.Point(177, 22);
            this.retencionesComboBox.Name = "retencionesComboBox";
            this.retencionesComboBox.Size = new System.Drawing.Size(121, 21);
            this.retencionesComboBox.TabIndex = 1;
            // 
            // DetalleEmailsgroupBox
            // 
            this.DetalleEmailsgroupBox.Controls.Add(this.EmailtextBox);
            this.DetalleEmailsgroupBox.Controls.Add(this.label3);
            this.DetalleEmailsgroupBox.Controls.Add(this.TipoIdtextBox);
            this.DetalleEmailsgroupBox.Controls.Add(this.label2);
            this.DetalleEmailsgroupBox.Controls.Add(this.label1);
            this.DetalleEmailsgroupBox.Controls.Add(this.TipotextBox);
            this.DetalleEmailsgroupBox.Controls.Add(this.AgragarEmailsbutton);
            this.DetalleEmailsgroupBox.Controls.Add(this.TiposEmailsdataGridView);
            this.DetalleEmailsgroupBox.Location = new System.Drawing.Point(2, 374);
            this.DetalleEmailsgroupBox.Name = "DetalleEmailsgroupBox";
            this.DetalleEmailsgroupBox.Size = new System.Drawing.Size(529, 217);
            this.DetalleEmailsgroupBox.TabIndex = 33;
            this.DetalleEmailsgroupBox.TabStop = false;
            this.DetalleEmailsgroupBox.Text = "Detalle Emails";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(279, 25);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(154, 20);
            this.EmailtextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // TipoIdtextBox
            // 
            this.TipoIdtextBox.Location = new System.Drawing.Point(31, 25);
            this.TipoIdtextBox.Name = "TipoIdtextBox";
            this.TipoIdtextBox.Size = new System.Drawing.Size(34, 20);
            this.TipoIdtextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // TipotextBox
            // 
            this.TipotextBox.Enabled = false;
            this.TipotextBox.Location = new System.Drawing.Point(143, 25);
            this.TipotextBox.Name = "TipotextBox";
            this.TipotextBox.Size = new System.Drawing.Size(89, 20);
            this.TipotextBox.TabIndex = 5;
            this.TipotextBox.TextChanged += new System.EventHandler(this.TipotextBox_TextChanged);
            // 
            // AgragarEmailsbutton
            // 
            this.AgragarEmailsbutton.Location = new System.Drawing.Point(448, 22);
            this.AgragarEmailsbutton.Name = "AgragarEmailsbutton";
            this.AgragarEmailsbutton.Size = new System.Drawing.Size(75, 23);
            this.AgragarEmailsbutton.TabIndex = 3;
            this.AgragarEmailsbutton.Text = "Agregar";
            this.AgragarEmailsbutton.UseVisualStyleBackColor = true;
            this.AgragarEmailsbutton.Click += new System.EventHandler(this.AgragarEmailsbutton_Click);
            // 
            // TiposEmailsdataGridView
            // 
            this.TiposEmailsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TiposEmailsdataGridView.Location = new System.Drawing.Point(9, 60);
            this.TiposEmailsdataGridView.Name = "TiposEmailsdataGridView";
            this.TiposEmailsdataGridView.Size = new System.Drawing.Size(514, 142);
            this.TiposEmailsdataGridView.TabIndex = 0;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(342, 597);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 36;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(225, 597);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 35;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(107, 597);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 34;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // CamposVacioserrorProvider
            // 
            this.CamposVacioserrorProvider.ContainerControl = this;
            // 
            // EmpleadosRegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 635);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DetalleEmailsgroupBox);
            this.Controls.Add(this.DetalleRetencionesgroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdMaskedTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoMaskedTextBox);
            this.Name = "EmpleadosRegistroForm";
            this.Text = "EmpleadosRegistroForm";
            this.Load += new System.EventHandler(this.EmpleadosRegistroForm_Load);
            this.DetalleRetencionesgroupBox.ResumeLayout(false);
            this.DetalleRetencionesgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RetencionesdataGridView)).EndInit();
            this.DetalleEmailsgroupBox.ResumeLayout(false);
            this.DetalleEmailsgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiposEmailsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamposVacioserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.MaskedTextBox empleadoIdMaskedTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox sueldoMaskedTextBox;
        private System.Windows.Forms.GroupBox DetalleRetencionesgroupBox;
        private System.Windows.Forms.DataGridView RetencionesdataGridView;
        private System.Windows.Forms.Button AgregarRetencionesbutton;
        private System.Windows.Forms.ComboBox retencionesComboBox;
        private System.Windows.Forms.GroupBox DetalleEmailsgroupBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TipoIdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TipotextBox;
        private System.Windows.Forms.Button AgragarEmailsbutton;
        private System.Windows.Forms.DataGridView TiposEmailsdataGridView;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider CamposVacioserrorProvider;
    }
}