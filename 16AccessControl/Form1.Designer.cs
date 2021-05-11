
namespace _16AccessControl
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
            this.maxPersonAnzahl = new System.Windows.Forms.Label();
            this.aktPersonenAnzahl = new System.Windows.Forms.Label();
            this.txtMaxPersons = new System.Windows.Forms.TextBox();
            this.txtCurrentPersons = new System.Windows.Forms.TextBox();
            this.btnIncrement1 = new System.Windows.Forms.Button();
            this.btnDecrement1 = new System.Windows.Forms.Button();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxPersonAnzahl
            // 
            this.maxPersonAnzahl.AutoSize = true;
            this.maxPersonAnzahl.Location = new System.Drawing.Point(110, 72);
            this.maxPersonAnzahl.Name = "maxPersonAnzahl";
            this.maxPersonAnzahl.Size = new System.Drawing.Size(209, 20);
            this.maxPersonAnzahl.TabIndex = 0;
            this.maxPersonAnzahl.Text = "Maximale Anzahl an Personen:";
            this.maxPersonAnzahl.Click += new System.EventHandler(this.label1_Click);
            // 
            // aktPersonenAnzahl
            // 
            this.aktPersonenAnzahl.AutoSize = true;
            this.aktPersonenAnzahl.Location = new System.Drawing.Point(110, 123);
            this.aktPersonenAnzahl.Name = "aktPersonenAnzahl";
            this.aktPersonenAnzahl.Size = new System.Drawing.Size(198, 20);
            this.aktPersonenAnzahl.TabIndex = 1;
            this.aktPersonenAnzahl.Text = "Aktuelle Anzahl an Personen:";
            // 
            // txtMaxPersons
            // 
            this.txtMaxPersons.Location = new System.Drawing.Point(416, 69);
            this.txtMaxPersons.Name = "txtMaxPersons";
            this.txtMaxPersons.Size = new System.Drawing.Size(151, 27);
            this.txtMaxPersons.TabIndex = 2;
            this.txtMaxPersons.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCurrentPersons
            // 
            this.txtCurrentPersons.Location = new System.Drawing.Point(416, 123);
            this.txtCurrentPersons.Name = "txtCurrentPersons";
            this.txtCurrentPersons.ReadOnly = true;
            this.txtCurrentPersons.Size = new System.Drawing.Size(151, 27);
            this.txtCurrentPersons.TabIndex = 3;
            // 
            // btnIncrement1
            // 
            this.btnIncrement1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrement1.Location = new System.Drawing.Point(149, 208);
            this.btnIncrement1.Name = "btnIncrement1";
            this.btnIncrement1.Size = new System.Drawing.Size(85, 85);
            this.btnIncrement1.TabIndex = 4;
            this.btnIncrement1.Text = "+1";
            this.btnIncrement1.UseVisualStyleBackColor = true;
            // 
            // btnDecrement1
            // 
            this.btnDecrement1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrement1.Location = new System.Drawing.Point(497, 208);
            this.btnDecrement1.Name = "btnDecrement1";
            this.btnDecrement1.Size = new System.Drawing.Size(85, 85);
            this.btnDecrement1.TabIndex = 5;
            this.btnDecrement1.Text = "-1";
            this.btnDecrement1.UseVisualStyleBackColor = true;
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(41, 357);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(85, 27);
            this.txtIncrement.TabIndex = 6;
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(149, 357);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(85, 29);
            this.btnIncrement.TabIndex = 7;
            this.btnIncrement.Text = "erhöhen";
            this.btnIncrement.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 27);
            this.textBox1.TabIndex = 8;
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(488, 359);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(94, 29);
            this.btnDecrement.TabIndex = 9;
            this.btnDecrement.Text = "verringern";
            this.btnDecrement.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.btnDecrement1);
            this.Controls.Add(this.btnIncrement1);
            this.Controls.Add(this.txtCurrentPersons);
            this.Controls.Add(this.txtMaxPersons);
            this.Controls.Add(this.aktPersonenAnzahl);
            this.Controls.Add(this.maxPersonAnzahl);
            this.Name = "Form1";
            this.Text = "Zutrittskontrolle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label maxPersonAnzahl;
        private System.Windows.Forms.Label aktPersonenAnzahl;
        private System.Windows.Forms.TextBox txtMaxPersons;
        private System.Windows.Forms.TextBox txtCurrentPersons;
        private System.Windows.Forms.Button btnIncrement1;
        private System.Windows.Forms.Button btnDecrement1;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDecrement;
    }
}

