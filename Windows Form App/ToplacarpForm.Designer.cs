namespace teknokaucuk
{
    partial class ToplacarpForm
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
            this.textsayi1 = new System.Windows.Forms.TextBox();
            this.textsayi2 = new System.Windows.Forms.TextBox();
            this.textsayi3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textsonuc1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textsayi1
            // 
            this.textsayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsayi1.Location = new System.Drawing.Point(184, 21);
            this.textsayi1.Multiline = true;
            this.textsayi1.Name = "textsayi1";
            this.textsayi1.Size = new System.Drawing.Size(75, 32);
            this.textsayi1.TabIndex = 0;
            this.textsayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsayi1_KeyPress);
            // 
            // textsayi2
            // 
            this.textsayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsayi2.Location = new System.Drawing.Point(184, 71);
            this.textsayi2.Multiline = true;
            this.textsayi2.Name = "textsayi2";
            this.textsayi2.Size = new System.Drawing.Size(75, 32);
            this.textsayi2.TabIndex = 0;
            this.textsayi2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsayi2_KeyPress);
            // 
            // textsayi3
            // 
            this.textsayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsayi3.Location = new System.Drawing.Point(184, 122);
            this.textsayi3.Multiline = true;
            this.textsayi3.Name = "textsayi3";
            this.textsayi3.Size = new System.Drawing.Size(75, 32);
            this.textsayi3.TabIndex = 0;
            this.textsayi3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsayi3_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "İkinci Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Üçüncü Sayı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sonucu Göster ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textsonuc1
            // 
            this.textsonuc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsonuc1.Location = new System.Drawing.Point(184, 189);
            this.textsonuc1.Multiline = true;
            this.textsonuc1.Name = "textsonuc1";
            this.textsonuc1.ReadOnly = true;
            this.textsonuc1.Size = new System.Drawing.Size(75, 32);
            this.textsonuc1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(95, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sonuç";
            // 
            // ToplacarpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsonuc1);
            this.Controls.Add(this.textsayi3);
            this.Controls.Add(this.textsayi2);
            this.Controls.Add(this.textsayi1);
            this.Name = "ToplacarpForm";
            this.Text = "toplacarp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsayi1;
        private System.Windows.Forms.TextBox textsayi2;
        private System.Windows.Forms.TextBox textsayi3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textsonuc1;
        private System.Windows.Forms.Label label4;
    }
}