namespace Clase_Coche_Forms
{
    partial class Form1
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
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.btnAcelerar = new System.Windows.Forms.Button();
            this.btnFrenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Location = new System.Drawing.Point(26, 71);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(72, 16);
            this.lblVelocidad.TabIndex = 0;
            this.lblVelocidad.Text = "Velocidad:";
            // 
            // btnAcelerar
            // 
            this.btnAcelerar.Location = new System.Drawing.Point(12, 199);
            this.btnAcelerar.Name = "btnAcelerar";
            this.btnAcelerar.Size = new System.Drawing.Size(115, 52);
            this.btnAcelerar.TabIndex = 1;
            this.btnAcelerar.Text = "Acelerar";
            this.btnAcelerar.UseVisualStyleBackColor = true;
            this.btnAcelerar.Click += new System.EventHandler(this.btnAcelerar_Click);
            // 
            // btnFrenar
            // 
            this.btnFrenar.Location = new System.Drawing.Point(142, 199);
            this.btnFrenar.Name = "btnFrenar";
            this.btnFrenar.Size = new System.Drawing.Size(126, 52);
            this.btnFrenar.TabIndex = 2;
            this.btnFrenar.Text = "Frenar";
            this.btnFrenar.UseVisualStyleBackColor = true;
            this.btnFrenar.Click += new System.EventHandler(this.btnFrenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 254);
            this.Controls.Add(this.btnFrenar);
            this.Controls.Add(this.btnAcelerar);
            this.Controls.Add(this.lblVelocidad);
            this.Name = "Form1";
            this.Text = "Coche";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Button btnAcelerar;
        private System.Windows.Forms.Button btnFrenar;
    }
}

