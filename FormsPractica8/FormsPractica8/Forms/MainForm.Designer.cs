namespace FormsPractica8.Forms
{
    partial class MainForm
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.ciudadLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.editarButton = new System.Windows.Forms.Button();
            this.guardarButton = new System.Windows.Forms.Button();
            this.estudianteGridView = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tituloLabel);
            this.panel1.Controls.Add(this.ciudadLabel);
            this.panel1.Controls.Add(this.telefonoLabel);
            this.panel1.Controls.Add(this.apellidoLabel);
            this.panel1.Controls.Add(this.nombreLabel);
            this.panel1.Controls.Add(this.ciudadTextBox);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(this.apellidoTextBox);
            this.panel1.Controls.Add(this.nombreTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 292);
            this.panel1.TabIndex = 0;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(3, 10);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(139, 15);
            this.tituloLabel.TabIndex = 8;
            this.tituloLabel.Text = "Formulario de estudiante";
            // 
            // ciudadLabel
            // 
            this.ciudadLabel.AutoSize = true;
            this.ciudadLabel.Location = new System.Drawing.Point(3, 224);
            this.ciudadLabel.Name = "ciudadLabel";
            this.ciudadLabel.Size = new System.Drawing.Size(45, 15);
            this.ciudadLabel.TabIndex = 7;
            this.ciudadLabel.Text = "Ciudad";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(3, 163);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(52, 15);
            this.telefonoLabel.TabIndex = 6;
            this.telefonoLabel.Text = "Telefono";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(3, 110);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(51, 15);
            this.apellidoLabel.TabIndex = 5;
            this.apellidoLabel.Text = "Apellido";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(3, 57);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(51, 15);
            this.nombreLabel.TabIndex = 4;
            this.nombreLabel.Text = "Nombre";
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.Location = new System.Drawing.Point(3, 242);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 23);
            this.ciudadTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(3, 181);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 23);
            this.telefonoTextBox.TabIndex = 2;
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(3, 128);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 23);
            this.apellidoTextBox.TabIndex = 1;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(3, 75);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.nombreTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eliminarButton);
            this.panel2.Controls.Add(this.editarButton);
            this.panel2.Controls.Add(this.guardarButton);
            this.panel2.Location = new System.Drawing.Point(12, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 100);
            this.panel2.TabIndex = 1;
            // 
            // eliminarButton
            // 
            this.eliminarButton.Location = new System.Drawing.Point(3, 61);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(75, 23);
            this.eliminarButton.TabIndex = 2;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = true;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // editarButton
            // 
            this.editarButton.Location = new System.Drawing.Point(3, 32);
            this.editarButton.Name = "editarButton";
            this.editarButton.Size = new System.Drawing.Size(75, 23);
            this.editarButton.TabIndex = 1;
            this.editarButton.Text = "Editar";
            this.editarButton.UseVisualStyleBackColor = true;
            this.editarButton.Click += new System.EventHandler(this.editarButton_Click);
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(3, 3);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 0;
            this.guardarButton.Text = "Guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // estudianteGridView
            // 
            this.estudianteGridView.AllowUserToAddRows = false;
            this.estudianteGridView.AllowUserToResizeColumns = false;
            this.estudianteGridView.AllowUserToResizeRows = false;
            this.estudianteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estudianteGridView.Location = new System.Drawing.Point(275, 87);
            this.estudianteGridView.Name = "estudianteGridView";
            this.estudianteGridView.RowTemplate.Height = 25;
            this.estudianteGridView.Size = new System.Drawing.Size(513, 323);
            this.estudianteGridView.TabIndex = 2;
            this.estudianteGridView.SelectionChanged += new System.EventHandler(this.estudianteGridView_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(275, 61);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "valery...";
            this.txtBuscar.Size = new System.Drawing.Size(255, 23);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.estudianteGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estudianteGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView estudianteGridView;
        private Label tituloLabel;
        private Label ciudadLabel;
        private Label telefonoLabel;
        private Label apellidoLabel;
        private Label nombreLabel;
        private TextBox ciudadTextBox;
        private TextBox telefonoTextBox;
        private TextBox apellidoTextBox;
        private TextBox nombreTextBox;
        private Button eliminarButton;
        private Button editarButton;
        private Button guardarButton;
        private TextBox txtBuscar;
        private Label label1;
    }
}