namespace pokemon.VISTAS
{
    partial class Notificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notificacion));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IMAGEN = new System.Windows.Forms.PictureBox();
            this.LBL_MENSAJE = new System.Windows.Forms.Label();
            this.BTN_ACEPTAR = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.IMAGEN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LBL_MENSAJE, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_ACEPTAR, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IMAGEN
            // 
            this.IMAGEN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMAGEN.Location = new System.Drawing.Point(2, 2);
            this.IMAGEN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.Size = new System.Drawing.Size(456, 300);
            this.IMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMAGEN.TabIndex = 0;
            this.IMAGEN.TabStop = false;
            this.IMAGEN.Click += new System.EventHandler(this.IMAGEN_Click);
            // 
            // LBL_MENSAJE
            // 
            this.LBL_MENSAJE.AutoSize = true;
            this.LBL_MENSAJE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_MENSAJE.Location = new System.Drawing.Point(2, 304);
            this.LBL_MENSAJE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_MENSAJE.Name = "LBL_MENSAJE";
            this.LBL_MENSAJE.Size = new System.Drawing.Size(456, 38);
            this.LBL_MENSAJE.TabIndex = 1;
            this.LBL_MENSAJE.Text = "-";
            this.LBL_MENSAJE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_ACEPTAR
            // 
            this.BTN_ACEPTAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_ACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ACEPTAR.Location = new System.Drawing.Point(2, 344);
            this.BTN_ACEPTAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_ACEPTAR.Name = "BTN_ACEPTAR";
            this.BTN_ACEPTAR.Size = new System.Drawing.Size(456, 35);
            this.BTN_ACEPTAR.TabIndex = 2;
            this.BTN_ACEPTAR.Text = "ACEPTAR";
            this.BTN_ACEPTAR.UseVisualStyleBackColor = true;
            this.BTN_ACEPTAR.Click += new System.EventHandler(this.BTN_ACEPTAR_Click);
            // 
            // Notificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(460, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificacion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGEN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox IMAGEN;
        private System.Windows.Forms.Label LBL_MENSAJE;
        private System.Windows.Forms.Button BTN_ACEPTAR;
    }
}