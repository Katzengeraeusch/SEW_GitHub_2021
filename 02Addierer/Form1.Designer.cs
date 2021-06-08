namespace _02Addierer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSummand1 = new System.Windows.Forms.TextBox();
            this.txtSummand2 = new System.Windows.Forms.TextBox();
            this.txtSumme = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbPlus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSummand1
            // 
            this.txtSummand1.Location = new System.Drawing.Point(41, 51);
            this.txtSummand1.Name = "txtSummand1";
            this.txtSummand1.Size = new System.Drawing.Size(100, 23);
            this.txtSummand1.TabIndex = 0;
            this.txtSummand1.TextChanged += new System.EventHandler(this.txtSummand1_TextChanged);
            // 
            // txtSummand2
            // 
            this.txtSummand2.Location = new System.Drawing.Point(244, 51);
            this.txtSummand2.Name = "txtSummand2";
            this.txtSummand2.Size = new System.Drawing.Size(100, 23);
            this.txtSummand2.TabIndex = 1;
            this.txtSummand2.TextChanged += new System.EventHandler(this.txtSummand2_TextChanged);
            // 
            // txtSumme
            // 
            this.txtSumme.Location = new System.Drawing.Point(479, 51);
            this.txtSumme.Name = "txtSumme";
            this.txtSumme.Size = new System.Drawing.Size(100, 23);
            this.txtSumme.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(377, 50);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "=";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbPlus
            // 
            this.lbPlus.AutoSize = true;
            this.lbPlus.Location = new System.Drawing.Point(189, 54);
            this.lbPlus.Name = "lbPlus";
            this.lbPlus.Size = new System.Drawing.Size(15, 15);
            this.lbPlus.TabIndex = 4;
            this.lbPlus.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPlus);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSumme);
            this.Controls.Add(this.txtSummand2);
            this.Controls.Add(this.txtSummand1);
            this.Name = "Form1";
            this.Text = "Addierer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSummand1;
        private System.Windows.Forms.TextBox txtSummand2;
        private System.Windows.Forms.TextBox txtSumme;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbPlus;
    }
}

