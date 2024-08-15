namespace WindowsFormsApp2
{
    partial class fComisaria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreacion = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dudNroGuardia = new System.Windows.Forms.DomainUpDown();
            this.dudGuardiaDesdeH = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown3 = new System.Windows.Forms.DomainUpDown();
            this.dudGuardiaDesdeM = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dudIncDesdeM = new System.Windows.Forms.DomainUpDown();
            this.dudIncDesdeH = new System.Windows.Forms.DomainUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistrarInc = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListar);
            this.groupBox1.Controls.Add(this.btnCreacion);
            this.groupBox1.Location = new System.Drawing.Point(54, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración comisaría";
            // 
            // btnCreacion
            // 
            this.btnCreacion.Location = new System.Drawing.Point(166, 36);
            this.btnCreacion.Name = "btnCreacion";
            this.btnCreacion.Size = new System.Drawing.Size(122, 41);
            this.btnCreacion.TabIndex = 0;
            this.btnCreacion.Text = "Creación comisaría";
            this.btnCreacion.UseVisualStyleBackColor = true;
            this.btnCreacion.Click += new System.EventHandler(this.btnCreacion_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(392, 36);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(141, 41);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar incidentes";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCerrar);
            this.groupBox2.Controls.Add(this.cbPlacas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(54, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 432);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones sobre el agente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.domainUpDown3);
            this.groupBox3.Controls.Add(this.dudGuardiaDesdeM);
            this.groupBox3.Controls.Add(this.dudGuardiaDesdeH);
            this.groupBox3.Controls.Add(this.dudNroGuardia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(18, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(635, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administración de guardias";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRegistrarInc);
            this.groupBox4.Controls.Add(this.tbDNI);
            this.groupBox4.Controls.Add(this.tbNombre);
            this.groupBox4.Controls.Add(this.dudIncDesdeM);
            this.groupBox4.Controls.Add(this.cbTipo);
            this.groupBox4.Controls.Add(this.dudIncDesdeH);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(18, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(635, 184);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Administración de incidentes";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa del agente:";
            // 
            // cbPlacas
            // 
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(110, 23);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(121, 21);
            this.cbPlacas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro guardia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duración en M:";
            // 
            // dudNroGuardia
            // 
            this.dudNroGuardia.Location = new System.Drawing.Point(120, 14);
            this.dudNroGuardia.Name = "dudNroGuardia";
            this.dudNroGuardia.Size = new System.Drawing.Size(120, 20);
            this.dudNroGuardia.TabIndex = 1;
            // 
            // dudGuardiaDesdeH
            // 
            this.dudGuardiaDesdeH.Location = new System.Drawing.Point(120, 40);
            this.dudGuardiaDesdeH.Name = "dudGuardiaDesdeH";
            this.dudGuardiaDesdeH.Size = new System.Drawing.Size(58, 20);
            this.dudGuardiaDesdeH.TabIndex = 1;
            // 
            // domainUpDown3
            // 
            this.domainUpDown3.Location = new System.Drawing.Point(120, 66);
            this.domainUpDown3.Name = "domainUpDown3";
            this.domainUpDown3.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown3.TabIndex = 1;
            // 
            // dudGuardiaDesdeM
            // 
            this.dudGuardiaDesdeM.Location = new System.Drawing.Point(184, 40);
            this.dudGuardiaDesdeM.Name = "dudGuardiaDesdeM";
            this.dudGuardiaDesdeM.Size = new System.Drawing.Size(56, 20);
            this.dudGuardiaDesdeM.TabIndex = 1;
            this.dudGuardiaDesdeM.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Asignación de las guardias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(129, 31);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo incidente";
            // 
            // dudIncDesdeM
            // 
            this.dudIncDesdeM.Location = new System.Drawing.Point(193, 70);
            this.dudIncDesdeM.Name = "dudIncDesdeM";
            this.dudIncDesdeM.Size = new System.Drawing.Size(56, 20);
            this.dudIncDesdeM.TabIndex = 4;
            // 
            // dudIncDesdeH
            // 
            this.dudIncDesdeH.Location = new System.Drawing.Point(129, 70);
            this.dudIncDesdeH.Name = "dudIncDesdeH";
            this.dudIncDesdeH.Size = new System.Drawing.Size(58, 20);
            this.dudIncDesdeH.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Desde:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Persona:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DNI:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(129, 102);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(93, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(264, 102);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(93, 20);
            this.tbDNI.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Motivo:";
            // 
            // btnRegistrarInc
            // 
            this.btnRegistrarInc.Location = new System.Drawing.Point(475, 74);
            this.btnRegistrarInc.Name = "btnRegistrarInc";
            this.btnRegistrarInc.Size = new System.Drawing.Size(114, 48);
            this.btnRegistrarInc.TabIndex = 2;
            this.btnRegistrarInc.Text = "Registrar incidente";
            this.btnRegistrarInc.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(321, 357);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 48);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // fComisaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fComisaria";
            this.Text = "Comisaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCreacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DomainUpDown domainUpDown3;
        private System.Windows.Forms.DomainUpDown dudGuardiaDesdeM;
        private System.Windows.Forms.DomainUpDown dudGuardiaDesdeH;
        private System.Windows.Forms.DomainUpDown dudNroGuardia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DomainUpDown dudIncDesdeM;
        private System.Windows.Forms.DomainUpDown dudIncDesdeH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarInc;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCerrar;
    }
}

