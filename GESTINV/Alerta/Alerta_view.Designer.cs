namespace Vista.Alerta
{
    partial class Alerta
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
            this.lbNombre = new MaterialSkin.Controls.MaterialLabel();
            this.lbId = new MaterialSkin.Controls.MaterialLabel();
            this.lbPrecio = new MaterialSkin.Controls.MaterialLabel();
            this.lbStock = new MaterialSkin.Controls.MaterialLabel();
            this.lbStockMin = new MaterialSkin.Controls.MaterialLabel();
            this.lbCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Depth = 0;
            this.lbNombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNombre.Location = new System.Drawing.Point(90, 135);
            this.lbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 24);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "nombre";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Depth = 0;
            this.lbId.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbId.Location = new System.Drawing.Point(309, 135);
            this.lbId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 24);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Depth = 0;
            this.lbPrecio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPrecio.Location = new System.Drawing.Point(90, 226);
            this.lbPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(63, 24);
            this.lbPrecio.TabIndex = 2;
            this.lbPrecio.Text = "precio";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Depth = 0;
            this.lbStock.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStock.Location = new System.Drawing.Point(309, 226);
            this.lbStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(58, 24);
            this.lbStock.TabIndex = 3;
            this.lbStock.Text = "Stock";
            // 
            // lbStockMin
            // 
            this.lbStockMin.AutoSize = true;
            this.lbStockMin.Depth = 0;
            this.lbStockMin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbStockMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStockMin.Location = new System.Drawing.Point(90, 322);
            this.lbStockMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbStockMin.Name = "lbStockMin";
            this.lbStockMin.Size = new System.Drawing.Size(128, 24);
            this.lbStockMin.TabIndex = 4;
            this.lbStockMin.Text = "Stock mínimo";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Depth = 0;
            this.lbCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCategoria.Location = new System.Drawing.Point(309, 322);
            this.lbCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(91, 24);
            this.lbCategoria.TabIndex = 5;
            this.lbCategoria.Text = "Categoria";
            // 
            // Alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 478);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbStockMin);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Alerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbNombre;
        private MaterialSkin.Controls.MaterialLabel lbId;
        private MaterialSkin.Controls.MaterialLabel lbPrecio;
        private MaterialSkin.Controls.MaterialLabel lbStock;
        private MaterialSkin.Controls.MaterialLabel lbStockMin;
        private MaterialSkin.Controls.MaterialLabel lbCategoria;
    }
}