namespace pruebaCrud.Forms
{
    partial class CharactersForms
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
            this.characterDataGridView = new System.Windows.Forms.DataGridView();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.ataqueTextbox = new System.Windows.Forms.TextBox();
            this.defensaTextbox = new System.Windows.Forms.TextBox();
            this.kiTextbox = new System.Windows.Forms.TextBox();
            this.guardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.characterDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // characterDataGridView
            // 
            this.characterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.characterDataGridView.Location = new System.Drawing.Point(12, 12);
            this.characterDataGridView.Name = "characterDataGridView";
            this.characterDataGridView.RowTemplate.Height = 25;
            this.characterDataGridView.Size = new System.Drawing.Size(456, 426);
            this.characterDataGridView.TabIndex = 0;
            this.characterDataGridView.SelectionChanged += new System.EventHandler(this.characterDataGridView_SelectionChanged);
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.Location = new System.Drawing.Point(533, 52);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(100, 23);
            this.nombreTextbox.TabIndex = 1;
            // 
            // ataqueTextbox
            // 
            this.ataqueTextbox.Location = new System.Drawing.Point(533, 113);
            this.ataqueTextbox.Name = "ataqueTextbox";
            this.ataqueTextbox.Size = new System.Drawing.Size(100, 23);
            this.ataqueTextbox.TabIndex = 2;
            // 
            // defensaTextbox
            // 
            this.defensaTextbox.Location = new System.Drawing.Point(533, 180);
            this.defensaTextbox.Name = "defensaTextbox";
            this.defensaTextbox.Size = new System.Drawing.Size(100, 23);
            this.defensaTextbox.TabIndex = 3;
            // 
            // kiTextbox
            // 
            this.kiTextbox.Location = new System.Drawing.Point(533, 239);
            this.kiTextbox.Name = "kiTextbox";
            this.kiTextbox.Size = new System.Drawing.Size(100, 23);
            this.kiTextbox.TabIndex = 4;
            // 
            // guardarButton
            // 
            this.guardarButton.Location = new System.Drawing.Point(533, 314);
            this.guardarButton.Name = "guardarButton";
            this.guardarButton.Size = new System.Drawing.Size(75, 23);
            this.guardarButton.TabIndex = 5;
            this.guardarButton.Text = "guardar";
            this.guardarButton.UseVisualStyleBackColor = true;
            this.guardarButton.Click += new System.EventHandler(this.guardarButton_Click);
            // 
            // CharactersForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guardarButton);
            this.Controls.Add(this.kiTextbox);
            this.Controls.Add(this.defensaTextbox);
            this.Controls.Add(this.ataqueTextbox);
            this.Controls.Add(this.nombreTextbox);
            this.Controls.Add(this.characterDataGridView);
            this.Name = "CharactersForms";
            this.Text = "CharactersForms";
            ((System.ComponentModel.ISupportInitialize)(this.characterDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView characterDataGridView;
        private TextBox nombreTextbox;
        private TextBox ataqueTextbox;
        private TextBox defensaTextbox;
        private TextBox kiTextbox;
        private Button guardarButton;
    }
}