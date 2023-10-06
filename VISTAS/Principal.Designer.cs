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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.LBL_USUARIO = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_SCORE = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_OPC3 = new System.Windows.Forms.Button();
            this.BTN_OPC2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_POKEMON = new System.Windows.Forms.Label();
            this.LBL_TITULO = new System.Windows.Forms.Label();
            this.BTN_OPC1 = new System.Windows.Forms.Button();
            this.IMG_POKEMON = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_POKEMON)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_USUARIO
            // 
            this.LBL_USUARIO.AutoSize = true;
            this.LBL_USUARIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_USUARIO.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USUARIO.Location = new System.Drawing.Point(2, 434);
            this.LBL_USUARIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_USUARIO.Name = "LBL_USUARIO";
            this.LBL_USUARIO.Size = new System.Drawing.Size(516, 49);
            this.LBL_USUARIO.TabIndex = 1;
            this.LBL_USUARIO.Text = "USUARIO";
            this.LBL_USUARIO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LBL_SCORE, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBL_USUARIO, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 483);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LBL_SCORE
            // 
            this.LBL_SCORE.AutoSize = true;
            this.LBL_SCORE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_SCORE.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SCORE.Location = new System.Drawing.Point(522, 434);
            this.LBL_SCORE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_SCORE.Name = "LBL_SCORE";
            this.LBL_SCORE.Size = new System.Drawing.Size(127, 49);
            this.LBL_SCORE.TabIndex = 3;
            this.LBL_SCORE.Text = "Score: 0";
            this.LBL_SCORE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_OPC3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BTN_OPC2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BTN_OPC1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(522, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(127, 430);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BTN_OPC3
            // 
            this.BTN_OPC3.BackgroundImage = global::pokemon.Properties.Resources.pokeball_print_monn_print;
            this.BTN_OPC3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_OPC3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OPC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OPC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_OPC3.Location = new System.Drawing.Point(2, 288);
            this.BTN_OPC3.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OPC3.Name = "BTN_OPC3";
            this.BTN_OPC3.Size = new System.Drawing.Size(123, 140);
            this.BTN_OPC3.TabIndex = 0;
            this.BTN_OPC3.Text = "-";
            this.BTN_OPC3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_OPC3.UseVisualStyleBackColor = true;
            this.BTN_OPC3.Click += new System.EventHandler(this.BTN_OPC3_Click);
            // 
            // BTN_OPC2
            // 
            this.BTN_OPC2.BackgroundImage = global::pokemon.Properties.Resources.pokeball_print_monn_print;
            this.BTN_OPC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_OPC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OPC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OPC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_OPC2.Location = new System.Drawing.Point(2, 145);
            this.BTN_OPC2.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OPC2.Name = "BTN_OPC2";
            this.BTN_OPC2.Size = new System.Drawing.Size(123, 139);
            this.BTN_OPC2.TabIndex = 0;
            this.BTN_OPC2.Text = "-";
            this.BTN_OPC2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_OPC2.UseVisualStyleBackColor = true;
            this.BTN_OPC2.Click += new System.EventHandler(this.BTN_OPC2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LBL_POKEMON, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.IMG_POKEMON, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.LBL_TITULO, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(516, 430);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // LBL_POKEMON
            // 
            this.LBL_POKEMON.AutoSize = true;
            this.LBL_POKEMON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_POKEMON.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_POKEMON.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LBL_POKEMON.Location = new System.Drawing.Point(2, 387);
            this.LBL_POKEMON.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_POKEMON.Name = "LBL_POKEMON";
            this.LBL_POKEMON.Size = new System.Drawing.Size(512, 43);
            this.LBL_POKEMON.TabIndex = 2;
            this.LBL_POKEMON.Text = "-";
            this.LBL_POKEMON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_TITULO
            // 
            this.LBL_TITULO.AutoSize = true;
            this.LBL_TITULO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBL_TITULO.Font = new System.Drawing.Font("Trebuchet MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITULO.ForeColor = System.Drawing.Color.Black;
            this.LBL_TITULO.Location = new System.Drawing.Point(2, 0);
            this.LBL_TITULO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TITULO.Name = "LBL_TITULO";
            this.LBL_TITULO.Size = new System.Drawing.Size(512, 43);
            this.LBL_TITULO.TabIndex = 3;
            this.LBL_TITULO.Text = "¿QUIÉN ES ESE POKEMÓN?";
            this.LBL_TITULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_OPC1
            // 
            this.BTN_OPC1.BackgroundImage = global::pokemon.Properties.Resources.pokeball_print_monn_print;
            this.BTN_OPC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_OPC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OPC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_OPC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BTN_OPC1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_OPC1.Location = new System.Drawing.Point(2, 2);
            this.BTN_OPC1.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_OPC1.Name = "BTN_OPC1";
            this.BTN_OPC1.Size = new System.Drawing.Size(123, 139);
            this.BTN_OPC1.TabIndex = 0;
            this.BTN_OPC1.Text = "-";
            this.BTN_OPC1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_OPC1.UseVisualStyleBackColor = true;
            this.BTN_OPC1.Click += new System.EventHandler(this.BTN_OPC1_Click);
            // 
            // IMG_POKEMON
            // 
            this.IMG_POKEMON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMG_POKEMON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMG_POKEMON.Location = new System.Drawing.Point(2, 45);
            this.IMG_POKEMON.Margin = new System.Windows.Forms.Padding(2);
            this.IMG_POKEMON.Name = "IMG_POKEMON";
            this.IMG_POKEMON.Size = new System.Drawing.Size(512, 340);
            this.IMG_POKEMON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IMG_POKEMON.TabIndex = 1;
            this.IMG_POKEMON.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 483);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_POKEMON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBL_USUARIO;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LBL_SCORE;
        private System.Windows.Forms.Button BTN_OPC3;
        private System.Windows.Forms.Button BTN_OPC2;
        private System.Windows.Forms.Button BTN_OPC1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label LBL_POKEMON;
        private System.Windows.Forms.PictureBox IMG_POKEMON;
        private System.Windows.Forms.Label LBL_TITULO;
    }
}