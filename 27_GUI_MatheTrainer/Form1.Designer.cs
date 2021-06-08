namespace _27_GUI_MatheTrainer
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCalcuate = new System.Windows.Forms.Label();
            this.txtErgebnis = new System.Windows.Forms.TextBox();
            this.lbWrongRight = new System.Windows.Forms.Label();
            this.startTraininig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Überprüfen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCalcuate
            // 
            this.lbCalcuate.AutoSize = true;
            this.lbCalcuate.Location = new System.Drawing.Point(43, 110);
            this.lbCalcuate.Name = "lbCalcuate";
            this.lbCalcuate.Size = new System.Drawing.Size(111, 15);
            this.lbCalcuate.TabIndex = 2;
            this.lbCalcuate.Text = "Berechnen Sie: x x x";
            this.lbCalcuate.Visible = false;
            this.lbCalcuate.Click += new System.EventHandler(this.lbCalcuate_Click);
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Location = new System.Drawing.Point(43, 163);
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.Size = new System.Drawing.Size(100, 23);
            this.txtErgebnis.TabIndex = 3;
            this.txtErgebnis.Visible = false;
            this.txtErgebnis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbWrongRight
            // 
            this.lbWrongRight.AutoSize = true;
            this.lbWrongRight.Location = new System.Drawing.Point(62, 288);
            this.lbWrongRight.Name = "lbWrongRight";
            this.lbWrongRight.Size = new System.Drawing.Size(0, 15);
            this.lbWrongRight.TabIndex = 4;
            // 
            // startTraininig
            // 
            this.startTraininig.Location = new System.Drawing.Point(43, 55);
            this.startTraininig.Name = "startTraininig";
            this.startTraininig.Size = new System.Drawing.Size(100, 23);
            this.startTraininig.TabIndex = 5;
            this.startTraininig.Text = "Training starten";
            this.startTraininig.UseVisualStyleBackColor = true;
            this.startTraininig.Click += new System.EventHandler(this.startTraininig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startTraininig);
            this.Controls.Add(this.lbWrongRight);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.lbCalcuate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mathe Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCalcuate;
        private System.Windows.Forms.TextBox txtErgebnis;
        private System.Windows.Forms.Label lbWrongRight;
        private System.Windows.Forms.Button startTraininig;
    }
}

