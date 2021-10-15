
namespace listasymenus
{
    partial class fmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercaDe));
            this.pbAcercaDe = new System.Windows.Forms.PictureBox();
            this.lbNombreAD = new System.Windows.Forms.Label();
            this.lbProyectoAD = new System.Windows.Forms.Label();
            this.lbVersionAD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTextoAD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcercaDe)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAcercaDe
            // 
            this.pbAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("pbAcercaDe.Image")));
            this.pbAcercaDe.Location = new System.Drawing.Point(12, 12);
            this.pbAcercaDe.Name = "pbAcercaDe";
            this.pbAcercaDe.Size = new System.Drawing.Size(169, 217);
            this.pbAcercaDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAcercaDe.TabIndex = 0;
            this.pbAcercaDe.TabStop = false;
            // 
            // lbNombreAD
            // 
            this.lbNombreAD.AutoSize = true;
            this.lbNombreAD.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreAD.Location = new System.Drawing.Point(241, 44);
            this.lbNombreAD.Name = "lbNombreAD";
            this.lbNombreAD.Size = new System.Drawing.Size(170, 21);
            this.lbNombreAD.TabIndex = 1;
            this.lbNombreAD.Text = "Autor: Joel Sempere";
            this.lbNombreAD.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbProyectoAD
            // 
            this.lbProyectoAD.AutoSize = true;
            this.lbProyectoAD.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProyectoAD.Location = new System.Drawing.Point(241, 88);
            this.lbProyectoAD.Name = "lbProyectoAD";
            this.lbProyectoAD.Size = new System.Drawing.Size(208, 21);
            this.lbProyectoAD.TabIndex = 2;
            this.lbProyectoAD.Text = "Proyecto: Listas y menus";
            // 
            // lbVersionAD
            // 
            this.lbVersionAD.AutoSize = true;
            this.lbVersionAD.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersionAD.Location = new System.Drawing.Point(241, 140);
            this.lbVersionAD.Name = "lbVersionAD";
            this.lbVersionAD.Size = new System.Drawing.Size(103, 21);
            this.lbVersionAD.TabIndex = 3;
            this.lbVersionAD.Text = "Versión: 1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha: Octubre de 2021";
            // 
            // lbTextoAD
            // 
            this.lbTextoAD.AutoSize = true;
            this.lbTextoAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTextoAD.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextoAD.Location = new System.Drawing.Point(12, 266);
            this.lbTextoAD.Name = "lbTextoAD";
            this.lbTextoAD.Size = new System.Drawing.Size(636, 62);
            this.lbTextoAD.TabIndex = 5;
            this.lbTextoAD.Text = "Proyecto para practicar creación de menus y listas,\r\nvisibilidad de botones, redi" +
    "recciones a metodos ya existentes.\r\n";
            // 
            // fmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 343);
            this.Controls.Add(this.lbTextoAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbVersionAD);
            this.Controls.Add(this.lbProyectoAD);
            this.Controls.Add(this.lbNombreAD);
            this.Controls.Add(this.pbAcercaDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "fmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)(this.pbAcercaDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAcercaDe;
        private System.Windows.Forms.Label lbNombreAD;
        private System.Windows.Forms.Label lbProyectoAD;
        private System.Windows.Forms.Label lbVersionAD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTextoAD;
    }
}