﻿namespace proyecto_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbDni = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFormasdemorir = new System.Windows.Forms.Label();
            this.lblReligion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.cmbMorir = new System.Windows.Forms.ComboBox();
            this.gpSexo = new System.Windows.Forms.GroupBox();
            this.rbOtros = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.gpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido.Location = new System.Drawing.Point(38, 229);
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(168, 27);
            this.txbApellido.TabIndex = 0;
            // 
            // txbDni
            // 
            this.txbDni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDni.Location = new System.Drawing.Point(38, 298);
            this.txbDni.Name = "txbDni";
            this.txbDni.Size = new System.Drawing.Size(168, 27);
            this.txbDni.TabIndex = 1;
            this.txbDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDni_KeyPress);
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(38, 157);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(168, 27);
            this.txbNombre.TabIndex = 7;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApellido.Location = new System.Drawing.Point(33, 197);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(122, 25);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido/s:";
            // 
            // lblFormasdemorir
            // 
            this.lblFormasdemorir.AutoSize = true;
            this.lblFormasdemorir.BackColor = System.Drawing.Color.Transparent;
            this.lblFormasdemorir.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormasdemorir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFormasdemorir.Location = new System.Drawing.Point(33, 482);
            this.lblFormasdemorir.Name = "lblFormasdemorir";
            this.lblFormasdemorir.Size = new System.Drawing.Size(343, 25);
            this.lblFormasdemorir.TabIndex = 9;
            this.lblFormasdemorir.Text = "Escriba o elija su forma de morir:";
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.BackColor = System.Drawing.Color.Transparent;
            this.lblReligion.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReligion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblReligion.Location = new System.Drawing.Point(33, 406);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(208, 25);
            this.lblReligion.TabIndex = 13;
            this.lblReligion.Text = "Creencia Religiosa:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDni.Location = new System.Drawing.Point(33, 269);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(79, 25);
            this.lblDni.TabIndex = 14;
            this.lblDni.Text = "D.N.I. :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Location = new System.Drawing.Point(33, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 25);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre/s:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.Black;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptar.Location = new System.Drawing.Point(299, 578);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 36);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Siguiente";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Black;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(452, 578);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 36);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Atras";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbReligion
            // 
            this.cmbReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReligion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "• Católico",
            "• Protestante",
            "• Evangélico",
            "• Ateo (Iras al infierno)",
            "• Hindú",
            "• Budista",
            "• Otros (No tan importantes, iras al infierno también)"});
            this.cmbReligion.Location = new System.Drawing.Point(38, 437);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(464, 29);
            this.cmbReligion.TabIndex = 21;
            // 
            // cmbMorir
            // 
            this.cmbMorir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMorir.FormattingEnabled = true;
            this.cmbMorir.Items.AddRange(new object[] {
            "• Atropellado por un triciclo",
            "• De una depresión por no poder ir al baño",
            "• Por el chasquido de Thanos",
            "• Por un tiburón que salga de un inodoro",
            "• Desangrado por flechazo en los testículos, montado en un lobo en el bosque",
            "• Decapitado por un ventilador de techo",
            "• Por una infección por comerse las uñas",
            "• Envenenado por tinta de impresora vencida",
            "• Asfixiado por un mono en el zoológico",
            "• Ahogado por un vaso de agua",
            "• Aplastado por una grúa que levantaba otra grúa",
            "• Golpeado hasta la muerte con una almohada",
            "• Tras una revisión de rutina en el hospital de Berazategui",
            "• Envenenado por lamer un sapo",
            "• Por no tener bien atado los zapatos",
            "• Por el impacto de un meteorito del tamaño de un alfiler",
            "• Mordido por un perro sin dientes",
            "• En el pogo de La Beriso",
            "• Por el susto de un disparo falso en una obra de teatro",
            "• Por el pañal sucio de un bebe",
            "• Por meter la cabeza dentro de un microondas",
            "• De la misma manera que tu personaje en D&D",
            "• Cementado por una mescladora de cemento",
            "• Desangrado por algún efecto especial en una película de Tarantino"});
            this.cmbMorir.Location = new System.Drawing.Point(38, 513);
            this.cmbMorir.Name = "cmbMorir";
            this.cmbMorir.Size = new System.Drawing.Size(809, 29);
            this.cmbMorir.TabIndex = 22;
            // 
            // gpSexo
            // 
            this.gpSexo.BackColor = System.Drawing.Color.Transparent;
            this.gpSexo.Controls.Add(this.rbOtros);
            this.gpSexo.Controls.Add(this.rbFemenino);
            this.gpSexo.Controls.Add(this.rbMasculino);
            this.gpSexo.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpSexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpSexo.Location = new System.Drawing.Point(248, 127);
            this.gpSexo.Name = "gpSexo";
            this.gpSexo.Size = new System.Drawing.Size(144, 136);
            this.gpSexo.TabIndex = 23;
            this.gpSexo.TabStop = false;
            this.gpSexo.Text = "Sexo:";
            // 
            // rbOtros
            // 
            this.rbOtros.AutoSize = true;
            this.rbOtros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbOtros.Location = new System.Drawing.Point(6, 98);
            this.rbOtros.Name = "rbOtros";
            this.rbOtros.Size = new System.Drawing.Size(83, 29);
            this.rbOtros.TabIndex = 21;
            this.rbOtros.TabStop = true;
            this.rbOtros.Text = "Otros";
            this.rbOtros.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbFemenino.Location = new System.Drawing.Point(6, 63);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(130, 29);
            this.rbFemenino.TabIndex = 20;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbMasculino.Location = new System.Drawing.Point(6, 28);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(134, 29);
            this.rbMasculino.TabIndex = 19;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 72);
            this.label1.TabIndex = 24;
            this.label1.Text = "¡Hola! Le damos la bienvenida a Die Fast.\r\nPor favor complete el siguiente formul" +
    "ario para continuar.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Edad en la que desee morir:";
            // 
            // txbEdad
            // 
            this.txbEdad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEdad.Location = new System.Drawing.Point(39, 370);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(166, 27);
            this.txbEdad.TabIndex = 26;
            this.txbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEdad_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 644);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpSexo);
            this.Controls.Add(this.cmbMorir);
            this.Controls.Add(this.cmbReligion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblReligion);
            this.Controls.Add(this.lblFormasdemorir);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbDni);
            this.Controls.Add(this.txbApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die Fast";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gpSexo.ResumeLayout(false);
            this.gpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbDni;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFormasdemorir;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.ComboBox cmbMorir;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        public System.Windows.Forms.GroupBox gpSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbEdad;
    }
}