
namespace HU_Contact_Tracing
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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelList = new System.Windows.Forms.Button();
            this.txtPersonList = new System.Windows.Forms.TextBox();
            this.lbCurrentPersons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(41, 51);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(71, 20);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "Vorname:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(32, 101);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(80, 20);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Nachname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(164, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(170, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(164, 94);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(164, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelList
            // 
            this.btnDelList.Location = new System.Drawing.Point(164, 223);
            this.btnDelList.Name = "btnDelList";
            this.btnDelList.Size = new System.Drawing.Size(120, 35);
            this.btnDelList.TabIndex = 5;
            this.btnDelList.Text = "Liste Löschen";
            this.btnDelList.UseVisualStyleBackColor = true;
            this.btnDelList.Click += new System.EventHandler(this.btnDelList_Click);
            // 
            // txtPersonList
            // 
            this.txtPersonList.AcceptsReturn = true;
            this.txtPersonList.Location = new System.Drawing.Point(440, 44);
            this.txtPersonList.Multiline = true;
            this.txtPersonList.Name = "txtPersonList";
            this.txtPersonList.ReadOnly = true;
            this.txtPersonList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPersonList.Size = new System.Drawing.Size(208, 279);
            this.txtPersonList.TabIndex = 6;
            // 
            // lbCurrentPersons
            // 
            this.lbCurrentPersons.AutoSize = true;
            this.lbCurrentPersons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentPersons.Location = new System.Drawing.Point(267, 368);
            this.lbCurrentPersons.Name = "lbCurrentPersons";
            this.lbCurrentPersons.Size = new System.Drawing.Size(181, 20);
            this.lbCurrentPersons.TabIndex = 7;
            this.lbCurrentPersons.Text = "0 Personen sind anwesend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCurrentPersons);
            this.Controls.Add(this.txtPersonList);
            this.Controls.Add(this.btnDelList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Contact Tracing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelList;
        private System.Windows.Forms.TextBox txtPersonList;
        private System.Windows.Forms.Label lbCurrentPersons;
    }
}

