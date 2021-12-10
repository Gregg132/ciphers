namespace Vernamnxcaesar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCipher = new System.Windows.Forms.Label();
            this.LblPlain = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TbxKey = new System.Windows.Forms.TextBox();
            this.ComType = new System.Windows.Forms.ComboBox();
            this.LblKey = new System.Windows.Forms.Label();
            this.TbxCiphert = new System.Windows.Forms.TextBox();
            this.TbxPlain = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.LblCipher);
            this.panel1.Controls.Add(this.LblPlain);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TbxCiphert);
            this.panel1.Controls.Add(this.TbxPlain);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 211);
            this.panel1.TabIndex = 0;
            // 
            // LblCipher
            // 
            this.LblCipher.AutoSize = true;
            this.LblCipher.Location = new System.Drawing.Point(3, 111);
            this.LblCipher.Name = "LblCipher";
            this.LblCipher.Size = new System.Drawing.Size(54, 13);
            this.LblCipher.TabIndex = 7;
            this.LblCipher.Text = "Ciphertext";
            // 
            // LblPlain
            // 
            this.LblPlain.AutoSize = true;
            this.LblPlain.Location = new System.Drawing.Point(3, 4);
            this.LblPlain.Name = "LblPlain";
            this.LblPlain.Size = new System.Drawing.Size(47, 13);
            this.LblPlain.TabIndex = 6;
            this.LblPlain.Text = "Plaintext";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.TbxKey);
            this.panel2.Controls.Add(this.ComType);
            this.panel2.Controls.Add(this.LblKey);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(282, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 49);
            this.panel2.TabIndex = 5;
            // 
            // TbxKey
            // 
            this.TbxKey.Location = new System.Drawing.Point(34, 3);
            this.TbxKey.Name = "TbxKey";
            this.TbxKey.Size = new System.Drawing.Size(121, 20);
            this.TbxKey.TabIndex = 1;
            this.TbxKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbxKey_MouseClick);
            this.TbxKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxKey_KeyPress);
            // 
            // ComType
            // 
            this.ComType.FormattingEnabled = true;
            this.ComType.Items.AddRange(new object[] {
            "Caesar",
            "Vernam"});
            this.ComType.Location = new System.Drawing.Point(34, 25);
            this.ComType.Name = "ComType";
            this.ComType.Size = new System.Drawing.Size(121, 21);
            this.ComType.TabIndex = 4;
            this.ComType.Text = "Caesar";
            // 
            // LblKey
            // 
            this.LblKey.AutoSize = true;
            this.LblKey.Location = new System.Drawing.Point(3, 6);
            this.LblKey.Name = "LblKey";
            this.LblKey.Size = new System.Drawing.Size(28, 13);
            this.LblKey.TabIndex = 0;
            this.LblKey.Text = "Key:";
            // 
            // TbxCiphert
            // 
            this.TbxCiphert.Location = new System.Drawing.Point(3, 127);
            this.TbxCiphert.Multiline = true;
            this.TbxCiphert.Name = "TbxCiphert";
            this.TbxCiphert.Size = new System.Drawing.Size(216, 81);
            this.TbxCiphert.TabIndex = 1;
            // 
            // TbxPlain
            // 
            this.TbxPlain.Location = new System.Drawing.Point(3, 20);
            this.TbxPlain.Multiline = true;
            this.TbxPlain.Name = "TbxPlain";
            this.TbxPlain.Size = new System.Drawing.Size(216, 88);
            this.TbxPlain.TabIndex = 0;
            this.TbxPlain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPlain_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 236);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComType;
        private System.Windows.Forms.TextBox TbxCiphert;
        private System.Windows.Forms.TextBox TbxPlain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TbxKey;
        private System.Windows.Forms.Label LblKey;
        private System.Windows.Forms.Label LblCipher;
        private System.Windows.Forms.Label LblPlain;
    }
}

