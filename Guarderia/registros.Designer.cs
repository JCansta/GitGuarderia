namespace Guarderia
{
    partial class registros
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
            this.filtrotext = new System.Windows.Forms.TextBox();
            this.buscar_ced = new System.Windows.Forms.CheckBox();
            this.buscar_id = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.dgvBusqueda = new System.Windows.Forms.DataGridView();
            this.limpiarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // filtrotext
            // 
            this.filtrotext.BackColor = System.Drawing.SystemColors.Menu;
            this.filtrotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrotext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filtrotext.Location = new System.Drawing.Point(12, 26);
            this.filtrotext.Multiline = true;
            this.filtrotext.Name = "filtrotext";
            this.filtrotext.Size = new System.Drawing.Size(176, 28);
            this.filtrotext.TabIndex = 1;
            this.filtrotext.Text = "🔎";
            this.filtrotext.TextChanged += new System.EventHandler(this.filtrotext_TextChanged);
            this.filtrotext.Enter += new System.EventHandler(this.filtrotext_Enter);
            this.filtrotext.Leave += new System.EventHandler(this.filtrotext_Leave);
            // 
            // buscar_ced
            // 
            this.buscar_ced.AutoSize = true;
            this.buscar_ced.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_ced.Location = new System.Drawing.Point(12, 75);
            this.buscar_ced.Name = "buscar_ced";
            this.buscar_ced.Size = new System.Drawing.Size(70, 21);
            this.buscar_ced.TabIndex = 3;
            this.buscar_ced.Text = "Cedula";
            this.buscar_ced.UseVisualStyleBackColor = true;
            this.buscar_ced.CheckedChanged += new System.EventHandler(this.buscar_ced_CheckedChanged);
            // 
            // buscar_id
            // 
            this.buscar_id.AutoSize = true;
            this.buscar_id.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_id.Location = new System.Drawing.Point(88, 75);
            this.buscar_id.Name = "buscar_id";
            this.buscar_id.Size = new System.Drawing.Size(43, 21);
            this.buscar_id.TabIndex = 5;
            this.buscar_id.Text = "ID";
            this.buscar_id.UseVisualStyleBackColor = true;
            this.buscar_id.CheckedChanged += new System.EventHandler(this.buscar_id_CheckedChanged);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_buscar.Location = new System.Drawing.Point(12, 121);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(76, 28);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dgvBusqueda
            // 
            this.dgvBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBusqueda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusqueda.GridColor = System.Drawing.Color.Black;
            this.dgvBusqueda.Location = new System.Drawing.Point(12, 179);
            this.dgvBusqueda.Name = "dgvBusqueda";
            this.dgvBusqueda.ReadOnly = true;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.dgvBusqueda.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBusqueda.Size = new System.Drawing.Size(1028, 328);
            this.dgvBusqueda.TabIndex = 7;
            this.dgvBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusqueda_CellContentClick);
            // 
            // limpiarbtn
            // 
            this.limpiarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.limpiarbtn.FlatAppearance.BorderSize = 0;
            this.limpiarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.limpiarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiarbtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpiarbtn.Location = new System.Drawing.Point(112, 121);
            this.limpiarbtn.Name = "limpiarbtn";
            this.limpiarbtn.Size = new System.Drawing.Size(76, 28);
            this.limpiarbtn.TabIndex = 8;
            this.limpiarbtn.Text = "Limpiar";
            this.limpiarbtn.UseVisualStyleBackColor = false;
            this.limpiarbtn.Click += new System.EventHandler(this.limpiarbtn_Click);
            // 
            // registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 519);
            this.Controls.Add(this.limpiarbtn);
            this.Controls.Add(this.dgvBusqueda);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.buscar_id);
            this.Controls.Add(this.buscar_ced);
            this.Controls.Add(this.filtrotext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registros";
            this.Text = "buscar";
            this.Load += new System.EventHandler(this.buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filtrotext;
        private System.Windows.Forms.CheckBox buscar_ced;
        private System.Windows.Forms.CheckBox buscar_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgvBusqueda;
        private System.Windows.Forms.Button limpiarbtn;
    }
}