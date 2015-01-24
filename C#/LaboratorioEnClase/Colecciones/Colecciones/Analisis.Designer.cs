namespace Colecciones
{
    partial class Analisis
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
            this.grillaCotizaciones = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCotizaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaCotizaciones
            // 
            this.grillaCotizaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grillaCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grillaCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCotizaciones.Location = new System.Drawing.Point(13, 65);
            this.grillaCotizaciones.Name = "grillaCotizaciones";
            this.grillaCotizaciones.Size = new System.Drawing.Size(474, 239);
            this.grillaCotizaciones.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(412, 310);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Máximo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mínimo:";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(64, 12);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.ReadOnly = true;
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 4;
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(64, 39);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.ReadOnly = true;
            this.txtMinimo.Size = new System.Drawing.Size(100, 20);
            this.txtMinimo.TabIndex = 5;
            // 
            // Analisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 345);
            this.ControlBox = false;
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.txtMaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.grillaCotizaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Analisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analisis";
            this.Load += new System.EventHandler(this.Analisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCotizaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaCotizaciones;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtMinimo;
    }
}