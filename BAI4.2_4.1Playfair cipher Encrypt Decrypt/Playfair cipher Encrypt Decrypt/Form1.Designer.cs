namespace Playfair_cipher_Encrypt_Decrypt
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
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.ButtonEncrypt = new System.Windows.Forms.Button();
            this.TextBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDecrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomEncryptButton = new System.Windows.Forms.Button();
            this.Encrypt_Random_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(419, 53);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(296, 143);
            this.RichTextBoxOutput.TabIndex = 0;
            this.RichTextBoxOutput.Text = "";
            // 
            // RichTextBoxInput
            // 
            this.RichTextBoxInput.Location = new System.Drawing.Point(7, 53);
            this.RichTextBoxInput.Name = "RichTextBoxInput";
            this.RichTextBoxInput.Size = new System.Drawing.Size(296, 145);
            this.RichTextBoxInput.TabIndex = 1;
            this.RichTextBoxInput.Text = "";
            this.RichTextBoxInput.TextChanged += new System.EventHandler(this.RichTextBoxInput_TextChanged);
            // 
            // ButtonEncrypt
            // 
            this.ButtonEncrypt.Location = new System.Drawing.Point(7, 204);
            this.ButtonEncrypt.Name = "ButtonEncrypt";
            this.ButtonEncrypt.Size = new System.Drawing.Size(143, 23);
            this.ButtonEncrypt.TabIndex = 3;
            this.ButtonEncrypt.Text = "Encrypt";
            this.ButtonEncrypt.UseVisualStyleBackColor = true;
            this.ButtonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // TextBoxKey
            // 
            this.TextBoxKey.Location = new System.Drawing.Point(256, 311);
            this.TextBoxKey.Name = "TextBoxKey";
            this.TextBoxKey.Size = new System.Drawing.Size(219, 20);
            this.TextBoxKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key";
            // 
            // DataGridViewTable
            // 
            this.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DataGridViewTable.Location = new System.Drawing.Point(221, 337);
            this.DataGridViewTable.Name = "DataGridViewTable";
            this.DataGridViewTable.Size = new System.Drawing.Size(269, 145);
            this.DataGridViewTable.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "C1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "C2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 45;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "C4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "C5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 45;
            // 
            // ButtonDecrypt
            // 
            this.ButtonDecrypt.Location = new System.Drawing.Point(419, 202);
            this.ButtonDecrypt.Name = "ButtonDecrypt";
            this.ButtonDecrypt.Size = new System.Drawing.Size(143, 23);
            this.ButtonDecrypt.TabIndex = 8;
            this.ButtonDecrypt.Text = "Decrypt";
            this.ButtonDecrypt.UseVisualStyleBackColor = true;
            this.ButtonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Plain Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cipher Text";
            // 
            // RandomEncryptButton
            // 
            this.RandomEncryptButton.Location = new System.Drawing.Point(7, 233);
            this.RandomEncryptButton.Name = "RandomEncryptButton";
            this.RandomEncryptButton.Size = new System.Drawing.Size(143, 23);
            this.RandomEncryptButton.TabIndex = 12;
            this.RandomEncryptButton.Text = "Encrypt_Random_Button";
            this.RandomEncryptButton.UseVisualStyleBackColor = true;
            this.RandomEncryptButton.Click += new System.EventHandler(this.RandomEncryptButton_Click);
            // 
            // Encrypt_Random_All
            // 
            this.Encrypt_Random_All.Location = new System.Drawing.Point(7, 262);
            this.Encrypt_Random_All.Name = "Encrypt_Random_All";
            this.Encrypt_Random_All.Size = new System.Drawing.Size(143, 23);
            this.Encrypt_Random_All.TabIndex = 13;
            this.Encrypt_Random_All.Text = "Encrypt_Random_All";
            this.Encrypt_Random_All.UseVisualStyleBackColor = true;
            this.Encrypt_Random_All.Click += new System.EventHandler(this.Encrypt_Random_All_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 488);
            this.Controls.Add(this.Encrypt_Random_All);
            this.Controls.Add(this.RandomEncryptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDecrypt);
            this.Controls.Add(this.DataGridViewTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxKey);
            this.Controls.Add(this.ButtonEncrypt);
            this.Controls.Add(this.RichTextBoxInput);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.RichTextBox RichTextBoxInput;
        private System.Windows.Forms.Button ButtonEncrypt;
        private System.Windows.Forms.TextBox TextBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button ButtonDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RandomEncryptButton;
        private System.Windows.Forms.Button Encrypt_Random_All;
    }
}

