namespace ProductsUI
{
    partial class Dashboard
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
            this.productLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.productsFoundListBox = new System.Windows.Forms.ListBox();
            this.productText = new System.Windows.Forms.TextBox();
            this.modelNumberInsText = new System.Windows.Forms.TextBox();
            this.modelNumberInsLabel = new System.Windows.Forms.Label();
            this.manufacturerInsText = new System.Windows.Forms.TextBox();
            this.manufacturerInsLabel = new System.Windows.Forms.Label();
            this.descriptionInsText = new System.Windows.Forms.TextBox();
            this.descriptionInsLabel = new System.Windows.Forms.Label();
            this.sizeInsText = new System.Windows.Forms.TextBox();
            this.sizeInsLabel = new System.Windows.Forms.Label();
            this.typeInsText = new System.Windows.Forms.TextBox();
            this.typeInsLabel = new System.Windows.Forms.Label();
            this.insertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 57);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(44, 13);
            this.productLabel.TabIndex = 2;
            this.productLabel.Text = "Product";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(397, 47);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productsFoundListBox
            // 
            this.productsFoundListBox.FormattingEnabled = true;
            this.productsFoundListBox.Location = new System.Drawing.Point(12, 76);
            this.productsFoundListBox.Name = "productsFoundListBox";
            this.productsFoundListBox.Size = new System.Drawing.Size(460, 134);
            this.productsFoundListBox.TabIndex = 4;
            // 
            // productText
            // 
            this.productText.Location = new System.Drawing.Point(62, 50);
            this.productText.Name = "productText";
            this.productText.Size = new System.Drawing.Size(257, 20);
            this.productText.TabIndex = 5;
            // 
            // modelNumberInsText
            // 
            this.modelNumberInsText.Location = new System.Drawing.Point(141, 269);
            this.modelNumberInsText.Name = "modelNumberInsText";
            this.modelNumberInsText.Size = new System.Drawing.Size(257, 20);
            this.modelNumberInsText.TabIndex = 7;
            // 
            // modelNumberInsLabel
            // 
            this.modelNumberInsLabel.AutoSize = true;
            this.modelNumberInsLabel.Location = new System.Drawing.Point(59, 269);
            this.modelNumberInsLabel.Name = "modelNumberInsLabel";
            this.modelNumberInsLabel.Size = new System.Drawing.Size(76, 13);
            this.modelNumberInsLabel.TabIndex = 6;
            this.modelNumberInsLabel.Text = "Model Number";
            // 
            // manufacturerInsText
            // 
            this.manufacturerInsText.Location = new System.Drawing.Point(141, 295);
            this.manufacturerInsText.Name = "manufacturerInsText";
            this.manufacturerInsText.Size = new System.Drawing.Size(257, 20);
            this.manufacturerInsText.TabIndex = 9;
            // 
            // manufacturerInsLabel
            // 
            this.manufacturerInsLabel.AutoSize = true;
            this.manufacturerInsLabel.Location = new System.Drawing.Point(65, 295);
            this.manufacturerInsLabel.Name = "manufacturerInsLabel";
            this.manufacturerInsLabel.Size = new System.Drawing.Size(70, 13);
            this.manufacturerInsLabel.TabIndex = 8;
            this.manufacturerInsLabel.Text = "Manufacturer";
            // 
            // descriptionInsText
            // 
            this.descriptionInsText.Location = new System.Drawing.Point(141, 321);
            this.descriptionInsText.Name = "descriptionInsText";
            this.descriptionInsText.Size = new System.Drawing.Size(257, 20);
            this.descriptionInsText.TabIndex = 11;
            // 
            // descriptionInsLabel
            // 
            this.descriptionInsLabel.AutoSize = true;
            this.descriptionInsLabel.Location = new System.Drawing.Point(75, 321);
            this.descriptionInsLabel.Name = "descriptionInsLabel";
            this.descriptionInsLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionInsLabel.TabIndex = 10;
            this.descriptionInsLabel.Text = "Description";
            // 
            // sizeInsText
            // 
            this.sizeInsText.Location = new System.Drawing.Point(141, 347);
            this.sizeInsText.Name = "sizeInsText";
            this.sizeInsText.Size = new System.Drawing.Size(257, 20);
            this.sizeInsText.TabIndex = 13;
            // 
            // sizeInsLabel
            // 
            this.sizeInsLabel.AutoSize = true;
            this.sizeInsLabel.Location = new System.Drawing.Point(108, 347);
            this.sizeInsLabel.Name = "sizeInsLabel";
            this.sizeInsLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeInsLabel.TabIndex = 12;
            this.sizeInsLabel.Text = "Size";
            // 
            // typeInsText
            // 
            this.typeInsText.Location = new System.Drawing.Point(141, 373);
            this.typeInsText.Name = "typeInsText";
            this.typeInsText.Size = new System.Drawing.Size(257, 20);
            this.typeInsText.TabIndex = 15;
            // 
            // typeInsLabel
            // 
            this.typeInsLabel.AutoSize = true;
            this.typeInsLabel.Location = new System.Drawing.Point(36, 373);
            this.typeInsLabel.Name = "typeInsLabel";
            this.typeInsLabel.Size = new System.Drawing.Size(96, 13);
            this.typeInsLabel.TabIndex = 14;
            this.typeInsLabel.Text = "Configuration Type";
            // 
            // insertRecordButton
            // 
            this.insertRecordButton.Location = new System.Drawing.Point(229, 415);
            this.insertRecordButton.Name = "insertRecordButton";
            this.insertRecordButton.Size = new System.Drawing.Size(75, 23);
            this.insertRecordButton.TabIndex = 16;
            this.insertRecordButton.Text = "Insert";
            this.insertRecordButton.UseVisualStyleBackColor = true;
            this.insertRecordButton.Click += new System.EventHandler(this.insertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertRecordButton);
            this.Controls.Add(this.typeInsText);
            this.Controls.Add(this.typeInsLabel);
            this.Controls.Add(this.sizeInsText);
            this.Controls.Add(this.sizeInsLabel);
            this.Controls.Add(this.descriptionInsText);
            this.Controls.Add(this.descriptionInsLabel);
            this.Controls.Add(this.manufacturerInsText);
            this.Controls.Add(this.manufacturerInsLabel);
            this.Controls.Add(this.modelNumberInsText);
            this.Controls.Add(this.modelNumberInsLabel);
            this.Controls.Add(this.productText);
            this.Controls.Add(this.productsFoundListBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.productLabel);
            this.Name = "Dashboard";
            this.Text = "searchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListBox productsFoundListBox;
        private System.Windows.Forms.TextBox productText;
        private System.Windows.Forms.TextBox modelNumberInsText;
        private System.Windows.Forms.Label modelNumberInsLabel;
        private System.Windows.Forms.TextBox manufacturerInsText;
        private System.Windows.Forms.Label manufacturerInsLabel;
        private System.Windows.Forms.TextBox descriptionInsText;
        private System.Windows.Forms.Label descriptionInsLabel;
        private System.Windows.Forms.TextBox sizeInsText;
        private System.Windows.Forms.Label sizeInsLabel;
        private System.Windows.Forms.TextBox typeInsText;
        private System.Windows.Forms.Label typeInsLabel;
        private System.Windows.Forms.Button insertRecordButton;
    }
}

