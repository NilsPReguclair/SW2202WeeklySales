namespace SW2202WeeklySales
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbxMonday = new System.Windows.Forms.TextBox();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.tbxTuesday = new System.Windows.Forms.TextBox();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.tbxWednesday = new System.Windows.Forms.TextBox();
            this.lblThursday = new System.Windows.Forms.Label();
            this.tbxThursday = new System.Windows.Forms.TextBox();
            this.lblFriday = new System.Windows.Forms.Label();
            this.tbxFriday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.FlatAppearance.BorderSize = 2;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(12, 112);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(421, 48);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbxMonday
            // 
            this.tbxMonday.Location = new System.Drawing.Point(12, 70);
            this.tbxMonday.Name = "tbxMonday";
            this.tbxMonday.Size = new System.Drawing.Size(61, 22);
            this.tbxMonday.TabIndex = 1;
            this.tbxMonday.Text = "0";
            this.tbxMonday.TextChanged += new System.EventHandler(this.tbxMonday_TextChanged);
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(15, 50);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(58, 17);
            this.lblMonday.TabIndex = 2;
            this.lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(100, 50);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(63, 17);
            this.lblTuesday.TabIndex = 4;
            this.lblTuesday.Text = "Tuesday";
            // 
            // tbxTuesday
            // 
            this.tbxTuesday.Location = new System.Drawing.Point(102, 70);
            this.tbxTuesday.Name = "tbxTuesday";
            this.tbxTuesday.Size = new System.Drawing.Size(61, 22);
            this.tbxTuesday.TabIndex = 3;
            this.tbxTuesday.Text = "0";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(177, 50);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(87, 17);
            this.lblWednesday.TabIndex = 6;
            this.lblWednesday.Text = " Wednesday";
            // 
            // tbxWednesday
            // 
            this.tbxWednesday.Location = new System.Drawing.Point(192, 70);
            this.tbxWednesday.Name = "tbxWednesday";
            this.tbxWednesday.Size = new System.Drawing.Size(61, 22);
            this.tbxWednesday.TabIndex = 5;
            this.tbxWednesday.Text = "0";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(278, 50);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(68, 17);
            this.lblThursday.TabIndex = 8;
            this.lblThursday.Text = "Thursday";
            // 
            // tbxThursday
            // 
            this.tbxThursday.Location = new System.Drawing.Point(282, 70);
            this.tbxThursday.Name = "tbxThursday";
            this.tbxThursday.Size = new System.Drawing.Size(61, 22);
            this.tbxThursday.TabIndex = 7;
            this.tbxThursday.Text = "0";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(373, 50);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(55, 17);
            this.lblFriday.TabIndex = 10;
            this.lblFriday.Text = "  Friday";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFriday.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxFriday
            // 
            this.tbxFriday.Location = new System.Drawing.Point(372, 70);
            this.tbxFriday.Name = "tbxFriday";
            this.tbxFriday.Size = new System.Drawing.Size(61, 22);
            this.tbxFriday.TabIndex = 9;
            this.tbxFriday.Text = "0";
            this.tbxFriday.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 503);
            this.Controls.Add(this.lblFriday);
            this.Controls.Add(this.tbxFriday);
            this.Controls.Add(this.lblThursday);
            this.Controls.Add(this.tbxThursday);
            this.Controls.Add(this.lblWednesday);
            this.Controls.Add(this.tbxWednesday);
            this.Controls.Add(this.lblTuesday);
            this.Controls.Add(this.tbxTuesday);
            this.Controls.Add(this.lblMonday);
            this.Controls.Add(this.tbxMonday);
            this.Controls.Add(this.btnGenerate);
            this.Name = "Form1";
            this.Text = "WeeklySales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbxMonday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.TextBox tbxTuesday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.TextBox tbxWednesday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.TextBox tbxThursday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.TextBox tbxFriday;
    }
}

