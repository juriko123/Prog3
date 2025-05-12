namespace Stevec_klikov
{
    partial class GlOkno
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
            this.lblNapis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNapis
            // 
            this.lblNapis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapis.Location = new System.Drawing.Point(49, 74);
            this.lblNapis.Name = "lblNapis";
            this.lblNapis.Size = new System.Drawing.Size(364, 57);
            this.lblNapis.TabIndex = 0;
            this.lblNapis.Text = "Stevec klikov: ";
            this.lblNapis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNapis.Click += new System.EventHandler(this.lblNapis_Click);
            // 
            // GlOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 251);
            this.Controls.Add(this.lblNapis);
            this.Name = "GlOkno";
            this.Text = "Stevec Klikov";
            this.Click += new System.EventHandler(this.GlOkno_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNapis;
    }
}

