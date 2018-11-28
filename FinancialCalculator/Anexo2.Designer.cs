namespace FinancialCalculator
{
    partial class Anexo2
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
            this.excelView1 = new FinancialCalculator.UserControls.ExcelView();
            this.SuspendLayout();
            // 
            // excelView1
            // 
            this.excelView1.Location = new System.Drawing.Point(0, 0);
            this.excelView1.Name = "excelView1";
            this.excelView1.Size = new System.Drawing.Size(701, 642);
            this.excelView1.TabIndex = 0;
            // 
            // Anexo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 637);
            this.Controls.Add(this.excelView1);
            this.Name = "Anexo2";
            this.Text = "Anexo2";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ExcelView excelView1;
    }
}