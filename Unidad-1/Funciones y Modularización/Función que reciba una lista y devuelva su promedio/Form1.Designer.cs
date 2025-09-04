namespace Función_que_reciba_una_lista_y_devuelva_su_promedio
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
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.listaNumeros = new System.Windows.Forms.ListBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(3, 186);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(100, 40);
            this.btnPromedio.TabIndex = 1;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.Location = new System.Drawing.Point(-6, 135);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(109, 45);
            this.btnAgregarNumero.TabIndex = 2;
            this.btnAgregarNumero.Text = "Agregar Numero";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            this.btnAgregarNumero.Click += new System.EventHandler(this.btnAgregarNumero_Click);
            // 
            // listaNumeros
            // 
            this.listaNumeros.FormattingEnabled = true;
            this.listaNumeros.ItemHeight = 16;
            this.listaNumeros.Location = new System.Drawing.Point(118, 39);
            this.listaNumeros.Name = "listaNumeros";
            this.listaNumeros.Size = new System.Drawing.Size(159, 276);
            this.listaNumeros.TabIndex = 3;
            this.listaNumeros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(3, 85);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 34);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 321);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.listaNumeros);
            this.Controls.Add(this.btnAgregarNumero);
            this.Controls.Add(this.btnPromedio);
            this.Name = "Form1";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.ListBox listaNumeros;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

