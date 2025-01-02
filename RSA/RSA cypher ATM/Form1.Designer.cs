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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dButtonGenerate = new System.Windows.Forms.Button();
            this.qButtonGenerate = new System.Windows.Forms.Button();
            this.eButtonGenerate = new System.Windows.Forms.Button();
            this.pButtonGenerate = new System.Windows.Forms.Button();
            this.LabelD = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.ButtonQ = new System.Windows.Forms.Label();
            this.TextboxQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxE = new System.Windows.Forms.TextBox();
            this.ButtonP = new System.Windows.Forms.Label();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxNumeric = new System.Windows.Forms.CheckBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RichTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.ButtonDecrypt = new System.Windows.Forms.Button();
            this.ButtonEncrypt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dButtonGenerate);
            this.panel1.Controls.Add(this.qButtonGenerate);
            this.panel1.Controls.Add(this.eButtonGenerate);
            this.panel1.Controls.Add(this.pButtonGenerate);
            this.panel1.Controls.Add(this.LabelD);
            this.panel1.Controls.Add(this.TextBoxD);
            this.panel1.Controls.Add(this.ButtonQ);
            this.panel1.Controls.Add(this.TextboxQ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextboxE);
            this.panel1.Controls.Add(this.ButtonP);
            this.panel1.Controls.Add(this.TextBoxP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 160);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Create public key and private key ";
            // 
            // dButtonGenerate
            // 
            this.dButtonGenerate.Location = new System.Drawing.Point(463, 117);
            this.dButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.dButtonGenerate.Name = "dButtonGenerate";
            this.dButtonGenerate.Size = new System.Drawing.Size(100, 28);
            this.dButtonGenerate.TabIndex = 43;
            this.dButtonGenerate.Text = "Generate";
            this.dButtonGenerate.UseVisualStyleBackColor = true;
            this.dButtonGenerate.Click += new System.EventHandler(this.dButtonGenerate_Click);
            // 
            // qButtonGenerate
            // 
            this.qButtonGenerate.Location = new System.Drawing.Point(463, 47);
            this.qButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.qButtonGenerate.Name = "qButtonGenerate";
            this.qButtonGenerate.Size = new System.Drawing.Size(100, 28);
            this.qButtonGenerate.TabIndex = 42;
            this.qButtonGenerate.Text = "Generate";
            this.qButtonGenerate.UseVisualStyleBackColor = true;
            this.qButtonGenerate.Click += new System.EventHandler(this.qButtonGenerate_Click);
            // 
            // eButtonGenerate
            // 
            this.eButtonGenerate.Location = new System.Drawing.Point(175, 117);
            this.eButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.eButtonGenerate.Name = "eButtonGenerate";
            this.eButtonGenerate.Size = new System.Drawing.Size(100, 28);
            this.eButtonGenerate.TabIndex = 41;
            this.eButtonGenerate.Text = "Generate";
            this.eButtonGenerate.UseVisualStyleBackColor = true;
            this.eButtonGenerate.Click += new System.EventHandler(this.eButtonGenerate_Click);
            // 
            // pButtonGenerate
            // 
            this.pButtonGenerate.Location = new System.Drawing.Point(175, 47);
            this.pButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.pButtonGenerate.Name = "pButtonGenerate";
            this.pButtonGenerate.Size = new System.Drawing.Size(100, 28);
            this.pButtonGenerate.TabIndex = 40;
            this.pButtonGenerate.Text = "Generate";
            this.pButtonGenerate.UseVisualStyleBackColor = true;
            this.pButtonGenerate.Click += new System.EventHandler(this.pButtonGenerate_Click);
            // 
            // LabelD
            // 
            this.LabelD.AutoSize = true;
            this.LabelD.Location = new System.Drawing.Point(300, 120);
            this.LabelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(15, 16);
            this.LabelD.TabIndex = 39;
            this.LabelD.Text = "d";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(323, 120);
            this.TextBoxD.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.ReadOnly = true;
            this.TextBoxD.Size = new System.Drawing.Size(132, 22);
            this.TextBoxD.TabIndex = 38;
            // 
            // ButtonQ
            // 
            this.ButtonQ.AutoSize = true;
            this.ButtonQ.Location = new System.Drawing.Point(300, 50);
            this.ButtonQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonQ.Name = "ButtonQ";
            this.ButtonQ.Size = new System.Drawing.Size(15, 16);
            this.ButtonQ.TabIndex = 37;
            this.ButtonQ.Text = "q";
            // 
            // TextboxQ
            // 
            this.TextboxQ.Location = new System.Drawing.Point(323, 50);
            this.TextboxQ.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQ.Name = "TextboxQ";
            this.TextboxQ.Size = new System.Drawing.Size(132, 22);
            this.TextboxQ.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "e";
            // 
            // TextboxE
            // 
            this.TextboxE.Location = new System.Drawing.Point(35, 120);
            this.TextboxE.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxE.Name = "TextboxE";
            this.TextboxE.Size = new System.Drawing.Size(132, 22);
            this.TextboxE.TabIndex = 34;
            // 
            // ButtonP
            // 
            this.ButtonP.AutoSize = true;
            this.ButtonP.Location = new System.Drawing.Point(12, 50);
            this.ButtonP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonP.Name = "ButtonP";
            this.ButtonP.Size = new System.Drawing.Size(15, 16);
            this.ButtonP.TabIndex = 33;
            this.ButtonP.Text = "p";
            // 
            // TextBoxP
            // 
            this.TextBoxP.Location = new System.Drawing.Point(35, 50);
            this.TextBoxP.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(132, 22);
            this.TextBoxP.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBoxPrivateKey);
            this.panel2.Controls.Add(this.textBoxPublicKey);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CheckBoxNumeric);
            this.panel2.Controls.Add(this.ButtonGenerate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.RichTextBoxOutput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.RichTextBoxInput);
            this.panel2.Controls.Add(this.ButtonDecrypt);
            this.panel2.Controls.Add(this.ButtonEncrypt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(574, 322);
            this.panel2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 248);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 43;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(89, 43);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(292, 22);
            this.textBoxPrivateKey.TabIndex = 42;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(89, 6);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(292, 22);
            this.textBoxPublicKey.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Public Key";
            // 
            // CheckBoxNumeric
            // 
            this.CheckBoxNumeric.AutoSize = true;
            this.CheckBoxNumeric.Location = new System.Drawing.Point(10, 236);
            this.CheckBoxNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxNumeric.Name = "CheckBoxNumeric";
            this.CheckBoxNumeric.Size = new System.Drawing.Size(79, 20);
            this.CheckBoxNumeric.TabIndex = 38;
            this.CheckBoxNumeric.Text = "Numeric";
            this.CheckBoxNumeric.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.Location = new System.Drawing.Point(356, 248);
            this.ButtonGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(100, 28);
            this.ButtonGenerate.TabIndex = 37;
            this.ButtonGenerate.Text = "Generate all";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cipher Text";
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(304, 111);
            this.RichTextBoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(260, 117);
            this.RichTextBoxOutput.TabIndex = 35;
            this.RichTextBoxOutput.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Plain Text";
            // 
            // RichTextBoxInput
            // 
            this.RichTextBoxInput.Location = new System.Drawing.Point(10, 111);
            this.RichTextBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.RichTextBoxInput.Name = "RichTextBoxInput";
            this.RichTextBoxInput.Size = new System.Drawing.Size(266, 117);
            this.RichTextBoxInput.TabIndex = 33;
            this.RichTextBoxInput.Text = "";
            // 
            // ButtonDecrypt
            // 
            this.ButtonDecrypt.Location = new System.Drawing.Point(248, 248);
            this.ButtonDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDecrypt.Name = "ButtonDecrypt";
            this.ButtonDecrypt.Size = new System.Drawing.Size(100, 28);
            this.ButtonDecrypt.TabIndex = 32;
            this.ButtonDecrypt.Text = "Decrypt";
            this.ButtonDecrypt.UseVisualStyleBackColor = true;
            this.ButtonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // ButtonEncrypt
            // 
            this.ButtonEncrypt.Location = new System.Drawing.Point(140, 248);
            this.ButtonEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEncrypt.Name = "ButtonEncrypt";
            this.ButtonEncrypt.Size = new System.Drawing.Size(100, 28);
            this.ButtonEncrypt.TabIndex = 31;
            this.ButtonEncrypt.Text = "Encrypt";
            this.ButtonEncrypt.UseVisualStyleBackColor = true;
            this.ButtonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Application RSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dButtonGenerate;
        private System.Windows.Forms.Button qButtonGenerate;
        private System.Windows.Forms.Button eButtonGenerate;
        private System.Windows.Forms.Button pButtonGenerate;
        private System.Windows.Forms.Label LabelD;
        private System.Windows.Forms.TextBox TextBoxD;
        private System.Windows.Forms.Label ButtonQ;
        private System.Windows.Forms.TextBox TextboxQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxE;
        private System.Windows.Forms.Label ButtonP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxNumeric;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RichTextBoxInput;
        private System.Windows.Forms.Button ButtonDecrypt;
        private System.Windows.Forms.Button ButtonEncrypt;
    }
}

