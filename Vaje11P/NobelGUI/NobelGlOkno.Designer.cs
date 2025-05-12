namespace NobelGUI
{
    partial class NobelGlOkno
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
            this.label1 = new System.Windows.Forms.Label();
            this.boxPodrocja = new System.Windows.Forms.TextBox();
            this.BoxLeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxIzpis = new System.Windows.Forms.TextBox();
            this.GUMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // boxPodrocja
            // 
            this.boxPodrocja.Location = new System.Drawing.Point(40, 150);
            this.boxPodrocja.Multiline = true;
            this.boxPodrocja.Name = "boxPodrocja";
            this.boxPodrocja.Size = new System.Drawing.Size(174, 160);
            this.boxPodrocja.TabIndex = 11;
            // 
            // BoxLeta
            // 
            this.BoxLeta.Location = new System.Drawing.Point(135, 52);
            this.BoxLeta.Name = "BoxLeta";
            this.BoxLeta.Size = new System.Drawing.Size(100, 20);
            this.BoxLeta.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Izberi področja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vpiši leto: ";
            // 
            // BoxIzpis
            // 
            this.BoxIzpis.Location = new System.Drawing.Point(444, 52);
            this.BoxIzpis.Multiline = true;
            this.BoxIzpis.Name = "BoxIzpis";
            this.BoxIzpis.ReadOnly = true;
            this.BoxIzpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BoxIzpis.Size = new System.Drawing.Size(321, 346);
            this.BoxIzpis.TabIndex = 7;
            // 
            // GUMB
            // 
            this.GUMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GUMB.Location = new System.Drawing.Point(36, 329);
            this.GUMB.Name = "GUMB";
            this.GUMB.Size = new System.Drawing.Size(333, 69);
            this.GUMB.TabIndex = 6;
            this.GUMB.Text = "Poišči";
            this.GUMB.UseVisualStyleBackColor = true;
            this.GUMB.Click += new System.EventHandler(this.GUMB_Click);
            // 
            // NobelGlOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxPodrocja);
            this.Controls.Add(this.BoxLeta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxIzpis);
            this.Controls.Add(this.GUMB);
            this.Controls.Add(this.label1);
            this.Name = "NobelGlOkno";
            this.Text = "NobelGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxPodrocja;
        private System.Windows.Forms.TextBox BoxLeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxIzpis;
        private System.Windows.Forms.Button GUMB;
    }
}

