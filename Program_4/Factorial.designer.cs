namespace Proyec_Navaja_Suiza.Factorial
{/// <summary>
/// Creamos la clase para la comprovacion de su uso del numero introducido, 
/// calculam,os su factorial.
/// </summary>
    partial class Factorial
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
            this.tNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCalcula
            // 
            this.bCalcula.BackColor = System.Drawing.Color.Silver;
            this.bCalcula.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcula.Location = new System.Drawing.Point(102, 198);
            this.bCalcula.Name = "bCalcula";
            this.bCalcula.Size = new System.Drawing.Size(184, 71);
            this.bCalcula.TabIndex = 0;
            this.bCalcula.Text = "Calcular Factorial";
            this.bCalcula.UseVisualStyleBackColor = false;
            this.bCalcula.Click += new System.EventHandler(this.bCalcula_Click);
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(186, 103);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(100, 20);
            this.tNumero.TabIndex = 1;
            this.tNumero.TextChanged += new System.EventHandler(this.tNumero_TextChanged);
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero.Location = new System.Drawing.Point(33, 106);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(129, 18);
            this.lNumero.TabIndex = 2;
            this.lNumero.Text = "Introduce el numero";
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(439, 411);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.bCalcula);
            this.Name = "Factorial";
            this.Text = "Factorial de un numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcula;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Label lNumero;
    }
}

