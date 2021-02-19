
namespace Navegador._2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonAdelante = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.VentanaGoogle = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(710, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(0, 2);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(75, 23);
            this.botonAtras.TabIndex = 1;
            this.botonAtras.Text = "<<";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonAdelante
            // 
            this.botonAdelante.Location = new System.Drawing.Point(81, 2);
            this.botonAdelante.Name = "botonAdelante";
            this.botonAdelante.Size = new System.Drawing.Size(75, 23);
            this.botonAdelante.TabIndex = 2;
            this.botonAdelante.Text = ">>";
            this.botonAdelante.UseVisualStyleBackColor = true;
            this.botonAdelante.Click += new System.EventHandler(this.botonAdelante_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(878, 0);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Ir";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // VentanaGoogle
            // 
            this.VentanaGoogle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VentanaGoogle.Location = new System.Drawing.Point(0, 29);
            this.VentanaGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.VentanaGoogle.Name = "VentanaGoogle";
            this.VentanaGoogle.Size = new System.Drawing.Size(1031, 409);
            this.VentanaGoogle.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.VentanaGoogle);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonAdelante);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonAdelante;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.WebBrowser VentanaGoogle;
    }
}

