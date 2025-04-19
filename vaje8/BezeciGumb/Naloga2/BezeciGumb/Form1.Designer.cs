namespace BezeciGumb
{
    partial class Form1
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
            this.gmbKlikniMe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gmbStart = new System.Windows.Forms.Button();
            this.lblCas = new System.Windows.Forms.Label();
            this.Igra = new System.Windows.Forms.Timer(this.components);
            this.gmbSeenkrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gmbKlikniMe
            // 
            this.gmbKlikniMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbKlikniMe.Location = new System.Drawing.Point(452, 208);
            this.gmbKlikniMe.Name = "gmbKlikniMe";
            this.gmbKlikniMe.Size = new System.Drawing.Size(100, 100);
            this.gmbKlikniMe.TabIndex = 1;
            this.gmbKlikniMe.Text = "KLIKNI ME !";
            this.gmbKlikniMe.UseVisualStyleBackColor = true;
            this.gmbKlikniMe.Click += new System.EventHandler(this.gmbKlikniMe_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.Premiki);
            // 
            // gmbStart
            // 
            this.gmbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbStart.Location = new System.Drawing.Point(98, 341);
            this.gmbStart.Name = "gmbStart";
            this.gmbStart.Size = new System.Drawing.Size(500, 90);
            this.gmbStart.TabIndex = 2;
            this.gmbStart.Text = "Start";
            this.gmbStart.UseVisualStyleBackColor = true;
            this.gmbStart.Click += new System.EventHandler(this.Start_game_Click);
            // 
            // lblCas
            // 
            this.lblCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCas.Location = new System.Drawing.Point(13, 26);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(127, 47);
            this.lblCas.TabIndex = 3;
            this.lblCas.Text = "Čas: ";
            this.lblCas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Igra
            // 
            this.Igra.Enabled = true;
            this.Igra.Interval = 1000;
            this.Igra.Tick += new System.EventHandler(this.ZačetekIgre);
            // 
            // gmbSeenkrat
            // 
            this.gmbSeenkrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmbSeenkrat.Location = new System.Drawing.Point(98, 442);
            this.gmbSeenkrat.Name = "gmbSeenkrat";
            this.gmbSeenkrat.Size = new System.Drawing.Size(500, 90);
            this.gmbSeenkrat.TabIndex = 4;
            this.gmbSeenkrat.Text = "Še enkrat";
            this.gmbSeenkrat.UseVisualStyleBackColor = true;
            this.gmbSeenkrat.Visible = false;
            this.gmbSeenkrat.Click += new System.EventHandler(this.gmbSeenkrat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 550);
            this.Controls.Add(this.gmbSeenkrat);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.gmbStart);
            this.Controls.Add(this.gmbKlikniMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gmbKlikniMe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button gmbStart;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.Timer Igra;
        private System.Windows.Forms.Button gmbSeenkrat;
    }
}

