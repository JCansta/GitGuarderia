namespace Guarderia
{
    partial class ingreso
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
            this.components = new System.ComponentModel.Container();
            this.nom_masctext = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nom_dueno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nom_duenoText = new System.Windows.Forms.TextBox();
            this.raza_masco = new System.Windows.Forms.TextBox();
            this.num_docsuenotext = new System.Windows.Forms.TextBox();
            this.correo_dueno = new System.Windows.Forms.TextBox();
            this.Tel_dueno = new System.Windows.Forms.TextBox();
            this.vac_mascsi = new System.Windows.Forms.CheckBox();
            this.vacmascno = new System.Windows.Forms.CheckBox();
            this.text2 = new System.Windows.Forms.Label();
            this.Guardarbtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.img_masco = new System.Windows.Forms.PictureBox();
            this.lista_tamano = new System.Windows.Forms.ComboBox();
            this.gen_masc = new System.Windows.Forms.ComboBox();
            this.masc_servi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_masco)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_masctext
            // 
            this.nom_masctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_masctext.Location = new System.Drawing.Point(64, 99);
            this.nom_masctext.Margin = new System.Windows.Forms.Padding(4);
            this.nom_masctext.Name = "nom_masctext";
            this.nom_masctext.Size = new System.Drawing.Size(140, 20);
            this.nom_masctext.TabIndex = 0;
            this.nom_masctext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Mascota";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raza";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamaño";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 375);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vacunas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 301);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Género";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nom_dueno
            // 
            this.nom_dueno.AutoSize = true;
            this.nom_dueno.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_dueno.Location = new System.Drawing.Point(385, 78);
            this.nom_dueno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nom_dueno.Name = "nom_dueno";
            this.nom_dueno.Size = new System.Drawing.Size(124, 17);
            this.nom_dueno.TabIndex = 7;
            this.nom_dueno.Text = "Nombre Del Dueño";
            this.nom_dueno.Click += new System.EventHandler(this.nom_dueno_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(385, 152);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Numero de Documento";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(385, 222);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(49, 17);
            this.text.TabIndex = 9;
            this.text.Text = "Correo";
            this.text.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(385, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Teléfono";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // nom_duenoText
            // 
            this.nom_duenoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_duenoText.Location = new System.Drawing.Point(388, 99);
            this.nom_duenoText.Margin = new System.Windows.Forms.Padding(4);
            this.nom_duenoText.Name = "nom_duenoText";
            this.nom_duenoText.Size = new System.Drawing.Size(140, 20);
            this.nom_duenoText.TabIndex = 11;
            // 
            // raza_masco
            // 
            this.raza_masco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raza_masco.Location = new System.Drawing.Point(64, 173);
            this.raza_masco.Margin = new System.Windows.Forms.Padding(4);
            this.raza_masco.Name = "raza_masco";
            this.raza_masco.Size = new System.Drawing.Size(140, 20);
            this.raza_masco.TabIndex = 12;
            // 
            // num_docsuenotext
            // 
            this.num_docsuenotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_docsuenotext.Location = new System.Drawing.Point(388, 173);
            this.num_docsuenotext.Margin = new System.Windows.Forms.Padding(4);
            this.num_docsuenotext.Name = "num_docsuenotext";
            this.num_docsuenotext.Size = new System.Drawing.Size(140, 20);
            this.num_docsuenotext.TabIndex = 14;
            this.num_docsuenotext.TextChanged += new System.EventHandler(this.num_docsuenotext_TextChanged);
            this.num_docsuenotext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_docsuenotext_KeyPress_1);
            // 
            // correo_dueno
            // 
            this.correo_dueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo_dueno.Location = new System.Drawing.Point(388, 243);
            this.correo_dueno.Margin = new System.Windows.Forms.Padding(4);
            this.correo_dueno.Name = "correo_dueno";
            this.correo_dueno.Size = new System.Drawing.Size(140, 20);
            this.correo_dueno.TabIndex = 15;
            this.correo_dueno.TextChanged += new System.EventHandler(this.correo_dueno_TextChanged);
            // 
            // Tel_dueno
            // 
            this.Tel_dueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_dueno.Location = new System.Drawing.Point(388, 322);
            this.Tel_dueno.Margin = new System.Windows.Forms.Padding(4);
            this.Tel_dueno.Name = "Tel_dueno";
            this.Tel_dueno.Size = new System.Drawing.Size(140, 20);
            this.Tel_dueno.TabIndex = 16;
            this.Tel_dueno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_docsuenotext_KeyPress_1);
            // 
            // vac_mascsi
            // 
            this.vac_mascsi.AutoSize = true;
            this.vac_mascsi.Location = new System.Drawing.Point(388, 396);
            this.vac_mascsi.Margin = new System.Windows.Forms.Padding(4);
            this.vac_mascsi.Name = "vac_mascsi";
            this.vac_mascsi.Size = new System.Drawing.Size(37, 20);
            this.vac_mascsi.TabIndex = 20;
            this.vac_mascsi.Text = "Si";
            this.vac_mascsi.UseVisualStyleBackColor = true;
            this.vac_mascsi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vacmascno
            // 
            this.vacmascno.AutoSize = true;
            this.vacmascno.Location = new System.Drawing.Point(433, 396);
            this.vacmascno.Margin = new System.Windows.Forms.Padding(4);
            this.vacmascno.Name = "vacmascno";
            this.vacmascno.Size = new System.Drawing.Size(44, 20);
            this.vacmascno.TabIndex = 21;
            this.vacmascno.Text = "No";
            this.vacmascno.UseVisualStyleBackColor = true;
            this.vacmascno.CheckedChanged += new System.EventHandler(this.vacmascno_CheckedChanged);
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(61, 371);
            this.text2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(53, 17);
            this.text2.TabIndex = 23;
            this.text2.Text = "Servicio";
            this.text2.Click += new System.EventHandler(this.text2_Click);
            // 
            // Guardarbtn
            // 
            this.Guardarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.Guardarbtn.FlatAppearance.BorderSize = 0;
            this.Guardarbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Guardarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbtn.ForeColor = System.Drawing.Color.Black;
            this.Guardarbtn.Location = new System.Drawing.Point(603, 388);
            this.Guardarbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Guardarbtn.Name = "Guardarbtn";
            this.Guardarbtn.Size = new System.Drawing.Size(76, 28);
            this.Guardarbtn.TabIndex = 0;
            this.Guardarbtn.Text = "Guardar";
            this.Guardarbtn.UseVisualStyleBackColor = false;
            this.Guardarbtn.Click += new System.EventHandler(this.Guardarbtn_Click);
            this.Guardarbtn.MouseHover += new System.EventHandler(this.Guardarbtn_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(190)))), ((int)(((byte)(97)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(603, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.Guardarbtn_MouseHover);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // img_masco
            // 
            this.img_masco.Location = new System.Drawing.Point(603, 79);
            this.img_masco.Margin = new System.Windows.Forms.Padding(4);
            this.img_masco.Name = "img_masco";
            this.img_masco.Size = new System.Drawing.Size(367, 233);
            this.img_masco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_masco.TabIndex = 27;
            this.img_masco.TabStop = false;
            this.img_masco.Click += new System.EventHandler(this.img_masco_Click);
            // 
            // lista_tamano
            // 
            this.lista_tamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_tamano.FormattingEnabled = true;
            this.lista_tamano.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande"});
            this.lista_tamano.Location = new System.Drawing.Point(64, 243);
            this.lista_tamano.Margin = new System.Windows.Forms.Padding(4);
            this.lista_tamano.Name = "lista_tamano";
            this.lista_tamano.Size = new System.Drawing.Size(140, 21);
            this.lista_tamano.TabIndex = 28;
            // 
            // gen_masc
            // 
            this.gen_masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_masc.FormattingEnabled = true;
            this.gen_masc.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.gen_masc.Location = new System.Drawing.Point(64, 322);
            this.gen_masc.Margin = new System.Windows.Forms.Padding(4);
            this.gen_masc.Name = "gen_masc";
            this.gen_masc.Size = new System.Drawing.Size(140, 21);
            this.gen_masc.TabIndex = 29;
            // 
            // masc_servi
            // 
            this.masc_servi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masc_servi.FormattingEnabled = true;
            this.masc_servi.Items.AddRange(new object[] {
            "Entrenamiento",
            "Guardería"});
            this.masc_servi.Location = new System.Drawing.Point(64, 392);
            this.masc_servi.Margin = new System.Windows.Forms.Padding(4);
            this.masc_servi.Name = "masc_servi";
            this.masc_servi.Size = new System.Drawing.Size(140, 21);
            this.masc_servi.TabIndex = 30;
            this.masc_servi.SelectedIndexChanged += new System.EventHandler(this.masc_servi_SelectedIndexChanged);
            // 
            // ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 559);
            this.Controls.Add(this.masc_servi);
            this.Controls.Add(this.gen_masc);
            this.Controls.Add(this.lista_tamano);
            this.Controls.Add(this.img_masco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Guardarbtn);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.vacmascno);
            this.Controls.Add(this.vac_mascsi);
            this.Controls.Add(this.Tel_dueno);
            this.Controls.Add(this.correo_dueno);
            this.Controls.Add(this.num_docsuenotext);
            this.Controls.Add(this.raza_masco);
            this.Controls.Add(this.nom_duenoText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nom_dueno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nom_masctext);
            this.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ingreso";
            this.Text = "ingreso";
            this.Load += new System.EventHandler(this.ingreso_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_docsuenotext_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.img_masco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nom_masctext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nom_dueno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nom_duenoText;
        private System.Windows.Forms.TextBox raza_masco;
        private System.Windows.Forms.TextBox num_docsuenotext;
        private System.Windows.Forms.TextBox correo_dueno;
        private System.Windows.Forms.TextBox Tel_dueno;
        private System.Windows.Forms.CheckBox vac_mascsi;
        private System.Windows.Forms.CheckBox vacmascno;
        private System.Windows.Forms.Label text2;
        private System.Windows.Forms.Button Guardarbtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox img_masco;
        private System.Windows.Forms.ComboBox lista_tamano;
        private System.Windows.Forms.ComboBox gen_masc;
        private System.Windows.Forms.ComboBox masc_servi;
    }
}