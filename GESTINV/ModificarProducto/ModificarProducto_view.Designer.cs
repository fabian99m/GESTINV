namespace Vista.ModificarProducto
{
    partial class ModificarProducto_view
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
            this.TextID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextStockMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GuardarDatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // TextID
            // 
            this.TextID.Depth = 0;
            this.TextID.Hint = "";
            this.TextID.Location = new System.Drawing.Point(63, 127);
            this.TextID.MaxLength = 32767;
            this.TextID.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextID.Name = "TextID";
            this.TextID.PasswordChar = '\0';
            this.TextID.SelectedText = "";
            this.TextID.SelectionLength = 0;
            this.TextID.SelectionStart = 0;
            this.TextID.Size = new System.Drawing.Size(142, 28);
            this.TextID.TabIndex = 0;
            this.TextID.TabStop = false;
            this.TextID.UseSystemPasswordChar = false;
            this.TextID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextID_KeyPress);
            // 
            // TextNombre
            // 
            this.TextNombre.Depth = 0;
            this.TextNombre.Hint = "Nombre";
            this.TextNombre.Location = new System.Drawing.Point(298, 127);
            this.TextNombre.MaxLength = 32767;
            this.TextNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.PasswordChar = '\0';
            this.TextNombre.SelectedText = "";
            this.TextNombre.SelectionLength = 0;
            this.TextNombre.SelectionStart = 0;
            this.TextNombre.Size = new System.Drawing.Size(164, 28);
            this.TextNombre.TabIndex = 1;
            this.TextNombre.TabStop = false;
            this.TextNombre.UseSystemPasswordChar = false;
            // 
            // TextPrecio
            // 
            this.TextPrecio.Depth = 0;
            this.TextPrecio.Hint = "Precio";
            this.TextPrecio.Location = new System.Drawing.Point(69, 223);
            this.TextPrecio.MaxLength = 32767;
            this.TextPrecio.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextPrecio.Name = "TextPrecio";
            this.TextPrecio.PasswordChar = '\0';
            this.TextPrecio.SelectedText = "";
            this.TextPrecio.SelectionLength = 0;
            this.TextPrecio.SelectionStart = 0;
            this.TextPrecio.Size = new System.Drawing.Size(136, 28);
            this.TextPrecio.TabIndex = 2;
            this.TextPrecio.TabStop = false;
            this.TextPrecio.UseSystemPasswordChar = false;
            this.TextPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPrecio_KeyPress);
            // 
            // TextStock
            // 
            this.TextStock.Depth = 0;
            this.TextStock.Hint = "Stock";
            this.TextStock.Location = new System.Drawing.Point(298, 223);
            this.TextStock.MaxLength = 32767;
            this.TextStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextStock.Name = "TextStock";
            this.TextStock.PasswordChar = '\0';
            this.TextStock.SelectedText = "";
            this.TextStock.SelectionLength = 0;
            this.TextStock.SelectionStart = 0;
            this.TextStock.Size = new System.Drawing.Size(164, 28);
            this.TextStock.TabIndex = 3;
            this.TextStock.TabStop = false;
            this.TextStock.UseSystemPasswordChar = false;
            this.TextStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStock_KeyPress);
            // 
            // TextCategoria
            // 
            this.TextCategoria.Depth = 0;
            this.TextCategoria.Hint = "Categoría";
            this.TextCategoria.Location = new System.Drawing.Point(298, 319);
            this.TextCategoria.MaxLength = 32767;
            this.TextCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextCategoria.Name = "TextCategoria";
            this.TextCategoria.PasswordChar = '\0';
            this.TextCategoria.SelectedText = "";
            this.TextCategoria.SelectionLength = 0;
            this.TextCategoria.SelectionStart = 0;
            this.TextCategoria.Size = new System.Drawing.Size(164, 28);
            this.TextCategoria.TabIndex = 4;
            this.TextCategoria.TabStop = false;
            this.TextCategoria.UseSystemPasswordChar = false;
            // 
            // TextStockMin
            // 
            this.TextStockMin.Depth = 0;
            this.TextStockMin.Hint = "Stock mínimo";
            this.TextStockMin.Location = new System.Drawing.Point(63, 319);
            this.TextStockMin.MaxLength = 32767;
            this.TextStockMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextStockMin.Name = "TextStockMin";
            this.TextStockMin.PasswordChar = '\0';
            this.TextStockMin.SelectedText = "";
            this.TextStockMin.SelectionLength = 0;
            this.TextStockMin.SelectionStart = 0;
            this.TextStockMin.Size = new System.Drawing.Size(158, 28);
            this.TextStockMin.TabIndex = 5;
            this.TextStockMin.TabStop = false;
            this.TextStockMin.UseSystemPasswordChar = false;
            this.TextStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStockMin_KeyPress);
            // 
            // GuardarDatos
            // 
            this.GuardarDatos.AutoSize = true;
            this.GuardarDatos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GuardarDatos.Depth = 0;
            this.GuardarDatos.Icon = null;
            this.GuardarDatos.Location = new System.Drawing.Point(176, 396);
            this.GuardarDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarDatos.Name = "GuardarDatos";
            this.GuardarDatos.Primary = true;
            this.GuardarDatos.Size = new System.Drawing.Size(160, 36);
            this.GuardarDatos.TabIndex = 6;
            this.GuardarDatos.Text = "Guardar datos";
            this.GuardarDatos.UseVisualStyleBackColor = true;
            this.GuardarDatos.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // ModificarProducto_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 489);
            this.Controls.Add(this.GuardarDatos);
            this.Controls.Add(this.TextStockMin);
            this.Controls.Add(this.TextCategoria);
            this.Controls.Add(this.TextStock);
            this.Controls.Add(this.TextPrecio);
            this.Controls.Add(this.TextNombre);
            this.Controls.Add(this.TextID);
            this.MaximizeBox = false;
            this.Name = "ModificarProducto_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.ModificarProducto_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextID;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextStockMin;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarDatos;
    }
}