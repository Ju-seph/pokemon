namespace pokemon.VISTAS
{
    partial class Principal
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
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.LBL_NOMBRE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // IMAGEN
            // 
            this.IMAGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMAGEN.Location = new System.Drawing.Point(40, 30);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(341, 338);
            this.IMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGEN.TabIndex = 0;
            this.IMAGEN.TabStop = false;
            // 
            // LBL_NOMBRE
            // 
            this.LBL_NOMBRE.AutoSize = true;
            this.LBL_NOMBRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NOMBRE.Location = new System.Drawing.Point(424, 161);
            this.LBL_NOMBRE.Name = "LBL_NOMBRE";
            this.LBL_NOMBRE.Size = new System.Drawing.Size(85, 29);
            this.LBL_NOMBRE.TabIndex = 1;
            this.LBL_NOMBRE.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_NOMBRE);
            this.Controls.Add(this.IMAGEN);
            this.Name = "Principal";
            this.Text = "Principal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Principal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.Label LBL_NOMBRE;
    }
}