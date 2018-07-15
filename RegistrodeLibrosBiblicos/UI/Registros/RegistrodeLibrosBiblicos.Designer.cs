namespace RegistrodeLibrosBiblicos.UI.Registros
{
    partial class RegistrodeLibrosBiblicos
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
            System.Windows.Forms.Label libroIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label siglasLabel;
            System.Windows.Forms.Label tipoLabel;
            this.libroIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.siglasTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.GeneralErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            libroIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            siglasLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libroIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // libroIdLabel
            // 
            libroIdLabel.AutoSize = true;
            libroIdLabel.Location = new System.Drawing.Point(25, 21);
            libroIdLabel.Name = "libroIdLabel";
            libroIdLabel.Size = new System.Drawing.Size(45, 13);
            libroIdLabel.TabIndex = 1;
            libroIdLabel.Text = "Libro Id:";
            // 
            // libroIdNumericUpDown
            // 
            this.libroIdNumericUpDown.Location = new System.Drawing.Point(102, 18);
            this.libroIdNumericUpDown.Name = "libroIdNumericUpDown";
            this.libroIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.libroIdNumericUpDown.TabIndex = 2;
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(25, 81);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(102, 78);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(354, 19);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 5;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(400, 15);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.fechaDateTimePicker.TabIndex = 6;
            // 
            // siglasLabel
            // 
            siglasLabel.AutoSize = true;
            siglasLabel.Location = new System.Drawing.Point(25, 130);
            siglasLabel.Name = "siglasLabel";
            siglasLabel.Size = new System.Drawing.Size(38, 13);
            siglasLabel.TabIndex = 7;
            siglasLabel.Text = "Siglas:";
            // 
            // siglasTextBox
            // 
            this.siglasTextBox.Location = new System.Drawing.Point(102, 129);
            this.siglasTextBox.Name = "siglasTextBox";
            this.siglasTextBox.Size = new System.Drawing.Size(100, 20);
            this.siglasTextBox.TabIndex = 8;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(25, 196);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 9;
            tipoLabel.Text = "Tipo:";
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.Location = new System.Drawing.Point(102, 193);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipoTextBox.TabIndex = 10;
            // 
            // GeneralErrorProvider
            // 
            this.GeneralErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(228, 16);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 11;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(82, 258);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(356, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // RegistrodeLibrosBiblicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 329);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(siglasLabel);
            this.Controls.Add(this.siglasTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(libroIdLabel);
            this.Controls.Add(this.libroIdNumericUpDown);
            this.Name = "RegistrodeLibrosBiblicos";
            this.Text = "Registro de Libros Biblicos";
            ((System.ComponentModel.ISupportInitialize)(this.libroIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown libroIdNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox siglasTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.ErrorProvider GeneralErrorProvider;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button BuscarButton;
    }
}