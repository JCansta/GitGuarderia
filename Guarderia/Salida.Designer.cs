namespace Guarderia
{
    partial class Salida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.check_id = new System.Windows.Forms.CheckBox();
            this.check_doc = new System.Windows.Forms.CheckBox();
            this.id_mascotext = new System.Windows.Forms.TextBox();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.dgv_salida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salida)).BeginInit();
            this.SuspendLayout();
            // 
            // check_id
            // 
            this.check_id.AutoSize = true;
            this.check_id.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_id.Location = new System.Drawing.Point(12, 76);
            this.check_id.Name = "check_id";
            this.check_id.Size = new System.Drawing.Size(99, 21);
            this.check_id.TabIndex = 13;
            this.check_id.Text = "ID Mascota";
            this.check_id.UseVisualStyleBackColor = true;
            // 
            // check_doc
            // 
            this.check_doc.AutoSize = true;
            this.check_doc.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_doc.Location = new System.Drawing.Point(118, 76);
            this.check_doc.Name = "check_doc";
            this.check_doc.Size = new System.Drawing.Size(70, 21);
            this.check_doc.TabIndex = 14;
            this.check_doc.Text = "Cedula";
            this.check_doc.UseVisualStyleBackColor = true;
            // 
            // id_mascotext
            // 
            this.id_mascotext.BackColor = System.Drawing.SystemColors.Menu;
            this.id_mascotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_mascotext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.id_mascotext.Location = new System.Drawing.Point(12, 26);
            this.id_mascotext.Multiline = true;
            this.id_mascotext.Name = "id_mascotext";
            this.id_mascotext.Size = new System.Drawing.Size(176, 28);
            this.id_mascotext.TabIndex = 15;
            this.id_mascotext.Text = "🔎";
            this.id_mascotext.TextChanged += new System.EventHandler(this.id_mascotext_TextChanged);
            this.id_mascotext.Enter += new System.EventHandler(this.id_mascotext_Enter_1);
            this.id_mascotext.Leave += new System.EventHandler(this.id_mascotext_Leave_1);
            // 
            // buscarbtn
            // 
            this.buscarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.buscarbtn.FlatAppearance.BorderSize = 0;
            this.buscarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.buscarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscarbtn.Location = new System.Drawing.Point(12, 119);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(76, 28);
            this.buscarbtn.TabIndex = 16;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = false;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click_1);
            // 
            // dgv_salida
            // 
            this.dgv_salida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_salida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salida.GridColor = System.Drawing.Color.Black;
            this.dgv_salida.Location = new System.Drawing.Point(12, 176);
            this.dgv_salida.Name = "dgv_salida";
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.dgv_salida.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_salida.Size = new System.Drawing.Size(1029, 371);
            this.dgv_salida.TabIndex = 17;
            this.dgv_salida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salida_CellContentClick);
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 559);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_salida);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.id_mascotext);
            this.Controls.Add(this.check_doc);
            this.Controls.Add(this.check_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salida";
            this.Load += new System.EventHandler(this.Salida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox check_id;
        private System.Windows.Forms.CheckBox check_doc;
        private System.Windows.Forms.TextBox id_mascotext;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.DataGridView dgv_salida;
    }
}