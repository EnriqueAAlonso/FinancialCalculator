namespace FinancialCalculator
{
    partial class Individual
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
            this.anexo11 = new FinancialCalculator.UserControls.Anexo1();
            this.SuspendLayout();
            // 
            // anexo11
            // 
            this.anexo11.Location = new System.Drawing.Point(12, 12);
            this.anexo11.Name = "anexo11";
            this.anexo11.Size = new System.Drawing.Size(308, 387);
            this.anexo11.TabIndex = 0;
            // 
            // Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 329);
            this.Controls.Add(this.anexo11);
            this.Name = "Individual";
            this.Text = "Individual";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Anexo1 anexo11;
    }
}