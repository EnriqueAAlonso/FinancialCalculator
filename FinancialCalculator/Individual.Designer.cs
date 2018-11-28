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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Individual));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideP = new System.Windows.Forms.Panel();
            this.F_G = new System.Windows.Forms.Button();
            this.A_G = new System.Windows.Forms.Button();
            this.F_P = new System.Windows.Forms.Button();
            this.P_F = new System.Windows.Forms.Button();
            this.F_A = new System.Windows.Forms.Button();
            this.A_F = new System.Windows.Forms.Button();
            this.A_P = new System.Windows.Forms.Button();
            this.P_A = new System.Windows.Forms.Button();
            this.P_G = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IEF_btn = new System.Windows.Forms.Button();
            this.AnexoDos_btn = new System.Windows.Forms.Button();
            this.anexo11 = new FinancialCalculator.UserControls.Anexo1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.AnexoDos_btn);
            this.panel1.Controls.Add(this.IEF_btn);
            this.panel1.Controls.Add(this.sideP);
            this.panel1.Controls.Add(this.F_G);
            this.panel1.Controls.Add(this.A_G);
            this.panel1.Controls.Add(this.F_P);
            this.panel1.Controls.Add(this.P_F);
            this.panel1.Controls.Add(this.F_A);
            this.panel1.Controls.Add(this.A_F);
            this.panel1.Controls.Add(this.A_P);
            this.panel1.Controls.Add(this.P_A);
            this.panel1.Controls.Add(this.P_G);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 817);
            this.panel1.TabIndex = 1;
            // 
            // sideP
            // 
            this.sideP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.sideP.Location = new System.Drawing.Point(3, 88);
            this.sideP.Name = "sideP";
            this.sideP.Size = new System.Drawing.Size(10, 60);
            this.sideP.TabIndex = 19;
            // 
            // F_G
            // 
            this.F_G.FlatAppearance.BorderSize = 0;
            this.F_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F_G.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_G.ForeColor = System.Drawing.Color.Gainsboro;
            this.F_G.Image = ((System.Drawing.Image)(resources.GetObject("F_G.Image")));
            this.F_G.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.F_G.Location = new System.Drawing.Point(12, 616);
            this.F_G.Name = "F_G";
            this.F_G.Size = new System.Drawing.Size(385, 60);
            this.F_G.TabIndex = 18;
            this.F_G.Text = " F/G  (Futuro dado Gradiente)";
            this.F_G.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F_G.UseVisualStyleBackColor = true;
            this.F_G.Click += new System.EventHandler(this.F_G_Click);
            // 
            // A_G
            // 
            this.A_G.FlatAppearance.BorderSize = 0;
            this.A_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_G.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_G.ForeColor = System.Drawing.Color.Gainsboro;
            this.A_G.Image = ((System.Drawing.Image)(resources.GetObject("A_G.Image")));
            this.A_G.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.A_G.Location = new System.Drawing.Point(12, 550);
            this.A_G.Name = "A_G";
            this.A_G.Size = new System.Drawing.Size(385, 60);
            this.A_G.TabIndex = 17;
            this.A_G.Text = " A/G (Anualidad dado Gradiente)";
            this.A_G.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.A_G.UseVisualStyleBackColor = true;
            this.A_G.Click += new System.EventHandler(this.A_G_Click);
            // 
            // F_P
            // 
            this.F_P.FlatAppearance.BorderSize = 0;
            this.F_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F_P.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_P.ForeColor = System.Drawing.Color.Gainsboro;
            this.F_P.Image = ((System.Drawing.Image)(resources.GetObject("F_P.Image")));
            this.F_P.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.F_P.Location = new System.Drawing.Point(12, 88);
            this.F_P.Name = "F_P";
            this.F_P.Size = new System.Drawing.Size(385, 60);
            this.F_P.TabIndex = 16;
            this.F_P.Text = " F/P (Valor futuro)";
            this.F_P.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F_P.UseVisualStyleBackColor = true;
            this.F_P.Click += new System.EventHandler(this.F_P_Click);
            // 
            // P_F
            // 
            this.P_F.FlatAppearance.BorderSize = 0;
            this.P_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P_F.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_F.ForeColor = System.Drawing.Color.Gainsboro;
            this.P_F.Image = ((System.Drawing.Image)(resources.GetObject("P_F.Image")));
            this.P_F.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.P_F.Location = new System.Drawing.Point(12, 154);
            this.P_F.Name = "P_F";
            this.P_F.Size = new System.Drawing.Size(385, 60);
            this.P_F.TabIndex = 15;
            this.P_F.Text = " P/F (Valor presente)";
            this.P_F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.P_F.UseVisualStyleBackColor = true;
            this.P_F.Click += new System.EventHandler(this.P_F_Click);
            // 
            // F_A
            // 
            this.F_A.FlatAppearance.BorderSize = 0;
            this.F_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.F_A.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_A.ForeColor = System.Drawing.Color.Gainsboro;
            this.F_A.Image = ((System.Drawing.Image)(resources.GetObject("F_A.Image")));
            this.F_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.F_A.Location = new System.Drawing.Point(12, 220);
            this.F_A.Name = "F_A";
            this.F_A.Size = new System.Drawing.Size(385, 60);
            this.F_A.TabIndex = 14;
            this.F_A.Text = " F/A (Valor futuro)";
            this.F_A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.F_A.UseVisualStyleBackColor = true;
            this.F_A.Click += new System.EventHandler(this.F_A_Click);
            // 
            // A_F
            // 
            this.A_F.FlatAppearance.BorderSize = 0;
            this.A_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_F.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_F.ForeColor = System.Drawing.Color.Gainsboro;
            this.A_F.Image = ((System.Drawing.Image)(resources.GetObject("A_F.Image")));
            this.A_F.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.A_F.Location = new System.Drawing.Point(12, 286);
            this.A_F.Name = "A_F";
            this.A_F.Size = new System.Drawing.Size(385, 60);
            this.A_F.TabIndex = 13;
            this.A_F.Text = " A/F (Fondo de amortización)";
            this.A_F.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.A_F.UseVisualStyleBackColor = true;
            this.A_F.Click += new System.EventHandler(this.A_F_Click);
            // 
            // A_P
            // 
            this.A_P.FlatAppearance.BorderSize = 0;
            this.A_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A_P.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_P.ForeColor = System.Drawing.Color.Gainsboro;
            this.A_P.Image = ((System.Drawing.Image)(resources.GetObject("A_P.Image")));
            this.A_P.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.A_P.Location = new System.Drawing.Point(12, 418);
            this.A_P.Name = "A_P";
            this.A_P.Size = new System.Drawing.Size(385, 60);
            this.A_P.TabIndex = 12;
            this.A_P.Text = " A/P (Recuperación de capital)";
            this.A_P.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.A_P.UseVisualStyleBackColor = true;
            this.A_P.Click += new System.EventHandler(this.A_P_Click);
            // 
            // P_A
            // 
            this.P_A.FlatAppearance.BorderSize = 0;
            this.P_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P_A.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_A.ForeColor = System.Drawing.Color.Gainsboro;
            this.P_A.Image = ((System.Drawing.Image)(resources.GetObject("P_A.Image")));
            this.P_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.P_A.Location = new System.Drawing.Point(12, 352);
            this.P_A.Name = "P_A";
            this.P_A.Size = new System.Drawing.Size(385, 60);
            this.P_A.TabIndex = 11;
            this.P_A.Text = " P/A (Valor presente)";
            this.P_A.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.P_A.UseVisualStyleBackColor = true;
            this.P_A.Click += new System.EventHandler(this.P_A_Click);
            // 
            // P_G
            // 
            this.P_G.FlatAppearance.BorderSize = 0;
            this.P_G.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.P_G.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P_G.ForeColor = System.Drawing.Color.Gainsboro;
            this.P_G.Image = ((System.Drawing.Image)(resources.GetObject("P_G.Image")));
            this.P_G.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.P_G.Location = new System.Drawing.Point(12, 484);
            this.P_G.Name = "P_G";
            this.P_G.Size = new System.Drawing.Size(385, 60);
            this.P_G.TabIndex = 9;
            this.P_G.Text = " P/G (Presente dado Gradiente)";
            this.P_G.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.P_G.UseVisualStyleBackColor = true;
            this.P_G.Click += new System.EventHandler(this.P_G_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 82);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.panel4.Location = new System.Drawing.Point(3, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 2);
            this.panel4.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(116, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Individuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(150)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(402, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 82);
            this.panel3.TabIndex = 3;
            // 
            // IEF_btn
            // 
            this.IEF_btn.FlatAppearance.BorderSize = 0;
            this.IEF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IEF_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IEF_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.IEF_btn.Image = ((System.Drawing.Image)(resources.GetObject("IEF_btn.Image")));
            this.IEF_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IEF_btn.Location = new System.Drawing.Point(12, 682);
            this.IEF_btn.Name = "IEF_btn";
            this.IEF_btn.Size = new System.Drawing.Size(385, 60);
            this.IEF_btn.TabIndex = 20;
            this.IEF_btn.Text = " IEF (Interés Efectivo)";
            this.IEF_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IEF_btn.UseVisualStyleBackColor = true;
            this.IEF_btn.Click += new System.EventHandler(this.IEF_btn_Click);
            // 
            // AnexoDos_btn
            // 
            this.AnexoDos_btn.FlatAppearance.BorderSize = 0;
            this.AnexoDos_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnexoDos_btn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnexoDos_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AnexoDos_btn.Image = ((System.Drawing.Image)(resources.GetObject("AnexoDos_btn.Image")));
            this.AnexoDos_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnexoDos_btn.Location = new System.Drawing.Point(12, 748);
            this.AnexoDos_btn.Name = "AnexoDos_btn";
            this.AnexoDos_btn.Size = new System.Drawing.Size(385, 60);
            this.AnexoDos_btn.TabIndex = 21;
            this.AnexoDos_btn.Text = " Anexo 2";
            this.AnexoDos_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AnexoDos_btn.UseVisualStyleBackColor = true;
            this.AnexoDos_btn.Click += new System.EventHandler(this.AnexoDos_btn_Click);
            // 
            // anexo11
            // 
            this.anexo11.Location = new System.Drawing.Point(479, 154);
            this.anexo11.Margin = new System.Windows.Forms.Padding(5);
            this.anexo11.Name = "anexo11";
            this.anexo11.Size = new System.Drawing.Size(319, 508);
            this.anexo11.TabIndex = 0;
            // 
            // Individual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(821, 817);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.anexo11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Individual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculos Individuales";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Anexo1 anexo11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button P_G;
        private System.Windows.Forms.Button A_G;
        private System.Windows.Forms.Button F_P;
        private System.Windows.Forms.Button P_F;
        private System.Windows.Forms.Button F_A;
        private System.Windows.Forms.Button A_F;
        private System.Windows.Forms.Button A_P;
        private System.Windows.Forms.Button P_A;
        private System.Windows.Forms.Button F_G;
        private System.Windows.Forms.Panel sideP;
        private System.Windows.Forms.Button IEF_btn;
        private System.Windows.Forms.Button AnexoDos_btn;
    }
}