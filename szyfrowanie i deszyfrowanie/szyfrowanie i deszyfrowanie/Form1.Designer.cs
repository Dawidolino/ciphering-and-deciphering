namespace szyfrowanie_i_deszyfrowanie
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saveButton = new System.Windows.Forms.Button();
            this.decryptionButton2 = new System.Windows.Forms.Button();
            this.encryptionButton2 = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptionBox = new System.Windows.Forms.TextBox();
            this.encryptionBox = new System.Windows.Forms.TextBox();
            this.decryptionText = new System.Windows.Forms.Label();
            this.encryptionText = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.enterText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Location = new System.Drawing.Point(521, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(49, 36);
            this.saveButton.TabIndex = 35;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // decryptionButton2
            // 
            this.decryptionButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptionButton2.Location = new System.Drawing.Point(494, 98);
            this.decryptionButton2.Name = "decryptionButton2";
            this.decryptionButton2.Size = new System.Drawing.Size(75, 23);
            this.decryptionButton2.TabIndex = 34;
            this.decryptionButton2.Text = "Decrypt2";
            this.decryptionButton2.UseVisualStyleBackColor = true;
            this.decryptionButton2.Click += new System.EventHandler(this.decryptionButton2_Click);
            // 
            // encryptionButton2
            // 
            this.encryptionButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptionButton2.Location = new System.Drawing.Point(494, 56);
            this.encryptionButton2.Name = "encryptionButton2";
            this.encryptionButton2.Size = new System.Drawing.Size(75, 23);
            this.encryptionButton2.TabIndex = 33;
            this.encryptionButton2.Text = "Encrypt2";
            this.encryptionButton2.UseVisualStyleBackColor = true;
            this.encryptionButton2.Click += new System.EventHandler(this.encryptionButton2_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loadButton.BackgroundImage")));
            this.loadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadButton.Location = new System.Drawing.Point(413, 14);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(49, 35);
            this.loadButton.TabIndex = 32;
            this.loadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.Location = new System.Drawing.Point(413, 98);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 31;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.Location = new System.Drawing.Point(413, 56);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 30;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptionBox
            // 
            this.decryptionBox.Location = new System.Drawing.Point(124, 101);
            this.decryptionBox.Multiline = true;
            this.decryptionBox.Name = "decryptionBox";
            this.decryptionBox.Size = new System.Drawing.Size(283, 20);
            this.decryptionBox.TabIndex = 29;
            // 
            // encryptionBox
            // 
            this.encryptionBox.Location = new System.Drawing.Point(124, 59);
            this.encryptionBox.Multiline = true;
            this.encryptionBox.Name = "encryptionBox";
            this.encryptionBox.Size = new System.Drawing.Size(283, 20);
            this.encryptionBox.TabIndex = 28;
            // 
            // decryptionText
            // 
            this.decryptionText.AutoSize = true;
            this.decryptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.decryptionText.Location = new System.Drawing.Point(35, 103);
            this.decryptionText.Name = "decryptionText";
            this.decryptionText.Size = new System.Drawing.Size(83, 18);
            this.decryptionText.TabIndex = 27;
            this.decryptionText.Text = "Decryption:";
            // 
            // encryptionText
            // 
            this.encryptionText.AutoSize = true;
            this.encryptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encryptionText.Location = new System.Drawing.Point(35, 61);
            this.encryptionText.Name = "encryptionText";
            this.encryptionText.Size = new System.Drawing.Size(82, 18);
            this.encryptionText.TabIndex = 26;
            this.encryptionText.Text = "Encryption:";
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearButton.BackgroundImage")));
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.Location = new System.Drawing.Point(467, 15);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(49, 35);
            this.clearButton.TabIndex = 25;
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(124, 22);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(283, 20);
            this.textBox.TabIndex = 24;
            // 
            // enterText
            // 
            this.enterText.AutoSize = true;
            this.enterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.enterText.Location = new System.Drawing.Point(11, 23);
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(107, 18);
            this.enterText.TabIndex = 23;
            this.enterText.Text = "Enter text here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 147);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.decryptionButton2);
            this.Controls.Add(this.encryptionButton2);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptionBox);
            this.Controls.Add(this.encryptionBox);
            this.Controls.Add(this.decryptionText);
            this.Controls.Add(this.encryptionText);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.enterText);
            this.Name = "Form1";
            this.Text = "szyfrowanie i deszyfrowanie tesktu Dawid Ruth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button decryptionButton2;
        private System.Windows.Forms.Button encryptionButton2;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox decryptionBox;
        private System.Windows.Forms.TextBox encryptionBox;
        private System.Windows.Forms.Label decryptionText;
        private System.Windows.Forms.Label encryptionText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label enterText;
    }
}

