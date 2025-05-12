namespace LeviInDesni
{
    partial class LeviNDesni
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
            this.gmbLevi = new System.Windows.Forms.Button();
            this.gmbDesni = new System.Windows.Forms.Button();
            this.lblNapis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gmbLevi
            // 
            this.gmbLevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbLevi.Location = new System.Drawing.Point(40, 53);
            this.gmbLevi.Name = "gmbLevi";
            this.gmbLevi.Size = new System.Drawing.Size(104, 38);
            this.gmbLevi.TabIndex = 0;
            this.gmbLevi.Text = "Levi";
            this.gmbLevi.UseVisualStyleBackColor = true;
            this.gmbLevi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Oba_MouseDown);
            this.gmbLevi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Oba_MouseUp);
            // 
            // gmbDesni
            // 
            this.gmbDesni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbDesni.Location = new System.Drawing.Point(377, 53);
            this.gmbDesni.Name = "gmbDesni";
            this.gmbDesni.Size = new System.Drawing.Size(104, 38);
            this.gmbDesni.TabIndex = 1;
            this.gmbDesni.Text = "Desni";
            this.gmbDesni.UseVisualStyleBackColor = true;
            this.gmbDesni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Oba_MouseDown);
            this.gmbDesni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Oba_MouseUp);
            // 
            // lblNapis
            // 
            this.lblNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapis.Location = new System.Drawing.Point(193, 53);
            this.lblNapis.Name = "lblNapis";
            this.lblNapis.Size = new System.Drawing.Size(150, 38);
            this.lblNapis.TabIndex = 2;
            this.lblNapis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LeviNDesni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 134);
            this.Controls.Add(this.lblNapis);
            this.Controls.Add(this.gmbDesni);
            this.Controls.Add(this.gmbLevi);
            this.Name = "LeviNDesni";
            this.Text = "Levi in desni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gmbLevi;
        private System.Windows.Forms.Button gmbDesni;
        private System.Windows.Forms.Label lblNapis;
    }
}

