namespace AuBoli
{
    partial class AUboli
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gmbKlik = new System.Windows.Forms.Button();
            this.gmbPomoc = new System.Windows.Forms.Button();
            this.odstevalnik = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gmbKlik
            // 
            this.gmbKlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbKlik.Location = new System.Drawing.Point(59, 244);
            this.gmbKlik.Name = "gmbKlik";
            this.gmbKlik.Size = new System.Drawing.Size(120, 100);
            this.gmbKlik.TabIndex = 1;
            this.gmbKlik.Text = "Klik";
            this.gmbKlik.UseVisualStyleBackColor = true;
            this.gmbKlik.Click += new System.EventHandler(this.gmbKlik_Click);
            // 
            // gmbPomoc
            // 
            this.gmbPomoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbPomoc.Location = new System.Drawing.Point(202, 244);
            this.gmbPomoc.Name = "gmbPomoc";
            this.gmbPomoc.Size = new System.Drawing.Size(115, 100);
            this.gmbPomoc.TabIndex = 2;
            this.gmbPomoc.Text = "KLIKNI POMOČ";
            this.gmbPomoc.UseVisualStyleBackColor = true;
            this.gmbPomoc.Click += new System.EventHandler(this.gmbPomoc_Click);
            // 
            // odstevalnik
            // 
            this.odstevalnik.Enabled = true;
            this.odstevalnik.Interval = 1000;
            this.odstevalnik.Tick += new System.EventHandler(this.Odštevaj);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Za klikniti imaš na voljo le še: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AUboli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gmbPomoc);
            this.Controls.Add(this.gmbKlik);
            this.Controls.Add(this.label1);
            this.Name = "AUboli";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gmbKlik;
        private System.Windows.Forms.Button gmbPomoc;
        private System.Windows.Forms.Timer odstevalnik;
        private System.Windows.Forms.Label label2;
    }
}

