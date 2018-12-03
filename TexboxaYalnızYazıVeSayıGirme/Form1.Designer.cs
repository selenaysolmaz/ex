namespace TexboxaYalnızYazıVeSayıGirme
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
            this.txt_YalnizKarakter = new System.Windows.Forms.TextBox();
            this.txt_YalnizSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CharacterCasingToLower = new System.Windows.Forms.TextBox();
            this.txt_CharacterCasingToUpper = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_YalnizKarakter
            // 
            this.txt_YalnizKarakter.Location = new System.Drawing.Point(147, 10);
            this.txt_YalnizKarakter.Name = "txt_YalnizKarakter";
            this.txt_YalnizKarakter.Size = new System.Drawing.Size(166, 22);
            this.txt_YalnizKarakter.TabIndex = 0;
            this.txt_YalnizKarakter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizKarakter_KeyPress);
            // 
            // txt_YalnizSayi
            // 
            this.txt_YalnizSayi.Location = new System.Drawing.Point(147, 48);
            this.txt_YalnizSayi.Name = "txt_YalnizSayi";
            this.txt_YalnizSayi.Size = new System.Drawing.Size(166, 22);
            this.txt_YalnizSayi.TabIndex = 1;
            this.txt_YalnizSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizSayi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı Gir :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Karakter Gir :";
            // 
            // txt_CharacterCasingToLower
            // 
            this.txt_CharacterCasingToLower.Location = new System.Drawing.Point(147, 124);
            this.txt_CharacterCasingToLower.Name = "txt_CharacterCasingToLower";
            this.txt_CharacterCasingToLower.Size = new System.Drawing.Size(166, 22);
            this.txt_CharacterCasingToLower.TabIndex = 5;
            this.txt_CharacterCasingToLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToLower_KeyPress);
            // 
            // txt_CharacterCasingToUpper
            // 
            this.txt_CharacterCasingToUpper.Location = new System.Drawing.Point(147, 86);
            this.txt_CharacterCasingToUpper.Name = "txt_CharacterCasingToUpper";
            this.txt_CharacterCasingToUpper.Size = new System.Drawing.Size(166, 22);
            this.txt_CharacterCasingToUpper.TabIndex = 6;
            this.txt_CharacterCasingToUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCasingToUpper_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Karakter Büyütme :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Karakter Küçültme :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txt_YalnizSayi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_YalnizKarakter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_CharacterCasingToUpper);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_CharacterCasingToLower);
            this.panel1.Location = new System.Drawing.Point(30, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 160);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 275);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_YalnizKarakter;
        private System.Windows.Forms.TextBox txt_YalnizSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CharacterCasingToLower;
        private System.Windows.Forms.TextBox txt_CharacterCasingToUpper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

