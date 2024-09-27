namespace Corte_1
{
    partial class Form1
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
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnCalcularEdad = new System.Windows.Forms.Button();
            this.cbCiudades = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(207, 57);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(212, 22);
            this.tbNombres.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(207, 95);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(212, 22);
            this.tbApellidos.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la fecha de Nacimiento";
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(65, 256);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(141, 48);
            this.btnAgregarPersona.TabIndex = 6;
            this.btnAgregarPersona.Text = "Guardar datos";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnCalcularEdad
            // 
            this.btnCalcularEdad.Location = new System.Drawing.Point(302, 256);
            this.btnCalcularEdad.Name = "btnCalcularEdad";
            this.btnCalcularEdad.Size = new System.Drawing.Size(99, 48);
            this.btnCalcularEdad.TabIndex = 7;
            this.btnCalcularEdad.Text = "Verificar edad";
            this.btnCalcularEdad.UseVisualStyleBackColor = true;
            this.btnCalcularEdad.Click += new System.EventHandler(this.btnCalcularEdad_Click);
            // 
            // cbCiudades
            // 
            this.cbCiudades.FormattingEnabled = true;
            this.cbCiudades.Items.AddRange(new object[] {
            "Managua",
            "Masaya",
            "Granada",
            "Boaco",
            "Carazo",
            "Chinandega",
            "Chontales",
            "Esteli",
            "Jinotega",
            "Leon",
            "Madriz",
            "Matagalpa",
            "Nueva Segovia",
            "Rivas",
            "Rio San Juan"});
            this.cbCiudades.Location = new System.Drawing.Point(207, 191);
            this.cbCiudades.Name = "cbCiudades";
            this.cbCiudades.Size = new System.Drawing.Size(212, 24);
            this.cbCiudades.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Escoga su ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el nombre";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(207, 147);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(212, 22);
            this.dtpBirthday.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCiudades);
            this.Controls.Add(this.btnCalcularEdad);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombres);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnCalcularEdad;
        private System.Windows.Forms.ComboBox cbCiudades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
    }
}

