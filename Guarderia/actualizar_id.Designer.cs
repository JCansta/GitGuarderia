namespace Guarderia
{
    partial class actualizar_id
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
            this.gen_masc = new System.Windows.Forms.ComboBox();
            this.lista_tamano = new System.Windows.Forms.ComboBox();
            this.vacmascno = new System.Windows.Forms.CheckBox();
            this.vac_mascsi = new System.Windows.Forms.CheckBox();
            this.raza_masco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nom_masctext = new System.Windows.Forms.TextBox();
            this.img_masco = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.actualizarbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_masco)).BeginInit();
            this.SuspendLayout();
            // 
            // gen_masc
            // 
            this.gen_masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_masc.FormattingEnabled = true;
            this.gen_masc.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.gen_masc.Location = new System.Drawing.Point(112, 273);
            this.gen_masc.Margin = new System.Windows.Forms.Padding(4);
            this.gen_masc.Name = "gen_masc";
            this.gen_masc.Size = new System.Drawing.Size(140, 21);
            this.gen_masc.TabIndex = 50;
            // 
            // lista_tamano
            // 
            this.lista_tamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_tamano.FormattingEnabled = true;
            this.lista_tamano.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.lista_tamano.Location = new System.Drawing.Point(112, 194);
            this.lista_tamano.Margin = new System.Windows.Forms.Padding(4);
            this.lista_tamano.Name = "lista_tamano";
            this.lista_tamano.Size = new System.Drawing.Size(140, 21);
            this.lista_tamano.TabIndex = 49;
            // 
            // vacmascno
            // 
            this.vacmascno.AutoSize = true;
            this.vacmascno.Location = new System.Drawing.Point(157, 351);
            this.vacmascno.Margin = new System.Windows.Forms.Padding(4);
            this.vacmascno.Name = "vacmascno";
            this.vacmascno.Size = new System.Drawing.Size(40, 17);
            this.vacmascno.TabIndex = 47;
            this.vacmascno.Text = "No";
            this.vacmascno.UseVisualStyleBackColor = true;
            this.vacmascno.CheckedChanged += new System.EventHandler(this.vacmascno_CheckedChanged);
            // 
            // vac_mascsi
            // 
            this.vac_mascsi.AutoSize = true;
            this.vac_mascsi.Location = new System.Drawing.Point(112, 351);
            this.vac_mascsi.Margin = new System.Windows.Forms.Padding(4);
            this.vac_mascsi.Name = "vac_mascsi";
            this.vac_mascsi.Size = new System.Drawing.Size(35, 17);
            this.vac_mascsi.TabIndex = 46;
            this.vac_mascsi.Text = "Si";
            this.vac_mascsi.UseVisualStyleBackColor = true;
            this.vac_mascsi.CheckedChanged += new System.EventHandler(this.vac_mascsi_CheckedChanged);
            // 
            // raza_masco
            // 
            this.raza_masco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raza_masco.Location = new System.Drawing.Point(112, 124);
            this.raza_masco.Margin = new System.Windows.Forms.Padding(4);
            this.raza_masco.Name = "raza_masco";
            this.raza_masco.Size = new System.Drawing.Size(140, 20);
            this.raza_masco.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Vacunas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Tamaño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Raza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nombre Mascota";
            // 
            // nom_masctext
            // 
            this.nom_masctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_masctext.Location = new System.Drawing.Point(112, 50);
            this.nom_masctext.Margin = new System.Windows.Forms.Padding(4);
            this.nom_masctext.Name = "nom_masctext";
            this.nom_masctext.Size = new System.Drawing.Size(140, 20);
            this.nom_masctext.TabIndex = 31;
            // 
            // img_masco
            // 
            this.img_masco.Location = new System.Drawing.Point(339, 50);
            this.img_masco.Margin = new System.Windows.Forms.Padding(4);
            this.img_masco.Name = "img_masco";
            this.img_masco.Size = new System.Drawing.Size(367, 233);
            this.img_masco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_masco.TabIndex = 52;
            this.img_masco.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(385, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 53;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // actualizarbtn
            // 
            this.actualizarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.actualizarbtn.FlatAppearance.BorderSize = 0;
            this.actualizarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.actualizarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizarbtn.ForeColor = System.Drawing.Color.Black;
            this.actualizarbtn.Location = new System.Drawing.Point(339, 343);
            this.actualizarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.actualizarbtn.Name = "actualizarbtn";
            this.actualizarbtn.Size = new System.Drawing.Size(76, 28);
            this.actualizarbtn.TabIndex = 54;
            this.actualizarbtn.Text = "Actualizar";
            this.actualizarbtn.UseVisualStyleBackColor = false;
            this.actualizarbtn.Click += new System.EventHandler(this.actualizarbtn_Click);
            // 
            // actualizar_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 465);
            this.Controls.Add(this.actualizarbtn);
            this.Controls.Add(this.img_masco);
            this.Controls.Add(this.gen_masc);
            this.Controls.Add(this.lista_tamano);
            this.Controls.Add(this.vacmascno);
            this.Controls.Add(this.vac_mascsi);
            this.Controls.Add(this.raza_masco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom_masctext);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "actualizar_id";
            this.Text = "actualizar_id";
            this.Load += new System.EventHandler(this.actualizar_id_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_masco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox gen_masc;
        private System.Windows.Forms.ComboBox lista_tamano;
        private System.Windows.Forms.CheckBox vacmascno;
        private System.Windows.Forms.CheckBox vac_mascsi;
        private System.Windows.Forms.TextBox raza_masco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom_masctext;
        private System.Windows.Forms.PictureBox img_masco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button actualizarbtn;
    }
}