namespace ObtenerContenidosArchivos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.selectButton = new System.Windows.Forms.Button();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.fileListBox = new System.Windows.Forms.CheckedListBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileTypeTextBox = new System.Windows.Forms.TextBox();
            this.outputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.generateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(200, 30);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(200, 30);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Seleccionar Directorio";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // directoryLabel
            // 
            this.directoryLabel.Location = new System.Drawing.Point(50, 70);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(500, 20);
            this.directoryLabel.TabIndex = 1;
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(50, 150);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(500, 200);
            this.fileListBox.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(50, 360);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(220, 13);
            this.filterLabel.TabIndex = 3;
            this.filterLabel.Text = "Filtros de carpetas (separados por comas):";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(50, 380);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(500, 20);
            this.filterTextBox.TabIndex = 4;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(50, 100);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 13);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Buscar archivos:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(50, 120);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(500, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(50, 410);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(218, 13);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "Filtrar por tipo de archivo (separados por comas):";
            // 
            // fileTypeTextBox
            // 
            this.fileTypeTextBox.Location = new System.Drawing.Point(50, 430);
            this.fileTypeTextBox.Name = "fileTypeTextBox";
            this.fileTypeTextBox.Size = new System.Drawing.Size(500, 20);
            this.fileTypeTextBox.TabIndex = 8;
            // 
            // outputButton
            // 
            this.outputButton.Enabled = false;
            this.outputButton.Location = new System.Drawing.Point(200, 460);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(200, 30);
            this.outputButton.TabIndex = 9;
            this.outputButton.Text = "Seleccionar Ubicación de Output";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(50, 500);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(500, 20);
            this.outputLabel.TabIndex = 10;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(50, 530);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(500, 20);
            this.progressBar.TabIndex = 11;
            // 
            // generateButton
            // 
            this.generateButton.Enabled = false;
            this.generateButton.Location = new System.Drawing.Point(200, 560);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(200, 30);
            this.generateButton.TabIndex = 12;
            this.generateButton.Text = "Generar Output";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.fileTypeTextBox);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.selectButton);
            this.Name = "Form1";
            this.Text = "Listado de Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.CheckedListBox fileListBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.TextBox fileTypeTextBox;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button generateButton;
    }
}
