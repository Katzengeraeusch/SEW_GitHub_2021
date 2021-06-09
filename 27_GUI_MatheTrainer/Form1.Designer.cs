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
            this.lbStatistik = new System.Windows.Forms.Label();
            this.lbNrOfCalculations = new System.Windows.Forms.Label();
            this.lbRange = new System.Windows.Forms.Label();
            this.txtNrOfCalculations = new System.Windows.Forms.TextBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 238);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Überprüfen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCalcuate
            // 
            this.lbCalcuate.AutoSize = true;
            this.lbCalcuate.Location = new System.Drawing.Point(49, 115);
            this.lbCalcuate.Name = "lbCalcuate";
            this.lbCalcuate.Size = new System.Drawing.Size(138, 20);
            this.lbCalcuate.TabIndex = 2;
            this.lbCalcuate.Text = "Berechnen Sie: x x x";
            this.lbCalcuate.Visible = false;
            this.lbCalcuate.Click += new System.EventHandler(this.lbCalcuate_Click);
            // 
            // txtErgebnis
            // 
            this.txtErgebnis.Location = new System.Drawing.Point(49, 148);
            this.txtErgebnis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtErgebnis.Name = "txtErgebnis";
            this.txtErgebnis.Size = new System.Drawing.Size(114, 27);
            this.txtErgebnis.TabIndex = 3;
            this.txtErgebnis.Visible = false;
            this.txtErgebnis.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbWrongRight
            // 
            this.lbWrongRight.AutoSize = true;
            this.lbWrongRight.Location = new System.Drawing.Point(71, 384);
            this.lbWrongRight.Name = "lbWrongRight";
            this.lbWrongRight.Size = new System.Drawing.Size(0, 20);
            this.lbWrongRight.TabIndex = 4;
            // 
            // startTraininig
            // 
            this.startTraininig.Location = new System.Drawing.Point(49, 73);
            this.startTraininig.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startTraininig.Name = "startTraininig";
            this.startTraininig.Size = new System.Drawing.Size(114, 31);
            this.startTraininig.TabIndex = 5;
            this.startTraininig.Text = "Training starten";
            this.startTraininig.UseVisualStyleBackColor = true;
            this.startTraininig.Click += new System.EventHandler(this.startTraininig_Click);
            // 
            // lbStatistik
            // 
            this.lbStatistik.AutoSize = true;
            this.lbStatistik.Location = new System.Drawing.Point(49, 311);
            this.lbStatistik.Name = "lbStatistik";
            this.lbStatistik.Size = new System.Drawing.Size(50, 20);
            this.lbStatistik.TabIndex = 6;
            this.lbStatistik.Text = "label2";
            this.lbStatistik.Click += new System.EventHandler(this.lbStatistik_Click);
            // 
            // lbNrOfCalculations
            // 
            this.lbNrOfCalculations.AutoSize = true;
            this.lbNrOfCalculations.Location = new System.Drawing.Point(229, 63);
            this.lbNrOfCalculations.Name = "lbNrOfCalculations";
            this.lbNrOfCalculations.Size = new System.Drawing.Size(159, 20);
            this.lbNrOfCalculations.TabIndex = 7;
            this.lbNrOfCalculations.Text = "Anzahl an Rechnungen";
            // 
            // lbRange
            // 
            this.lbRange.AutoSize = true;
            this.lbRange.Location = new System.Drawing.Point(494, 63);
            this.lbRange.Name = "lbRange";
            this.lbRange.Size = new System.Drawing.Size(184, 20);
            this.lbRange.TabIndex = 8;
            this.lbRange.Text = "Höchstmögliches Ergebnis";
            // 
            // txtNrOfCalculations
            // 
            this.txtNrOfCalculations.Location = new System.Drawing.Point(229, 112);
            this.txtNrOfCalculations.Name = "txtNrOfCalculations";
            this.txtNrOfCalculations.Size = new System.Drawing.Size(125, 27);
            this.txtNrOfCalculations.TabIndex = 9;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(494, 112);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(125, 27);
            this.txtRange.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.txtNrOfCalculations);
            this.Controls.Add(this.lbRange);
            this.Controls.Add(this.lbNrOfCalculations);
            this.Controls.Add(this.lbStatistik);
            this.Controls.Add(this.startTraininig);
            this.Controls.Add(this.lbWrongRight);
            this.Controls.Add(this.txtErgebnis);
            this.Controls.Add(this.lbCalcuate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label lbStatistik;
        private System.Windows.Forms.Label lbNrOfCalculations;
        private System.Windows.Forms.Label lbRange;
        private System.Windows.Forms.TextBox txtNrOfCalculations;
        private System.Windows.Forms.TextBox txtRange;
    }
}

