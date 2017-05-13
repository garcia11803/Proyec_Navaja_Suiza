namespace Proyec_Navaja_Suiza.Sumanumeros
{/// <summary>
///     Aplicacion para sumar dos numeros
/// </summary>
    partial class Sumanumeros
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
            this.bCalcula = new System.Windows.Forms.Button();
            this.tNumero1 = new System.Windows.Forms.TextBox();
            this.tNumero2 = new System.Windows.Forms.TextBox();
            this.lNumero1 = new System.Windows.Forms.Label();
            this.lNumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCalcula
            // 
            this.bCalcula.BackColor = System.Drawing.Color.Silver;
            this.bCalcula.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcula.Location = new System.Drawing.Point(117, 203);
            this.bCalcula.Name = "bCalcula";
            this.bCalcula.Size = new System.Drawing.Size(128, 49);
            this.bCalcula.TabIndex = 0;
            this.bCalcula.Text = "Calcula";
            this.bCalcula.UseVisualStyleBackColor = false;
            this.bCalcula.Click += new System.EventHandler(this.bCalcula_Click);
            // 
            // tNumero1
            // 
            this.tNumero1.Location = new System.Drawing.Point(161, 43);
            this.tNumero1.Name = "tNumero1";
            this.tNumero1.Size = new System.Drawing.Size(100, 20);
            this.tNumero1.TabIndex = 1;
            this.tNumero1.TextChanged += new System.EventHandler(this.tNumero1_TextChanged);
            // 
            // tNumero2
            // 
            this.tNumero2.Location = new System.Drawing.Point(161, 99);
            this.tNumero2.Name = "tNumero2";
            this.tNumero2.Size = new System.Drawing.Size(100, 20);
            this.tNumero2.TabIndex = 2;
            this.tNumero2.TextChanged += new System.EventHandler(this.tNumero2_TextChanged);
            // 
            // lNumero1
            // 
            this.lNumero1.AutoSize = true;
            this.lNumero1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero1.Location = new System.Drawing.Point(24, 49);
            this.lNumero1.Name = "lNumero1";
            this.lNumero1.Size = new System.Drawing.Size(68, 18);
            this.lNumero1.TabIndex = 3;
            this.lNumero1.Text = "Numero 1";
            // 
            // lNumero2
            // 
            this.lNumero2.AutoSize = true;
            this.lNumero2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero2.Location = new System.Drawing.Point(27, 105);
            this.lNumero2.Name = "lNumero2";
            this.lNumero2.Size = new System.Drawing.Size(68, 18);
            this.lNumero2.TabIndex = 4;
            this.lNumero2.Text = "Numero 2";
            // 
            // Sumanumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(423, 378);
            this.Controls.Add(this.lNumero2);
            this.Controls.Add(this.lNumero1);
            this.Controls.Add(this.tNumero2);
            this.Controls.Add(this.tNumero1);
            this.Controls.Add(this.bCalcula);
            this.Name = "Sumanumeros";
            this.Text = "Suma dos numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcula;
        private System.Windows.Forms.TextBox tNumero1;
        private System.Windows.Forms.TextBox tNumero2;
        private System.Windows.Forms.Label lNumero1;
        private System.Windows.Forms.Label lNumero2;
    }
}

