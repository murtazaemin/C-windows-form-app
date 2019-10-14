namespace teknokaucuk
{
    partial class ZigzagForm
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
            this.sayilar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayilar
            // 
            this.sayilar.AutoSize = true;
            this.sayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayilar.Location = new System.Drawing.Point(12, 36);
            this.sayilar.Name = "sayilar";
            this.sayilar.Size = new System.Drawing.Size(0, 25);
            this.sayilar.TabIndex = 0;
            // 
            // ZigzagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 597);
            this.Controls.Add(this.sayilar);
            this.Name = "ZigzagForm";
            this.Text = "ZigzagForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sayilar;
    }
}