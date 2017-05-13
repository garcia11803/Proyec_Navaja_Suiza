namespace Proyec_Navaja_Suiza.Palindromica
{/// <summary>
/// Creamos esta clase que nos servira para saber si una palabra es palindromica
/// </summary>
    partial class Palindromica
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
            this.bComprueva = new System.Windows.Forms.Button();
            this.tPalabra = new System.Windows.Forms.TextBox();
            this.lPalabra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bComprueva
            // 
            this.bComprueva.BackColor = System.Drawing.Color.Silver;
            this.bComprueva.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bComprueva.Location = new System.Drawing.Point(92, 172);
            this.bComprueva.Name = "bComprueva";
            this.bComprueva.Size = new System.Drawing.Size(139, 56);
            this.bComprueva.TabIndex = 0;
            this.bComprueva.Text = "Comprovar";
            this.bComprueva.UseVisualStyleBackColor = false;
            this.bComprueva.Click += new System.EventHandler(this.bComprueva_Click);
            // 
            // tPalabra
            // 
            this.tPalabra.Location = new System.Drawing.Point(179, 65);
            this.tPalabra.Name = "tPalabra";
            this.tPalabra.Size = new System.Drawing.Size(100, 20);
            this.tPalabra.TabIndex = 1;
            // 
            // lPalabra
            // 
            this.lPalabra.AutoSize = true;
            this.lPalabra.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPalabra.Location = new System.Drawing.Point(12, 67);
            this.lPalabra.Name = "lPalabra";
            this.lPalabra.Size = new System.Drawing.Size(149, 18);
            this.lPalabra.TabIndex = 2;
            this.lPalabra.Text = "Comprueva la palabra: ";
            // 
            // Palindromica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(331, 326);
            this.Controls.Add(this.lPalabra);
            this.Controls.Add(this.tPalabra);
            this.Controls.Add(this.bComprueva);
            this.Name = "Palindromica";
            this.Text = "Es palindromica esta palabra?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bComprueva;
        private System.Windows.Forms.TextBox tPalabra;
        private System.Windows.Forms.Label lPalabra;
    }
}

