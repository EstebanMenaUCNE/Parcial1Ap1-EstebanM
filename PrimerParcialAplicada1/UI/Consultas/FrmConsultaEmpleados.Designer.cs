namespace PrimerParcialAplicada1.UI.Consultas
{
    partial class FrmConsultaEmpleados
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
            this.EmpleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButton = new System.Windows.Forms.Button();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.NombresCheckBox = new System.Windows.Forms.CheckBox();
            this.FechaCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EmpleadosDataGridView
            // 
            this.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosDataGridView.Location = new System.Drawing.Point(21, 105);
            this.EmpleadosDataGridView.Name = "EmpleadosDataGridView";
            this.EmpleadosDataGridView.Size = new System.Drawing.Size(482, 150);
            this.EmpleadosDataGridView.TabIndex = 0;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(326, 28);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 23);
            this.FiltrarButton.TabIndex = 1;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(62, 56);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.DesdeDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(223, 56);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.HastaDateTimePicker.TabIndex = 5;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(21, 30);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(299, 20);
            this.NombresTextBox.TabIndex = 6;
            // 
            // NombresCheckBox
            // 
            this.NombresCheckBox.AutoSize = true;
            this.NombresCheckBox.Location = new System.Drawing.Point(419, 28);
            this.NombresCheckBox.Name = "NombresCheckBox";
            this.NombresCheckBox.Size = new System.Drawing.Size(87, 17);
            this.NombresCheckBox.TabIndex = 7;
            this.NombresCheckBox.Text = "Por Nombres";
            this.NombresCheckBox.UseVisualStyleBackColor = true;
            // 
            // FechaCheckBox
            // 
            this.FechaCheckBox.AutoSize = true;
            this.FechaCheckBox.Location = new System.Drawing.Point(419, 51);
            this.FechaCheckBox.Name = "FechaCheckBox";
            this.FechaCheckBox.Size = new System.Drawing.Size(75, 17);
            this.FechaCheckBox.TabIndex = 8;
            this.FechaCheckBox.Text = "Por Fecha";
            this.FechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 290);
            this.Controls.Add(this.FechaCheckBox);
            this.Controls.Add(this.NombresCheckBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.FiltrarButton);
            this.Controls.Add(this.EmpleadosDataGridView);
            this.Name = "FrmConsultaEmpleados";
            this.Text = "Consulta de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpleadosDataGridView;
        private System.Windows.Forms.Button FiltrarButton;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.CheckBox NombresCheckBox;
        private System.Windows.Forms.CheckBox FechaCheckBox;
    }
}