namespace RSA_cypher_ATM
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
            this.components = new System.ComponentModel.Container();
            this.ButtonEncrypt = new System.Windows.Forms.Button();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxE = new System.Windows.Forms.TextBox();
            this.LabelD = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.ButtonQ = new System.Windows.Forms.Label();
            this.TextboxQ = new System.Windows.Forms.TextBox();
            this.ButtonDecrypt = new System.Windows.Forms.Button();
            this.RichTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.CheckBoxNumeric = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonEncrypt
            // 
            this.ButtonEncrypt.Location = new System.Drawing.Point(123, 422);
            this.ButtonEncrypt.Name = "ButtonEncrypt";
            this.ButtonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncrypt.TabIndex = 0;
            this.ButtonEncrypt.Text = "Encrypt";
            this.ButtonEncrypt.UseVisualStyleBackColor = true;
            this.ButtonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // TextBoxP
            // 
            this.TextBoxP.Location = new System.Drawing.Point(64, 36);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(100, 20);
            this.TextBoxP.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ButtonP
            // 
            this.ButtonP.AutoSize = true;
            this.ButtonP.Location = new System.Drawing.Point(12, 36);
            this.ButtonP.Name = "ButtonP";
            this.ButtonP.Size = new System.Drawing.Size(13, 13);
            this.ButtonP.TabIndex = 6;
            this.ButtonP.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "e";
            // 
            // TextboxE
            // 
            this.TextboxE.Location = new System.Drawing.Point(64, 93);
            this.TextboxE.Name = "TextboxE";
            this.TextboxE.Size = new System.Drawing.Size(100, 20);
            this.TextboxE.TabIndex = 7;
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Location = new System.Drawing.Point(228, 93);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(13, 13);
            this.LabelD.TabIndex = 12;
            this.LabelD.Text = "d";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(288, 93);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.ReadOnly = true;
            this.TextBoxD.Size = new System.Drawing.Size(100, 20);
            this.TextBoxD.TabIndex = 11;
            // 
            // ButtonQ
            // 
            this.ButtonQ.AutoSize = true;
            this.ButtonQ.Location = new System.Drawing.Point(228, 36);
            this.ButtonQ.Name = "ButtonQ";
            this.ButtonQ.Size = new System.Drawing.Size(13, 13);
            this.ButtonQ.TabIndex = 10;
            this.ButtonQ.Text = "q";
            // 
            // TextboxQ
            // 
            this.TextboxQ.Location = new System.Drawing.Point(288, 36);
            this.TextboxQ.Name = "TextboxQ";
            this.TextboxQ.Size = new System.Drawing.Size(100, 20);
            this.TextboxQ.TabIndex = 9;
            // 
            // ButtonDecrypt
            // 
            this.ButtonDecrypt.Location = new System.Drawing.Point(234, 422);
            this.ButtonDecrypt.Name = "ButtonDecrypt";
            this.ButtonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.ButtonDecrypt.TabIndex = 13;
            this.ButtonDecrypt.Text = "Decrypt";
            this.ButtonDecrypt.UseVisualStyleBackColor = true;
            this.ButtonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // RichTextBoxInput
            // 
            this.RichTextBoxInput.Location = new System.Drawing.Point(89, 159);
            this.RichTextBoxInput.Name = "RichTextBoxInput";
            this.RichTextBoxInput.Size = new System.Drawing.Size(258, 96);
            this.RichTextBoxInput.TabIndex = 14;
            this.RichTextBoxInput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Plain Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cipher Text";
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(89, 282);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(258, 96);
            this.RichTextBoxOutput.TabIndex = 17;
            this.RichTextBoxOutput.Text = "";
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(178, 465);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
            this.ButtonGenerate.TabIndex = 19;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // CheckBoxNumeric
            // 
            this.CheckBoxNumeric.AutoSize = true;
            this.CheckBoxNumeric.Location = new System.Drawing.Point(178, 384);
            this.CheckBoxNumeric.Name = "CheckBoxNumeric";
            this.CheckBoxNumeric.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxNumeric.TabIndex = 20;
            this.CheckBoxNumeric.Text = "Numeric";
            this.CheckBoxNumeric.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 511);
            this.Controls.Add(this.CheckBoxNumeric);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichTextBoxInput);
            this.Controls.Add(this.ButtonDecrypt);
            this.Controls.Add(this.LabelD);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.ButtonQ);
            this.Controls.Add(this.TextboxQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxE);
            this.Controls.Add(this.ButtonP);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.ButtonEncrypt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEncrypt;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ButtonP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxE;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.Label ButtonQ;
        private System.Windows.Forms.TextBox TextboxQ;
        private System.Windows.Forms.Button ButtonDecrypt;
        private System.Windows.Forms.RichTextBox RichTextBoxInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.CheckBox CheckBoxNumeric;
    }
}

