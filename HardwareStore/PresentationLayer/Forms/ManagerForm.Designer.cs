namespace PresentationLayer.Forms
{
    partial class ManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageManager = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonEditar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.ButtonGuardar = new System.Windows.Forms.Button();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelForm = new System.Windows.Forms.Label();
            this.LabelManagerTitle = new System.Windows.Forms.Label();
            this.dataGridViewManagers = new System.Windows.Forms.DataGridView();
            this.TabPageFerreteria = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TabPageManager.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPageManager);
            this.tabControl1.Controls.Add(this.TabPageFerreteria);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 550);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPageManager
            // 
            this.TabPageManager.Controls.Add(this.panel1);
            this.TabPageManager.Controls.Add(this.LabelManagerTitle);
            this.TabPageManager.Controls.Add(this.dataGridViewManagers);
            this.TabPageManager.Location = new System.Drawing.Point(4, 24);
            this.TabPageManager.Name = "TabPageManager";
            this.TabPageManager.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageManager.Size = new System.Drawing.Size(917, 522);
            this.TabPageManager.TabIndex = 0;
            this.TabPageManager.Text = "Manager";
            this.TabPageManager.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonEditar);
            this.panel1.Controls.Add(this.ButtonEliminar);
            this.panel1.Controls.Add(this.ButtonGuardar);
            this.panel1.Controls.Add(this.TextBoxApellido);
            this.panel1.Controls.Add(this.TextBoxNombre);
            this.panel1.Controls.Add(this.LabelApellido);
            this.panel1.Controls.Add(this.LabelNombre);
            this.panel1.Controls.Add(this.LabelForm);
            this.panel1.Location = new System.Drawing.Point(6, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 261);
            this.panel1.TabIndex = 2;
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEditar.Location = new System.Drawing.Point(171, 226);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(147, 32);
            this.ButtonEditar.TabIndex = 7;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.UseVisualStyleBackColor = true;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonEliminar.Location = new System.Drawing.Point(3, 226);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(147, 32);
            this.ButtonEliminar.TabIndex = 6;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // ButtonGuardar
            // 
            this.ButtonGuardar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonGuardar.Location = new System.Drawing.Point(338, 226);
            this.ButtonGuardar.Name = "ButtonGuardar";
            this.ButtonGuardar.Size = new System.Drawing.Size(147, 32);
            this.ButtonGuardar.TabIndex = 5;
            this.ButtonGuardar.Text = "Guardar";
            this.ButtonGuardar.UseVisualStyleBackColor = true;
            this.ButtonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(18, 177);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(147, 23);
            this.TextBoxApellido.TabIndex = 4;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(18, 95);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(147, 23);
            this.TextBoxNombre.TabIndex = 3;
            // 
            // LabelApellido
            // 
            this.LabelApellido.AutoSize = true;
            this.LabelApellido.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelApellido.Location = new System.Drawing.Point(18, 146);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(77, 28);
            this.LabelApellido.TabIndex = 2;
            this.LabelApellido.Text = "Apellido";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNombre.Location = new System.Drawing.Point(18, 64);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(76, 28);
            this.LabelNombre.TabIndex = 1;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelForm
            // 
            this.LabelForm.AutoSize = true;
            this.LabelForm.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LabelForm.Location = new System.Drawing.Point(3, 9);
            this.LabelForm.Name = "LabelForm";
            this.LabelForm.Size = new System.Drawing.Size(118, 34);
            this.LabelForm.TabIndex = 0;
            this.LabelForm.Text = "Formulario";
            // 
            // LabelManagerTitle
            // 
            this.LabelManagerTitle.AutoSize = true;
            this.LabelManagerTitle.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelManagerTitle.Location = new System.Drawing.Point(8, 3);
            this.LabelManagerTitle.Name = "LabelManagerTitle";
            this.LabelManagerTitle.Size = new System.Drawing.Size(375, 56);
            this.LabelManagerTitle.TabIndex = 1;
            this.LabelManagerTitle.Text = "Gestion de Managers";
            // 
            // dataGridViewManagers
            // 
            this.dataGridViewManagers.AllowUserToAddRows = false;
            this.dataGridViewManagers.AllowUserToOrderColumns = true;
            this.dataGridViewManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewManagers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewManagers.Location = new System.Drawing.Point(500, 68);
            this.dataGridViewManagers.Name = "dataGridViewManagers";
            this.dataGridViewManagers.RowTemplate.Height = 25;
            this.dataGridViewManagers.Size = new System.Drawing.Size(409, 447);
            this.dataGridViewManagers.TabIndex = 0;
            this.dataGridViewManagers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManagers_CellClick);
            // 
            // TabPageFerreteria
            // 
            this.TabPageFerreteria.Location = new System.Drawing.Point(4, 24);
            this.TabPageFerreteria.Name = "TabPageFerreteria";
            this.TabPageFerreteria.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageFerreteria.Size = new System.Drawing.Size(917, 522);
            this.TabPageFerreteria.TabIndex = 1;
            this.TabPageFerreteria.Text = "Ferreteria";
            this.TabPageFerreteria.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.tabControl1.ResumeLayout(false);
            this.TabPageManager.ResumeLayout(false);
            this.TabPageManager.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPageManager;
        private Panel panel1;
        private Button ButtonGuardar;
        private TextBox TextBoxApellido;
        private TextBox TextBoxNombre;
        private Label LabelApellido;
        private Label LabelNombre;
        private Label LabelForm;
        private Label LabelManagerTitle;
        private DataGridView dataGridViewManagers;
        private TabPage TabPageFerreteria;
        private Button ButtonEditar;
        private Button ButtonEliminar;
    }
}