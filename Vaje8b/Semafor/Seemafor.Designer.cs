namespace Semafor
{
    partial class Seemafor
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
            this.gmbRdeca = new System.Windows.Forms.Button();
            this.gmbZelena = new System.Windows.Forms.Button();
            this.gmbRumena = new System.Windows.Forms.Button();
            this.lblBarva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gmbRdeca
            // 
            this.gmbRdeca.Location = new System.Drawing.Point(115, 117);
            this.gmbRdeca.Name = "gmbRdeca";
            this.gmbRdeca.Size = new System.Drawing.Size(124, 59);
            this.gmbRdeca.TabIndex = 0;
            this.gmbRdeca.Text = "Rdeca";
            this.gmbRdeca.UseVisualStyleBackColor = true;
            this.gmbRdeca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vsi_gumbi_MOUSEDOWN);
            this.gmbRdeca.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vsigumbi_MouseUp);
            // 
            // gmbZelena
            // 
            this.gmbZelena.Location = new System.Drawing.Point(115, 187);
            this.gmbZelena.Name = "gmbZelena";
            this.gmbZelena.Size = new System.Drawing.Size(124, 59);
            this.gmbZelena.TabIndex = 1;
            this.gmbZelena.Text = "Zelena";
            this.gmbZelena.UseVisualStyleBackColor = true;
            this.gmbZelena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vsi_gumbi_MOUSEDOWN);
            this.gmbZelena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vsigumbi_MouseUp);
            // 
            // gmbRumena
            // 
            this.gmbRumena.Location = new System.Drawing.Point(115, 253);
            this.gmbRumena.Name = "gmbRumena";
            this.gmbRumena.Size = new System.Drawing.Size(124, 59);
            this.gmbRumena.TabIndex = 2;
            this.gmbRumena.Text = "Rumena";
            this.gmbRumena.UseVisualStyleBackColor = true;
            this.gmbRumena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Vsi_gumbi_MOUSEDOWN);
            this.gmbRumena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Vsigumbi_MouseUp);
            // 
            // lblBarva
            // 
            this.lblBarva.Location = new System.Drawing.Point(273, 121);
            this.lblBarva.Name = "lblBarva";
            this.lblBarva.Size = new System.Drawing.Size(311, 191);
            this.lblBarva.TabIndex = 3;
            // 
            // Seemafor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBarva);
            this.Controls.Add(this.gmbRumena);
            this.Controls.Add(this.gmbZelena);
            this.Controls.Add(this.gmbRdeca);
            this.Name = "Seemafor";
            this.Text = "Semafor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gmbRdeca;
        private System.Windows.Forms.Button gmbZelena;
        private System.Windows.Forms.Button gmbRumena;
        private System.Windows.Forms.Label lblBarva;
    }
}

