namespace MapReduceERP
{
    partial class FrmMain
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
            this.btnObrirArxiu1 = new System.Windows.Forms.Button();
            this.btnObrirArxiu2 = new System.Windows.Forms.Button();
            this.btnObrirArxiu3 = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tbArxiu1 = new System.Windows.Forms.TextBox();
            this.tbArxiu2 = new System.Windows.Forms.TextBox();
            this.tbArxiu3 = new System.Windows.Forms.TextBox();
            this.lbTitol = new System.Windows.Forms.Label();
            this.lbLlistaCompletaParaules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnObrirArxiu1
            // 
            this.btnObrirArxiu1.Location = new System.Drawing.Point(246, 58);
            this.btnObrirArxiu1.Name = "btnObrirArxiu1";
            this.btnObrirArxiu1.Size = new System.Drawing.Size(159, 23);
            this.btnObrirArxiu1.TabIndex = 0;
            this.btnObrirArxiu1.Text = "Buscar Arxiu 1";
            this.btnObrirArxiu1.UseVisualStyleBackColor = true;
            this.btnObrirArxiu1.Click += new System.EventHandler(this.btnObrirArxiu1_Click);
            // 
            // btnObrirArxiu2
            // 
            this.btnObrirArxiu2.Location = new System.Drawing.Point(246, 161);
            this.btnObrirArxiu2.Name = "btnObrirArxiu2";
            this.btnObrirArxiu2.Size = new System.Drawing.Size(159, 23);
            this.btnObrirArxiu2.TabIndex = 1;
            this.btnObrirArxiu2.Text = "Buscar Arxiu 2";
            this.btnObrirArxiu2.UseVisualStyleBackColor = true;
            this.btnObrirArxiu2.Click += new System.EventHandler(this.btnObrirArxiu2_Click);
            // 
            // btnObrirArxiu3
            // 
            this.btnObrirArxiu3.Location = new System.Drawing.Point(246, 264);
            this.btnObrirArxiu3.Name = "btnObrirArxiu3";
            this.btnObrirArxiu3.Size = new System.Drawing.Size(159, 23);
            this.btnObrirArxiu3.TabIndex = 2;
            this.btnObrirArxiu3.Text = "Buscar Arxiu 3";
            this.btnObrirArxiu3.UseVisualStyleBackColor = true;
            this.btnObrirArxiu3.Click += new System.EventHandler(this.btnObrirArxiu3_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(421, 150);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(99, 45);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Reduce";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tbArxiu1
            // 
            this.tbArxiu1.Location = new System.Drawing.Point(41, 58);
            this.tbArxiu1.Name = "tbArxiu1";
            this.tbArxiu1.Size = new System.Drawing.Size(185, 22);
            this.tbArxiu1.TabIndex = 4;
            // 
            // tbArxiu2
            // 
            this.tbArxiu2.Location = new System.Drawing.Point(41, 162);
            this.tbArxiu2.Name = "tbArxiu2";
            this.tbArxiu2.Size = new System.Drawing.Size(185, 22);
            this.tbArxiu2.TabIndex = 5;
            // 
            // tbArxiu3
            // 
            this.tbArxiu3.Location = new System.Drawing.Point(41, 264);
            this.tbArxiu3.Name = "tbArxiu3";
            this.tbArxiu3.Size = new System.Drawing.Size(185, 22);
            this.tbArxiu3.TabIndex = 6;
            // 
            // lbTitol
            // 
            this.lbTitol.AutoSize = true;
            this.lbTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitol.Location = new System.Drawing.Point(203, 9);
            this.lbTitol.Name = "lbTitol";
            this.lbTitol.Size = new System.Drawing.Size(246, 39);
            this.lbTitol.TabIndex = 7;
            this.lbTitol.Text = "MAP REDUCE";
            // 
            // lbLlistaCompletaParaules
            // 
            this.lbLlistaCompletaParaules.FormattingEnabled = true;
            this.lbLlistaCompletaParaules.ItemHeight = 16;
            this.lbLlistaCompletaParaules.Location = new System.Drawing.Point(526, 12);
            this.lbLlistaCompletaParaules.Name = "lbLlistaCompletaParaules";
            this.lbLlistaCompletaParaules.Size = new System.Drawing.Size(229, 308);
            this.lbLlistaCompletaParaules.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 337);
            this.Controls.Add(this.lbLlistaCompletaParaules);
            this.Controls.Add(this.lbTitol);
            this.Controls.Add(this.tbArxiu3);
            this.Controls.Add(this.tbArxiu2);
            this.Controls.Add(this.tbArxiu1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnObrirArxiu3);
            this.Controls.Add(this.btnObrirArxiu2);
            this.Controls.Add(this.btnObrirArxiu1);
            this.Name = "FrmMain";
            this.Text = "Map Reduce Marc Llorca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrirArxiu1;
        private System.Windows.Forms.Button btnObrirArxiu2;
        private System.Windows.Forms.Button btnObrirArxiu3;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox tbArxiu1;
        private System.Windows.Forms.TextBox tbArxiu2;
        private System.Windows.Forms.TextBox tbArxiu3;
        private System.Windows.Forms.Label lbTitol;
        private System.Windows.Forms.ListBox lbLlistaCompletaParaules;
    }
}

