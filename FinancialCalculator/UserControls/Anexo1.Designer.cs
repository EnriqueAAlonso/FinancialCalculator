namespace FinancialCalculator.UserControls
{
    partial class Anexo1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Selection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeriodBox = new System.Windows.Forms.NumericUpDown();
            this.interest = new System.Windows.Forms.NumericUpDown();
            this.InputValue = new System.Windows.Forms.NumericUpDown();
            this.periodLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.mainValueLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValue)).BeginInit();
            this.SuspendLayout();
            // 
            // Selection
            // 
            this.Selection.Location = new System.Drawing.Point(28, 31);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(121, 21);
            this.Selection.TabIndex = 0;
            this.Selection.SelectedIndexChanged += new System.EventHandler(this.Selection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operación";
            // 
            // PeriodBox
            // 
            this.PeriodBox.Location = new System.Drawing.Point(28, 95);
            this.PeriodBox.Name = "PeriodBox";
            this.PeriodBox.Size = new System.Drawing.Size(120, 20);
            this.PeriodBox.TabIndex = 2;
            this.PeriodBox.ValueChanged += new System.EventHandler(this.PeriodBox_ValueChanged);
            // 
            // interest
            // 
            this.interest.Location = new System.Drawing.Point(29, 152);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(120, 20);
            this.interest.TabIndex = 3;
            this.interest.ValueChanged += new System.EventHandler(this.interest_ValueChanged);
            // 
            // InputValue
            // 
            this.InputValue.DecimalPlaces = 2;
            this.InputValue.Location = new System.Drawing.Point(29, 216);
            this.InputValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(120, 20);
            this.InputValue.TabIndex = 4;
            this.InputValue.ValueChanged += new System.EventHandler(this.InputValue_ValueChanged);
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(26, 79);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(105, 13);
            this.periodLabel.TabIndex = 5;
            this.periodLabel.Text = "Número de Períodos";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(26, 136);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(56, 13);
            this.interestLabel.TabIndex = 6;
            this.interestLabel.Text = "Interés (%)";
            // 
            // mainValueLabel
            // 
            this.mainValueLabel.AutoSize = true;
            this.mainValueLabel.Location = new System.Drawing.Point(26, 200);
            this.mainValueLabel.Name = "mainValueLabel";
            this.mainValueLabel.Size = new System.Drawing.Size(76, 13);
            this.mainValueLabel.TabIndex = 7;
            this.mainValueLabel.Text = "Valor Presente";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(29, 274);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calcular";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Anexo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.mainValueLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.periodLabel);
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.PeriodBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selection);
            this.Name = "Anexo1";
            this.Size = new System.Drawing.Size(308, 387);
            ((System.ComponentModel.ISupportInitialize)(this.PeriodBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Selection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PeriodBox;
        private System.Windows.Forms.NumericUpDown interest;
        private System.Windows.Forms.NumericUpDown InputValue;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label mainValueLabel;
        private System.Windows.Forms.Button calculate;
    }
}
