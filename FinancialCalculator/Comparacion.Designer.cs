namespace FinancialCalculator
{
    partial class Comparacion
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
            this.compare1 = new FinancialCalculator.Compare();
            this.SuspendLayout();
            // 
            // compare1
            // 
            this.compare1.Location = new System.Drawing.Point(0, 0);
            this.compare1.Name = "compare1";
            this.compare1.Size = new System.Drawing.Size(1196, 698);
            this.compare1.TabIndex = 0;
            // 
            // Comparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 693);
            this.Controls.Add(this.compare1);
            this.Name = "Comparacion";
            this.Text = "Comparacion";
            this.ResumeLayout(false);

        }

        #endregion

        private Compare compare1;
    }
}