namespace FormsPractica7.Forms
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
            this.PersonaGridView = new System.Windows.Forms.DataGridView();
            this.NacionalidadGridView = new System.Windows.Forms.DataGridView();
            this.GeneroGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NacionalidadGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaGridView
            // 
            this.PersonaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonaGridView.Location = new System.Drawing.Point(12, 110);
            this.PersonaGridView.Name = "PersonaGridView";
            this.PersonaGridView.RowTemplate.Height = 25;
            this.PersonaGridView.Size = new System.Drawing.Size(240, 150);
            this.PersonaGridView.TabIndex = 0;
            // 
            // NacionalidadGridView
            // 
            this.NacionalidadGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NacionalidadGridView.Location = new System.Drawing.Point(285, 110);
            this.NacionalidadGridView.Name = "NacionalidadGridView";
            this.NacionalidadGridView.RowTemplate.Height = 25;
            this.NacionalidadGridView.Size = new System.Drawing.Size(240, 150);
            this.NacionalidadGridView.TabIndex = 1;
            // 
            // GeneroGridView
            // 
            this.GeneroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeneroGridView.Location = new System.Drawing.Point(548, 110);
            this.GeneroGridView.Name = "GeneroGridView";
            this.GeneroGridView.RowTemplate.Height = 25;
            this.GeneroGridView.Size = new System.Drawing.Size(240, 150);
            this.GeneroGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nacionalidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GeneroGridView);
            this.Controls.Add(this.NacionalidadGridView);
            this.Controls.Add(this.PersonaGridView);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.PersonaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NacionalidadGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneroGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PersonaGridView;
        private DataGridView NacionalidadGridView;
        private DataGridView GeneroGridView;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}