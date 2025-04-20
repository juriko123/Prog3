namespace Prva_naloga
{
    partial class tbGeslo
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
            this.lblGeslo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gmbPrijavise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGeslo
            // 
            this.lblGeslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeslo.Location = new System.Drawing.Point(56, 53);
            this.lblGeslo.Name = "lblGeslo";
            this.lblGeslo.Size = new System.Drawing.Size(100, 40);
            this.lblGeslo.TabIndex = 0;
            this.lblGeslo.Text = "Geslo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 1;
            // 
            // gmbPrijavise
            // 
            this.gmbPrijavise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbPrijavise.Location = new System.Drawing.Point(62, 127);
            this.gmbPrijavise.Name = "gmbPrijavise";
            this.gmbPrijavise.Size = new System.Drawing.Size(233, 31);
            this.gmbPrijavise.TabIndex = 2;
            this.gmbPrijavise.Text = "Prijavi se ";
            this.gmbPrijavise.UseVisualStyleBackColor = true;
            this.gmbPrijavise.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 306);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGeslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmbPrijavise);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblGeslo);
            this.Name = "tbGeslo";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeslo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button gmbPrijavise;
        private System.Windows.Forms.Label label1;
    }
}

