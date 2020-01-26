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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProducto_view));
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextPrecio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextStockMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.GuardarDatos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // TextNombre
            // 
            this.TextNombre.Depth = 0;
            this.TextNombre.Hint = "";
            this.TextNombre.Location = new System.Drawing.Point(225, 120);
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
            this.TextPrecio.Hint = "";
            this.TextPrecio.Location = new System.Drawing.Point(231, 186);
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
            // TextCategoria
            // 
            this.TextCategoria.Depth = 0;
            this.TextCategoria.Hint = "";
            this.TextCategoria.Location = new System.Drawing.Point(225, 321);
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
            this.TextStockMin.Hint = "";
            this.TextStockMin.Location = new System.Drawing.Point(231, 261);
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
            this.GuardarDatos.Icon = ((System.Drawing.Image)(resources.GetObject("GuardarDatos.Icon")));
            this.GuardarDatos.Location = new System.Drawing.Point(150, 397);
            this.GuardarDatos.MouseState = MaterialSkin.MouseState.HOVER;
            this.GuardarDatos.Name = "GuardarDatos";
            this.GuardarDatos.Primary = true;
            this.GuardarDatos.Size = new System.Drawing.Size(188, 36);
            this.GuardarDatos.TabIndex = 6;
            this.GuardarDatos.Text = "Guardar datos";
            this.GuardarDatos.UseVisualStyleBackColor = true;
            this.GuardarDatos.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(77, 120);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 24);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Nombre";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(77, 186);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 24);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Precio";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(77, 265);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(128, 24);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Stock mínimo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(77, 325);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(91, 24);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Categoría";
            // 
            // ModificarProducto_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 489);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.GuardarDatos);
            this.Controls.Add(this.TextStockMin);
            this.Controls.Add(this.TextCategoria);
            this.Controls.Add(this.TextPrecio);
            this.Controls.Add(this.TextNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarProducto_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.ModificarProducto_view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextPrecio;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextStockMin;
        private MaterialSkin.Controls.MaterialRaisedButton GuardarDatos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}