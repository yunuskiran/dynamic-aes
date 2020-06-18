namespace dynamic_aes
{
    partial class FrmEncrypte
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
            this.btnEncrpyte = new System.Windows.Forms.Button();
            this.rbtn128 = new System.Windows.Forms.RadioButton();
            this.rbt192 = new System.Windows.Forms.RadioButton();
            this.rbt256 = new System.Windows.Forms.RadioButton();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrpyte
            // 
            this.btnEncrpyte.Location = new System.Drawing.Point(12, 102);
            this.btnEncrpyte.Name = "btnEncrpyte";
            this.btnEncrpyte.Size = new System.Drawing.Size(284, 23);
            this.btnEncrpyte.TabIndex = 0;
            this.btnEncrpyte.Text = "Encrypt";
            this.btnEncrpyte.UseVisualStyleBackColor = true;
            this.btnEncrpyte.Click += new System.EventHandler(this.btnEncrpyte_Click);
            // 
            // rbtn128
            // 
            this.rbtn128.AutoSize = true;
            this.rbtn128.Location = new System.Drawing.Point(24, 20);
            this.rbtn128.Name = "rbtn128";
            this.rbtn128.Size = new System.Drawing.Size(43, 17);
            this.rbtn128.TabIndex = 1;
            this.rbtn128.TabStop = true;
            this.rbtn128.Text = "128";
            this.rbtn128.UseVisualStyleBackColor = true;
            // 
            // rbt192
            // 
            this.rbt192.AutoSize = true;
            this.rbt192.Location = new System.Drawing.Point(24, 43);
            this.rbt192.Name = "rbt192";
            this.rbt192.Size = new System.Drawing.Size(43, 17);
            this.rbt192.TabIndex = 2;
            this.rbt192.TabStop = true;
            this.rbt192.Text = "192";
            this.rbt192.UseVisualStyleBackColor = true;
            // 
            // rbt256
            // 
            this.rbt256.AutoSize = true;
            this.rbt256.Location = new System.Drawing.Point(24, 66);
            this.rbt256.Name = "rbt256";
            this.rbt256.Size = new System.Drawing.Size(43, 17);
            this.rbt256.TabIndex = 3;
            this.rbt256.TabStop = true;
            this.rbt256.Text = "256";
            this.rbt256.UseVisualStyleBackColor = true;
            // 
            // txtPlainText
            // 
            this.txtPlainText.Location = new System.Drawing.Point(75, 29);
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(100, 20);
            this.txtPlainText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Planin Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(75, 67);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt256);
            this.groupBox1.Controls.Add(this.rbt192);
            this.groupBox1.Controls.Add(this.rbtn128);
            this.groupBox1.Location = new System.Drawing.Point(181, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 90);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KeySize";
            // 
            // FrmEncrypte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 130);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.btnEncrpyte);
            this.Name = "FrmEncrypte";
            this.Text = "Aes Encryption";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrpyte;
        private System.Windows.Forms.RadioButton rbtn128;
        private System.Windows.Forms.RadioButton rbt192;
        private System.Windows.Forms.RadioButton rbt256;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

