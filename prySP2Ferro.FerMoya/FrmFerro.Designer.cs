namespace prySP2Ferro.FerMoya
{
    partial class FrmFerroCalculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFerroCalculo));
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.mrcCostos = new System.Windows.Forms.GroupBox();
            this.lblTotalNumero = new System.Windows.Forms.Label();
            this.lblNumPrecio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.mrcCostos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(20, 48);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 15);
            this.lblDias.TabIndex = 0;
            this.lblDias.Text = "Dias";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(20, 95);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 15);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia";
            // 
            // mrcCostos
            // 
            this.mrcCostos.Controls.Add(this.lblTotalNumero);
            this.mrcCostos.Controls.Add(this.lblNumPrecio);
            this.mrcCostos.Controls.Add(this.lblTotal);
            this.mrcCostos.Controls.Add(this.lblPrecio);
            this.mrcCostos.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcCostos.Location = new System.Drawing.Point(23, 153);
            this.mrcCostos.Name = "mrcCostos";
            this.mrcCostos.Size = new System.Drawing.Size(363, 127);
            this.mrcCostos.TabIndex = 2;
            this.mrcCostos.TabStop = false;
            this.mrcCostos.Text = "Costos";
            // 
            // lblTotalNumero
            // 
            this.lblTotalNumero.AutoSize = true;
            this.lblTotalNumero.Location = new System.Drawing.Point(177, 38);
            this.lblTotalNumero.Name = "lblTotalNumero";
            this.lblTotalNumero.Size = new System.Drawing.Size(56, 15);
            this.lblTotalNumero.TabIndex = 3;
            this.lblTotalNumero.Text = "_______";
            this.lblTotalNumero.Click += new System.EventHandler(this.lblTotalNumero_Click);
            // 
            // lblNumPrecio
            // 
            this.lblNumPrecio.AutoSize = true;
            this.lblNumPrecio.Location = new System.Drawing.Point(177, 83);
            this.lblNumPrecio.Name = "lblNumPrecio";
            this.lblNumPrecio.Size = new System.Drawing.Size(56, 15);
            this.lblNumPrecio.TabIndex = 2;
            this.lblNumPrecio.Text = "_______";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(78, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 15);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(78, 38);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 15);
            this.lblPrecio.TabIndex = 0;
            this.lblPrecio.Text = "Precio por Km";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(104, 92);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 20);
            this.txtDistancia.TabIndex = 4;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(104, 46);
            this.nudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(100, 20);
            this.nudDias.TabIndex = 5;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmFerroCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(507, 343);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.mrcCostos);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFerroCalculo";
            this.Text = "Ferro - Calculo";
            this.mrcCostos.ResumeLayout(false);
            this.mrcCostos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.GroupBox mrcCostos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Label lblNumPrecio;
        private System.Windows.Forms.Label lblTotalNumero;
    }
}

