
namespace First_GUI
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
            this.txtHelloWorld = new System.Windows.Forms.TextBox();
            this.btnPlsClickMe_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHelloWorld
            // 
            this.txtHelloWorld.Location = new System.Drawing.Point(26, 98);
            this.txtHelloWorld.Name = "txtHelloWorld";
            this.txtHelloWorld.Size = new System.Drawing.Size(250, 27);
            this.txtHelloWorld.TabIndex = 0;
            // 
            // btnPlsClickMe_Click
            // 
            this.btnPlsClickMe_Click.Location = new System.Drawing.Point(353, 79);
            this.btnPlsClickMe_Click.Name = "btnPlsClickMe_Click";
            this.btnPlsClickMe_Click.Size = new System.Drawing.Size(139, 99);
            this.btnPlsClickMe_Click.TabIndex = 1;
            this.btnPlsClickMe_Click.Text = "Drück mich!";
            this.btnPlsClickMe_Click.UseVisualStyleBackColor = true;
            this.btnPlsClickMe_Click.Click += new System.EventHandler(this.button1_Click);
            this.btnPlsClickMe_Click.MouseEnter += new System.EventHandler(this.btnPlsClickMe_Click_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 410);
            this.Controls.Add(this.btnPlsClickMe_Click);
            this.Controls.Add(this.txtHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPlsClickMe_Click;
        private System.Windows.Forms.TextBox txtHelloWorld;
    }
}

