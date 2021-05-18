
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
            this.txtDecrement = new System.Windows.Forms.TextBox();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.lbNoMorePersonsAllowed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxPersonAnzahl
            // 
            this.maxPersonAnzahl.AutoSize = true;
            this.maxPersonAnzahl.Location = new System.Drawing.Point(96, 54);
            this.maxPersonAnzahl.Name = "maxPersonAnzahl";
            this.maxPersonAnzahl.Size = new System.Drawing.Size(169, 15);
            this.maxPersonAnzahl.TabIndex = 0;
            this.maxPersonAnzahl.Text = "Maximale Anzahl an Personen:";
            this.maxPersonAnzahl.Click += new System.EventHandler(this.label1_Click);
            // 
            // aktPersonenAnzahl
            // 
            this.aktPersonenAnzahl.AutoSize = true;
            this.aktPersonenAnzahl.Location = new System.Drawing.Point(96, 92);
            this.aktPersonenAnzahl.Name = "aktPersonenAnzahl";
            this.aktPersonenAnzahl.Size = new System.Drawing.Size(160, 15);
            this.aktPersonenAnzahl.TabIndex = 1;
            this.aktPersonenAnzahl.Text = "Aktuelle Anzahl an Personen:";
            // 
            // txtMaxPersons
            // 
            this.txtMaxPersons.Location = new System.Drawing.Point(364, 52);
            this.txtMaxPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxPersons.Name = "txtMaxPersons";
            this.txtMaxPersons.Size = new System.Drawing.Size(133, 23);
            this.txtMaxPersons.TabIndex = 2;
            this.txtMaxPersons.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCurrentPersons
            // 
            this.txtCurrentPersons.Location = new System.Drawing.Point(364, 92);
            this.txtCurrentPersons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentPersons.Name = "txtCurrentPersons";
            this.txtCurrentPersons.ReadOnly = true;
            this.txtCurrentPersons.Size = new System.Drawing.Size(133, 23);
            this.txtCurrentPersons.TabIndex = 3;
            // 
            // btnIncrement1
            // 
            this.btnIncrement1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrement1.Location = new System.Drawing.Point(130, 156);
            this.btnIncrement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncrement1.Name = "btnIncrement1";
            this.btnIncrement1.Size = new System.Drawing.Size(74, 64);
            this.btnIncrement1.TabIndex = 4;
            this.btnIncrement1.Text = "+1";
            this.btnIncrement1.UseVisualStyleBackColor = true;
            this.btnIncrement1.Click += new System.EventHandler(this.btnIncrement1_Click);
            // 
            // btnDecrement1
            // 
            this.btnDecrement1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecrement1.Location = new System.Drawing.Point(435, 156);
            this.btnDecrement1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrement1.Name = "btnDecrement1";
            this.btnDecrement1.Size = new System.Drawing.Size(74, 64);
            this.btnDecrement1.TabIndex = 5;
            this.btnDecrement1.Text = "-1";
            this.btnDecrement1.UseVisualStyleBackColor = true;
            this.btnDecrement1.Click += new System.EventHandler(this.btnDecrement1_Click);
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(36, 268);
            this.txtIncrement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(75, 23);
            this.txtIncrement.TabIndex = 6;
            this.txtIncrement.TextChanged += new System.EventHandler(this.txtIncrement_TextChanged);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(130, 268);
            this.btnIncrement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(74, 22);
            this.btnIncrement.TabIndex = 7;
            this.btnIncrement.Text = "erhöhen";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // txtDecrement
            // 
            this.txtDecrement.Location = new System.Drawing.Point(328, 269);
            this.txtDecrement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDecrement.Name = "txtDecrement";
            this.txtDecrement.Size = new System.Drawing.Size(75, 23);
            this.txtDecrement.TabIndex = 8;
            this.txtDecrement.TextChanged += new System.EventHandler(this.txtDecrement_TextChanged);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(427, 269);
            this.btnDecrement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(82, 22);
            this.btnDecrement.TabIndex = 9;
            this.btnDecrement.Text = "verringern";
            this.btnDecrement.UseVisualStyleBackColor = true;
            // 
            // lbNoMorePersonsAllowed
            // 
            this.lbNoMorePersonsAllowed.AutoSize = true;
            this.lbNoMorePersonsAllowed.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNoMorePersonsAllowed.ForeColor = System.Drawing.Color.Red;
            this.lbNoMorePersonsAllowed.Location = new System.Drawing.Point(57, 326);
            this.lbNoMorePersonsAllowed.Name = "lbNoMorePersonsAllowed";
            this.lbNoMorePersonsAllowed.Size = new System.Drawing.Size(452, 37);
            this.lbNoMorePersonsAllowed.TabIndex = 10;
            this.lbNoMorePersonsAllowed.Text = "Maximal Anzahl an Personen erreicht";
            this.lbNoMorePersonsAllowed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 436);
            this.Controls.Add(this.lbNoMorePersonsAllowed);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.txtDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.btnDecrement1);
            this.Controls.Add(this.btnIncrement1);
            this.Controls.Add(this.txtCurrentPersons);
            this.Controls.Add(this.txtMaxPersons);
            this.Controls.Add(this.aktPersonenAnzahl);
            this.Controls.Add(this.maxPersonAnzahl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.TextBox txtDecrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Label lbNoMorePersonsAllowed;
    }
}

