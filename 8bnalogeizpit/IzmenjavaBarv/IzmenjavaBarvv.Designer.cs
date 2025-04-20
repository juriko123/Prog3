namespace IzmenjavaBarv
{
    partial class IzmenjavaBarvv
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
            this.lblBarva = new System.Windows.Forms.Label();
            this.gmbzacni = new System.Windows.Forms.Button();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblViola = new System.Windows.Forms.Label();
            this.lblZelena = new System.Windows.Forms.Label();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblBarva
            // 
            this.lblBarva.Location = new System.Drawing.Point(251, 93);
            this.lblBarva.Name = "lblBarva";
            this.lblBarva.Size = new System.Drawing.Size(278, 155);
            this.lblBarva.TabIndex = 0;
            // 
            // gmbzacni
            // 
            this.gmbzacni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbzacni.Location = new System.Drawing.Point(333, 356);
            this.gmbzacni.Name = "gmbzacni";
            this.gmbzacni.Size = new System.Drawing.Size(132, 47);
            this.gmbzacni.TabIndex = 1;
            this.gmbzacni.Text = "Zacni";
            this.gmbzacni.UseVisualStyleBackColor = true;
            this.gmbzacni.Click += new System.EventHandler(this.gmbzacni_Click);
            // 
            // lblOrange
            // 
            this.lblOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrange.Location = new System.Drawing.Point(211, 273);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(147, 23);
            this.lblOrange.TabIndex = 2;
            this.lblOrange.Text = "Oranžna: ";
            // 
            // lblViola
            // 
            this.lblViola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViola.Location = new System.Drawing.Point(364, 273);
            this.lblViola.Name = "lblViola";
            this.lblViola.Size = new System.Drawing.Size(147, 23);
            this.lblViola.TabIndex = 3;
            this.lblViola.Text = "Vijolična: ";
            // 
            // lblZelena
            // 
            this.lblZelena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZelena.Location = new System.Drawing.Point(527, 273);
            this.lblZelena.Name = "lblZelena";
            this.lblZelena.Size = new System.Drawing.Size(123, 28);
            this.lblZelena.TabIndex = 4;
            this.lblZelena.Text = "Zelena: ";
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 500;
            this.TIMER.Tick += new System.EventHandler(this.GameLoop);
            // 
            // IzmenjavaBarvv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZelena);
            this.Controls.Add(this.lblViola);
            this.Controls.Add(this.lblOrange);
            this.Controls.Add(this.gmbzacni);
            this.Controls.Add(this.lblBarva);
            this.Name = "IzmenjavaBarvv";
            this.Text = "Izmenjava Barv";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBarva;
        private System.Windows.Forms.Button gmbzacni;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblViola;
        private System.Windows.Forms.Label lblZelena;
        private System.Windows.Forms.Timer TIMER;
    }
}

