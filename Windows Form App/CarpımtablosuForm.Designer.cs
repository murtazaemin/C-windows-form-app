namespace teknokaucuk
{
    partial class CarpımtablosuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tablo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textsayi1
            // 
            this.textsayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textsayi1.Location = new System.Drawing.Point(34, 117);
            this.textsayi1.Multiline = true;
            this.textsayi1.Name = "textsayi1";
            this.textsayi1.Size = new System.Drawing.Size(100, 35);
            this.textsayi1.TabIndex = 1;
            this.textsayi1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsayi1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tablo Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablo1
            // 
            this.tablo1.AutoSize = true;
            this.tablo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablo1.Location = new System.Drawing.Point(160, 120);
            this.tablo1.Name = "tablo1";
            this.tablo1.Size = new System.Drawing.Size(0, 25);
            this.tablo1.TabIndex = 0;
            // 
            // CarpımtablosuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 557);
            this.Controls.Add(this.tablo1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textsayi1);
            this.Name = "CarpımtablosuForm";
            this.Text = "CarpımtablosuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textsayi1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tablo1;


    }
}