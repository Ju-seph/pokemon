namespace pokemon.VISTAS
{
    partial class Puntajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puntajes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TABLA = new System.Windows.Forms.DataGridView();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_PUNTAJES = new System.Windows.Forms.Label();
            this.BTN_INICIO = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TABLA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TABLA
            // 
            this.TABLA.AllowUserToAddRows = false;
            this.TABLA.AllowUserToDeleteRows = false;
            this.TABLA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TABLA.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TABLA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TABLA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Puntaje});
            this.TABLA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABLA.Location = new System.Drawing.Point(3, 48);
            this.TABLA.MultiSelect = false;
            this.TABLA.Name = "TABLA";
            this.TABLA.ReadOnly = true;
            this.TABLA.RowHeadersWidth = 51;
            this.TABLA.RowTemplate.Height = 24;
            this.TABLA.Size = new System.Drawing.Size(794, 399);
            this.TABLA.TabIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "USUARIO";
            this.Usuario.MinimumWidth = 6;
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "PUNTAJE";
            this.Puntaje.MinimumWidth = 6;
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Controls.Add(this.LBL_PUNTAJES, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_INICIO, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 39);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LBL_PUNTAJES
            // 
            this.LBL_PUNTAJES.AutoSize = true;
            this.LBL_PUNTAJES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_PUNTAJES.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PUNTAJES.Location = new System.Drawing.Point(122, 0);
            this.LBL_PUNTAJES.Name = "LBL_PUNTAJES";
            this.LBL_PUNTAJES.Size = new System.Drawing.Size(669, 39);
            this.LBL_PUNTAJES.TabIndex = 0;
            this.LBL_PUNTAJES.Text = "PUNTAJES";
            this.LBL_PUNTAJES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_INICIO
            // 
            this.BTN_INICIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_INICIO.Location = new System.Drawing.Point(3, 3);
            this.BTN_INICIO.Name = "BTN_INICIO";
            this.BTN_INICIO.Size = new System.Drawing.Size(113, 33);
            this.BTN_INICIO.TabIndex = 1;
            this.BTN_INICIO.Text = "INICIO";
            this.BTN_INICIO.UseVisualStyleBackColor = true;
            this.BTN_INICIO.Click += new System.EventHandler(this.BTN_INICIO_Click);
            // 
            // Puntajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puntajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Puntajes_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TABLA)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView TABLA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LBL_PUNTAJES;
        private System.Windows.Forms.Button BTN_INICIO;
    }
}