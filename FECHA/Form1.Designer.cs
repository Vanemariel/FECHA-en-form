
namespace FECHA
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
            this.dia = new System.Windows.Forms.Label();
            this.mes = new System.Windows.Forms.Label();
            this.año = new System.Windows.Forms.Label();
            this.Carga = new System.Windows.Forms.Button();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.txtaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dia
            // 
            this.dia.AutoSize = true;
            this.dia.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dia.Location = new System.Drawing.Point(38, 55);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(197, 27);
            this.dia.TabIndex = 0;
            this.dia.Text = "Ingresa un dia";
            // 
            // mes
            // 
            this.mes.AutoSize = true;
            this.mes.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mes.Location = new System.Drawing.Point(38, 125);
            this.mes.Name = "mes";
            this.mes.Size = new System.Drawing.Size(204, 27);
            this.mes.TabIndex = 1;
            this.mes.Text = "Ingresa un mes";
            // 
            // año
            // 
            this.año.AutoSize = true;
            this.año.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.año.Location = new System.Drawing.Point(48, 199);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(194, 27);
            this.año.TabIndex = 2;
            this.año.Text = "Ingrese el año";
            // 
            // Carga
            // 
            this.Carga.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carga.Location = new System.Drawing.Point(603, 125);
            this.Carga.Name = "Carga";
            this.Carga.Size = new System.Drawing.Size(122, 59);
            this.Carga.TabIndex = 3;
            this.Carga.Text = "Cargar";
            this.Carga.UseVisualStyleBackColor = true;
            this.Carga.Click += new System.EventHandler(this.Carga_Click);
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(316, 62);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(205, 20);
            this.txtdia.TabIndex = 4;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(316, 129);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(205, 20);
            this.txtmes.TabIndex = 5;
            // 
            // txtaño
            // 
            this.txtaño.Location = new System.Drawing.Point(316, 206);
            this.txtaño.Name = "txtaño";
            this.txtaño.Size = new System.Drawing.Size(205, 20);
            this.txtaño.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaño);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.Carga);
            this.Controls.Add(this.año);
            this.Controls.Add(this.mes);
            this.Controls.Add(this.dia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dia;
        private System.Windows.Forms.Label mes;
        private System.Windows.Forms.Label año;
        private System.Windows.Forms.Button Carga;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.TextBox txtaño;
        private System.Windows.Forms.Label label1;
    }
}

