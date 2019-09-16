namespace Guarderia
{
    partial class filtros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filtromasregis = new System.Windows.Forms.Button();
            this.filtromesbtn = new System.Windows.Forms.Button();
            this.tamanobtn = new System.Windows.Forms.Button();
            this.servifiltrobtn = new System.Windows.Forms.Button();
            this.dgvfiltros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // filtromasregis
            // 
            this.filtromasregis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.filtromasregis.FlatAppearance.BorderSize = 0;
            this.filtromasregis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.filtromasregis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtromasregis.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtromasregis.Location = new System.Drawing.Point(12, 12);
            this.filtromasregis.Name = "filtromasregis";
            this.filtromasregis.Size = new System.Drawing.Size(162, 35);
            this.filtromasregis.TabIndex = 1;
            this.filtromasregis.Text = "Mas masc. registradas";
            this.filtromasregis.UseVisualStyleBackColor = false;
            this.filtromasregis.Click += new System.EventHandler(this.filtromasregis_Click);
            // 
            // filtromesbtn
            // 
            this.filtromesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.filtromesbtn.FlatAppearance.BorderSize = 0;
            this.filtromesbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.filtromesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtromesbtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtromesbtn.Location = new System.Drawing.Point(12, 82);
            this.filtromesbtn.Name = "filtromesbtn";
            this.filtromesbtn.Size = new System.Drawing.Size(162, 35);
            this.filtromesbtn.TabIndex = 2;
            this.filtromesbtn.Text = "ultimo mes";
            this.filtromesbtn.UseVisualStyleBackColor = false;
            this.filtromesbtn.Click += new System.EventHandler(this.filtromesbtn_Click);
            // 
            // tamanobtn
            // 
            this.tamanobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.tamanobtn.FlatAppearance.BorderSize = 0;
            this.tamanobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.tamanobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tamanobtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanobtn.Location = new System.Drawing.Point(243, 12);
            this.tamanobtn.Name = "tamanobtn";
            this.tamanobtn.Size = new System.Drawing.Size(162, 35);
            this.tamanobtn.TabIndex = 3;
            this.tamanobtn.Text = "cantidad por tamaño";
            this.tamanobtn.UseVisualStyleBackColor = false;
            this.tamanobtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // servifiltrobtn
            // 
            this.servifiltrobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.servifiltrobtn.FlatAppearance.BorderSize = 0;
            this.servifiltrobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.servifiltrobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servifiltrobtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servifiltrobtn.Location = new System.Drawing.Point(12, 155);
            this.servifiltrobtn.Name = "servifiltrobtn";
            this.servifiltrobtn.Size = new System.Drawing.Size(162, 35);
            this.servifiltrobtn.TabIndex = 4;
            this.servifiltrobtn.Text = "Cantidad por servicio";
            this.servifiltrobtn.UseVisualStyleBackColor = false;
            this.servifiltrobtn.Click += new System.EventHandler(this.servifiltrobtn_Click);
            // 
            // dgvfiltros
            // 
            this.dgvfiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvfiltros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvfiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfiltros.GridColor = System.Drawing.Color.Black;
            this.dgvfiltros.Location = new System.Drawing.Point(12, 226);
            this.dgvfiltros.Name = "dgvfiltros";
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.dgvfiltros.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvfiltros.Size = new System.Drawing.Size(1029, 321);
            this.dgvfiltros.TabIndex = 18;
            // 
            // filtros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 559);
            this.ControlBox = false;
            this.Controls.Add(this.dgvfiltros);
            this.Controls.Add(this.servifiltrobtn);
            this.Controls.Add(this.tamanobtn);
            this.Controls.Add(this.filtromesbtn);
            this.Controls.Add(this.filtromasregis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "filtros";
            this.Load += new System.EventHandler(this.filtros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfiltros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filtromasregis;
        private System.Windows.Forms.Button filtromesbtn;
        private System.Windows.Forms.Button tamanobtn;
        private System.Windows.Forms.Button servifiltrobtn;
        private System.Windows.Forms.DataGridView dgvfiltros;
    }
}