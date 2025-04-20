namespace VozecaPloscad
{
    partial class GlavnoOkno
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
            this.gmbGibanje = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gmbGibanje
            // 
            this.gmbGibanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbGibanje.Location = new System.Drawing.Point(74, 108);
            this.gmbGibanje.Name = "gmbGibanje";
            this.gmbGibanje.Size = new System.Drawing.Size(148, 41);
            this.gmbGibanje.TabIndex = 0;
            this.gmbGibanje.Text = "GIBANJE";
            this.gmbGibanje.UseVisualStyleBackColor = true;
            this.gmbGibanje.Click += new System.EventHandler(this.gmbGibanje_Click);
            // 
            // Update
            // 
            this.Update.Enabled = true;
            this.Update.Interval = 20;
            this.Update.Tick += new System.EventHandler(this.GameLoop);
            // 
            // GlavnoOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.gmbGibanje);
            this.DoubleBuffered = true;
            this.Name = "GlavnoOkno";
            this.Text = "Vozeca Ploscad";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GlavnoOkno_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gmbGibanje;
        private System.Windows.Forms.Timer Update;
    }
}

