namespace pokemon
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_INICIAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_INICIAR
            // 
            this.BTN_INICIAR.Location = new System.Drawing.Point(267, 278);
            this.BTN_INICIAR.Name = "BTN_INICIAR";
            this.BTN_INICIAR.Size = new System.Drawing.Size(254, 100);
            this.BTN_INICIAR.TabIndex = 0;
            this.BTN_INICIAR.Text = "INICIAR";
            this.BTN_INICIAR.UseVisualStyleBackColor = true;
            this.BTN_INICIAR.Click += new System.EventHandler(this.BTN_INICIAR_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_INICIAR);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_INICIAR;
    }
}

