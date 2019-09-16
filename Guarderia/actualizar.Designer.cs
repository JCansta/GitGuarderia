namespace Guarderia
{
    partial class actualizar
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
            this.actualizardato = new System.Windows.Forms.TextBox();
            this.check_doc = new System.Windows.Forms.CheckBox();
            this.check_id = new System.Windows.Forms.CheckBox();
            this.panelview = new System.Windows.Forms.Panel();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actualizardato
            // 
            this.actualizardato.BackColor = System.Drawing.SystemColors.Menu;
            this.actualizardato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizardato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.actualizardato.Location = new System.Drawing.Point(12, 28);
            this.actualizardato.Multiline = true;
            this.actualizardato.Name = "actualizardato";
            this.actualizardato.Size = new System.Drawing.Size(176, 28);
            this.actualizardato.TabIndex = 16;
            this.actualizardato.Text = "🔎";
            this.actualizardato.Enter += new System.EventHandler(this.actualizardato_Enter);
            this.actualizardato.Leave += new System.EventHandler(this.actualizardato_Leave);
            // 
            // check_doc
            // 
            this.check_doc.AutoSize = true;
            this.check_doc.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_doc.Location = new System.Drawing.Point(12, 79);
            this.check_doc.Name = "check_doc";
            this.check_doc.Size = new System.Drawing.Size(70, 21);
            this.check_doc.TabIndex = 17;
            this.check_doc.Text = "Cedula";
            this.check_doc.UseVisualStyleBackColor = true;
            this.check_doc.CheckedChanged += new System.EventHandler(this.check_doc_CheckedChanged);
            // 
            // check_id
            // 
            this.check_id.AutoSize = true;
            this.check_id.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_id.Location = new System.Drawing.Point(103, 79);
            this.check_id.Name = "check_id";
            this.check_id.Size = new System.Drawing.Size(99, 21);
            this.check_id.TabIndex = 18;
            this.check_id.Text = "ID Mascota";
            this.check_id.UseVisualStyleBackColor = true;
            this.check_id.CheckedChanged += new System.EventHandler(this.check_id_CheckedChanged);
            // 
            // panelview
            // 
            this.panelview.Location = new System.Drawing.Point(229, 19);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(719, 465);
            this.panelview.TabIndex = 19;
            // 
            // buscarbtn
            // 
            this.buscarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.buscarbtn.FlatAppearance.BorderSize = 0;
            this.buscarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.buscarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarbtn.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buscarbtn.Location = new System.Drawing.Point(12, 124);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(76, 28);
            this.buscarbtn.TabIndex = 17;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = false;
            this.buscarbtn.Click += new System.EventHandler(this.buscarbtn_Click);
            // 
            // actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 559);
            this.ControlBox = false;
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.panelview);
            this.Controls.Add(this.check_id);
            this.Controls.Add(this.check_doc);
            this.Controls.Add(this.actualizardato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "actualizar";
            this.Load += new System.EventHandler(this.actualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox actualizardato;
        private System.Windows.Forms.CheckBox check_doc;
        private System.Windows.Forms.CheckBox check_id;
        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Button buscarbtn;
    }
}