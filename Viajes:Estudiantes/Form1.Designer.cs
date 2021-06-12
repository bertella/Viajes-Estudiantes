
namespace ViajesBotta
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistraViaje = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtNumViaje = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculaTotal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcPorcent = new System.Windows.Forms.Button();
            this.btnRegistraEstudiante = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.lblCostoTotal = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegistraViaje
            // 
            this.btnRegistraViaje.Location = new System.Drawing.Point(149, 215);
            this.btnRegistraViaje.Name = "btnRegistraViaje";
            this.btnRegistraViaje.Size = new System.Drawing.Size(97, 43);
            this.btnRegistraViaje.TabIndex = 0;
            this.btnRegistraViaje.Text = "Registrar Viaje";
            this.btnRegistraViaje.UseVisualStyleBackColor = true;
            this.btnRegistraViaje.Click += new System.EventHandler(this.btnRegistraViaje_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(149, 90);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(106, 23);
            this.txtDestino.TabIndex = 1;
            // 
            // txtNumViaje
            // 
            this.txtNumViaje.Location = new System.Drawing.Point(149, 40);
            this.txtNumViaje.Name = "txtNumViaje";
            this.txtNumViaje.Size = new System.Drawing.Size(106, 23);
            this.txtNumViaje.TabIndex = 2;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(149, 134);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(106, 23);
            this.txtCosto.TabIndex = 3;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(529, 134);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(106, 23);
            this.txtEdad.TabIndex = 6;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(529, 40);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(106, 23);
            this.txtLegajo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(529, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(106, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lugar Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Costo Unitario";
            // 
            // btnCalculaTotal
            // 
            this.btnCalculaTotal.Location = new System.Drawing.Point(149, 275);
            this.btnCalculaTotal.Name = "btnCalculaTotal";
            this.btnCalculaTotal.Size = new System.Drawing.Size(97, 43);
            this.btnCalculaTotal.TabIndex = 10;
            this.btnCalculaTotal.Text = "Calcula Total";
            this.btnCalculaTotal.UseVisualStyleBackColor = true;
            this.btnCalculaTotal.Click += new System.EventHandler(this.btnCalculaTotal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Legajo";
            // 
            // btnCalcPorcent
            // 
            this.btnCalcPorcent.Location = new System.Drawing.Point(544, 350);
            this.btnCalcPorcent.Name = "btnCalcPorcent";
            this.btnCalcPorcent.Size = new System.Drawing.Size(97, 43);
            this.btnCalcPorcent.TabIndex = 15;
            this.btnCalcPorcent.Text = "Calcular Porcentaje";
            this.btnCalcPorcent.UseVisualStyleBackColor = true;
            this.btnCalcPorcent.Click += new System.EventHandler(this.btnCalcPorcent_Click);
            // 
            // btnRegistraEstudiante
            // 
            this.btnRegistraEstudiante.Location = new System.Drawing.Point(544, 289);
            this.btnRegistraEstudiante.Name = "btnRegistraEstudiante";
            this.btnRegistraEstudiante.Size = new System.Drawing.Size(97, 43);
            this.btnRegistraEstudiante.TabIndex = 14;
            this.btnRegistraEstudiante.Text = "Registrar Estudiante";
            this.btnRegistraEstudiante.UseVisualStyleBackColor = true;
            this.btnRegistraEstudiante.Click += new System.EventHandler(this.btnRegistraEstudiante_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sexo";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(556, 239);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(80, 19);
            this.rbtMasculino.TabIndex = 17;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(556, 264);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(78, 19);
            this.rbtFemenino.TabIndex = 19;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // lblCostoTotal
            // 
            this.lblCostoTotal.AutoSize = true;
            this.lblCostoTotal.Location = new System.Drawing.Point(149, 365);
            this.lblCostoTotal.Name = "lblCostoTotal";
            this.lblCostoTotal.Size = new System.Drawing.Size(13, 15);
            this.lblCostoTotal.TabIndex = 20;
            this.lblCostoTotal.Text = "$";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(544, 412);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(17, 15);
            this.lblPorcentaje.TabIndex = 21;
            this.lblPorcentaje.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Promedio";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(530, 176);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(106, 23);
            this.txtPromedio.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblCostoTotal);
            this.Controls.Add(this.rbtFemenino);
            this.Controls.Add(this.rbtMasculino);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcPorcent);
            this.Controls.Add(this.btnRegistraEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalculaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtNumViaje);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.btnRegistraViaje);
            this.Name = "Form1";
            this.Text = "Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistraViaje;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtNumViaje;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculaTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcPorcent;
        private System.Windows.Forms.Button btnRegistraEstudiante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Label lblCostoTotal;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPromedio;
    }
}

