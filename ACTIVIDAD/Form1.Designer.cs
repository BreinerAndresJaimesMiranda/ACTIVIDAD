
namespace ACTIVIDAD
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
            this.BotonConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonConectar
            // 
            this.BotonConectar.Location = new System.Drawing.Point(202, 126);
            this.BotonConectar.Name = "BotonConectar";
            this.BotonConectar.Size = new System.Drawing.Size(176, 108);
            this.BotonConectar.TabIndex = 0;
            this.BotonConectar.Text = "CONECTAR";
            this.BotonConectar.UseVisualStyleBackColor = true;
            this.BotonConectar.Click += new System.EventHandler(this.BotonConectar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 375);
            this.Controls.Add(this.BotonConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonConectar;
    }
}

