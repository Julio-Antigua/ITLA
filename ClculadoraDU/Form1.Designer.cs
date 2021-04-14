
namespace ClculadoraDU
{
    partial class Calculadora
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnN7 = new System.Windows.Forms.Button();
            this.btnN8 = new System.Windows.Forms.Button();
            this.btnN9 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnN4 = new System.Windows.Forms.Button();
            this.btnN5 = new System.Windows.Forms.Button();
            this.btnN6 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnN1 = new System.Windows.Forms.Button();
            this.btnN2 = new System.Windows.Forms.Button();
            this.btnN3 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnN0 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.txtIntroducir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Orange;
            this.btnSuma.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(13, 107);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(45, 45);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnResta.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(64, 106);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(45, 45);
            this.btnResta.TabIndex = 1;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.Crimson;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(115, 107);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(45, 45);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDivision.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(166, 106);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(45, 45);
            this.btnDivision.TabIndex = 3;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnN7
            // 
            this.btnN7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN7.Location = new System.Drawing.Point(13, 157);
            this.btnN7.Name = "btnN7";
            this.btnN7.Size = new System.Drawing.Size(45, 45);
            this.btnN7.TabIndex = 4;
            this.btnN7.Text = "7";
            this.btnN7.UseVisualStyleBackColor = true;
            this.btnN7.Click += new System.EventHandler(this.btnN7_Click);
            // 
            // btnN8
            // 
            this.btnN8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN8.Location = new System.Drawing.Point(64, 157);
            this.btnN8.Name = "btnN8";
            this.btnN8.Size = new System.Drawing.Size(45, 45);
            this.btnN8.TabIndex = 5;
            this.btnN8.Text = "8";
            this.btnN8.UseVisualStyleBackColor = true;
            this.btnN8.Click += new System.EventHandler(this.btnN8_Click);
            // 
            // btnN9
            // 
            this.btnN9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN9.Location = new System.Drawing.Point(115, 156);
            this.btnN9.Name = "btnN9";
            this.btnN9.Size = new System.Drawing.Size(45, 45);
            this.btnN9.TabIndex = 6;
            this.btnN9.Text = "9";
            this.btnN9.UseVisualStyleBackColor = true;
            this.btnN9.Click += new System.EventHandler(this.btnN9_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(166, 204);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 45);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "CE";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnN4
            // 
            this.btnN4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN4.Location = new System.Drawing.Point(13, 207);
            this.btnN4.Name = "btnN4";
            this.btnN4.Size = new System.Drawing.Size(45, 45);
            this.btnN4.TabIndex = 8;
            this.btnN4.Text = "4";
            this.btnN4.UseVisualStyleBackColor = true;
            this.btnN4.Click += new System.EventHandler(this.btnN4_Click);
            // 
            // btnN5
            // 
            this.btnN5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN5.Location = new System.Drawing.Point(64, 207);
            this.btnN5.Name = "btnN5";
            this.btnN5.Size = new System.Drawing.Size(45, 45);
            this.btnN5.TabIndex = 9;
            this.btnN5.Text = "5";
            this.btnN5.UseVisualStyleBackColor = true;
            this.btnN5.Click += new System.EventHandler(this.btnN5_Click);
            // 
            // btnN6
            // 
            this.btnN6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN6.Location = new System.Drawing.Point(115, 208);
            this.btnN6.Name = "btnN6";
            this.btnN6.Size = new System.Drawing.Size(45, 45);
            this.btnN6.TabIndex = 10;
            this.btnN6.Text = "6";
            this.btnN6.UseVisualStyleBackColor = true;
            this.btnN6.Click += new System.EventHandler(this.btnN6_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(166, 153);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 45);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "←";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnN1
            // 
            this.btnN1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN1.Location = new System.Drawing.Point(13, 257);
            this.btnN1.Name = "btnN1";
            this.btnN1.Size = new System.Drawing.Size(45, 45);
            this.btnN1.TabIndex = 12;
            this.btnN1.Text = "1";
            this.btnN1.UseVisualStyleBackColor = true;
            this.btnN1.Click += new System.EventHandler(this.btnN1_Click);
            // 
            // btnN2
            // 
            this.btnN2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2.Location = new System.Drawing.Point(64, 258);
            this.btnN2.Name = "btnN2";
            this.btnN2.Size = new System.Drawing.Size(45, 45);
            this.btnN2.TabIndex = 13;
            this.btnN2.Text = "2";
            this.btnN2.UseVisualStyleBackColor = true;
            this.btnN2.Click += new System.EventHandler(this.btnN2_Click);
            // 
            // btnN3
            // 
            this.btnN3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3.Location = new System.Drawing.Point(115, 257);
            this.btnN3.Name = "btnN3";
            this.btnN3.Size = new System.Drawing.Size(45, 45);
            this.btnN3.TabIndex = 14;
            this.btnN3.Text = "3";
            this.btnN3.UseVisualStyleBackColor = true;
            this.btnN3.Click += new System.EventHandler(this.btnN3_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(166, 255);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(45, 96);
            this.btnIgual.TabIndex = 16;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnN0
            // 
            this.btnN0.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN0.Location = new System.Drawing.Point(12, 306);
            this.btnN0.Name = "btnN0";
            this.btnN0.Size = new System.Drawing.Size(97, 45);
            this.btnN0.TabIndex = 17;
            this.btnN0.Text = "0";
            this.btnN0.UseVisualStyleBackColor = true;
            this.btnN0.Click += new System.EventHandler(this.btnN0_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(115, 306);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(45, 45);
            this.btnPunto.TabIndex = 18;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // txtIntroducir
            // 
            this.txtIntroducir.Font = new System.Drawing.Font("Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtIntroducir.ForeColor = System.Drawing.Color.Black;
            this.txtIntroducir.HideSelection = false;
            this.txtIntroducir.Location = new System.Drawing.Point(13, 58);
            this.txtIntroducir.Name = "txtIntroducir";
            this.txtIntroducir.ReadOnly = true;
            this.txtIntroducir.Size = new System.Drawing.Size(198, 26);
            this.txtIntroducir.TabIndex = 19;
            this.txtIntroducir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "CALCULADORA JA-T2";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(13, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(66, 22);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(225, 364);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntroducir);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnN0);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnN3);
            this.Controls.Add(this.btnN2);
            this.Controls.Add(this.btnN1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnN6);
            this.Controls.Add(this.btnN5);
            this.Controls.Add(this.btnN4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnN9);
            this.Controls.Add(this.btnN8);
            this.Controls.Add(this.btnN7);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnN7;
        private System.Windows.Forms.Button btnN8;
        private System.Windows.Forms.Button btnN9;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnN4;
        private System.Windows.Forms.Button btnN5;
        private System.Windows.Forms.Button btnN6;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnN1;
        private System.Windows.Forms.Button btnN2;
        private System.Windows.Forms.Button btnN3;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnN0;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.TextBox txtIntroducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
    }
}

