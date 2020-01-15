namespace GESTINV
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.categoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.stockMin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.stock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.precio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialTabControl3 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Tab = new MaterialSkin.Controls.MaterialTabSelector();
            this.LabelUser = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.materialTabControl3.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Controls.Add(this.tabPage7);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(30, 139);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1162, 672);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialTabControl2);
            this.tabPage3.Controls.Add(this.materialTabSelector2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1154, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inventario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tabPage1);
            this.materialTabControl2.Controls.Add(this.tabPage2);
            this.materialTabControl2.Controls.Add(this.tabPage4);
            this.materialTabControl2.Controls.Add(this.tabPage5);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.Location = new System.Drawing.Point(17, 69);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1121, 551);
            this.materialTabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.categoria);
            this.tabPage1.Controls.Add(this.stockMin);
            this.tabPage1.Controls.Add(this.materialRaisedButton1);
            this.tabPage1.Controls.Add(this.stock);
            this.tabPage1.Controls.Add(this.precio);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.TextNombre);
            this.tabPage1.Controls.Add(this.TextId);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1113, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir producto";
            // 
            // categoria
            // 
            this.categoria.Depth = 0;
            this.categoria.Hint = "Categoría";
            this.categoria.Location = new System.Drawing.Point(716, 315);
            this.categoria.MaxLength = 32767;
            this.categoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.categoria.Name = "categoria";
            this.categoria.PasswordChar = '\0';
            this.categoria.SelectedText = "";
            this.categoria.SelectionLength = 0;
            this.categoria.SelectionStart = 0;
            this.categoria.Size = new System.Drawing.Size(316, 28);
            this.categoria.TabIndex = 9;
            this.categoria.TabStop = false;
            this.categoria.UseSystemPasswordChar = false;
            // 
            // stockMin
            // 
            this.stockMin.Depth = 0;
            this.stockMin.Hint = "Cantidad Mínima";
            this.stockMin.Location = new System.Drawing.Point(208, 315);
            this.stockMin.MaxLength = 32767;
            this.stockMin.MouseState = MaterialSkin.MouseState.HOVER;
            this.stockMin.Name = "stockMin";
            this.stockMin.PasswordChar = '\0';
            this.stockMin.SelectedText = "";
            this.stockMin.SelectionLength = 0;
            this.stockMin.SelectionStart = 0;
            this.stockMin.Size = new System.Drawing.Size(316, 28);
            this.stockMin.TabIndex = 8;
            this.stockMin.TabStop = false;
            this.stockMin.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(485, 414);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(100, 36);
            this.materialRaisedButton1.TabIndex = 7;
            this.materialRaisedButton1.Text = "Guardar";
            this.materialRaisedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.GuardarProductos_Click);
            // 
            // stock
            // 
            this.stock.Depth = 0;
            this.stock.Hint = "Cantidad en stock";
            this.stock.Location = new System.Drawing.Point(716, 221);
            this.stock.MaxLength = 32767;
            this.stock.MouseState = MaterialSkin.MouseState.HOVER;
            this.stock.Name = "stock";
            this.stock.PasswordChar = '\0';
            this.stock.SelectedText = "";
            this.stock.SelectionLength = 0;
            this.stock.SelectionStart = 0;
            this.stock.Size = new System.Drawing.Size(316, 28);
            this.stock.TabIndex = 6;
            this.stock.TabStop = false;
            this.stock.UseSystemPasswordChar = false;
            // 
            // precio
            // 
            this.precio.Depth = 0;
            this.precio.Hint = "Precio";
            this.precio.Location = new System.Drawing.Point(208, 221);
            this.precio.MaxLength = 32767;
            this.precio.MouseState = MaterialSkin.MouseState.HOVER;
            this.precio.Name = "precio";
            this.precio.PasswordChar = '\0';
            this.precio.SelectedText = "";
            this.precio.SelectionLength = 0;
            this.precio.SelectionStart = 0;
            this.precio.Size = new System.Drawing.Size(316, 28);
            this.precio.TabIndex = 5;
            this.precio.TabStop = false;
            this.precio.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(427, 52);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(236, 26);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Información de producto";
            // 
            // TextNombre
            // 
            this.TextNombre.BackColor = System.Drawing.Color.White;
            this.TextNombre.Depth = 0;
            this.TextNombre.Hint = "Nombre";
            this.TextNombre.Location = new System.Drawing.Point(716, 124);
            this.TextNombre.MaxLength = 32767;
            this.TextNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.PasswordChar = '\0';
            this.TextNombre.SelectedText = "";
            this.TextNombre.SelectionLength = 0;
            this.TextNombre.SelectionStart = 0;
            this.TextNombre.Size = new System.Drawing.Size(316, 28);
            this.TextNombre.TabIndex = 3;
            this.TextNombre.TabStop = false;
            this.TextNombre.UseSystemPasswordChar = false;
            // 
            // TextId
            // 
            this.TextId.BackColor = System.Drawing.Color.White;
            this.TextId.Depth = 0;
            this.TextId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextId.Hint = "Identificador";
            this.TextId.Location = new System.Drawing.Point(208, 137);
            this.TextId.MaxLength = 32767;
            this.TextId.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextId.Name = "TextId";
            this.TextId.PasswordChar = '\0';
            this.TextId.SelectedText = "";
            this.TextId.SelectionLength = 0;
            this.TextId.SelectionStart = 0;
            this.TextId.Size = new System.Drawing.Size(316, 28);
            this.TextId.TabIndex = 0;
            this.TextId.TabStop = false;
            this.TextId.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialLabel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1113, 522);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar producto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(477, 218);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(92, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Modificar";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1113, 522);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Consultar inventario";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(469, 207);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Consultar";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.materialLabel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1113, 522);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Eliminar producto";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(484, 176);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Eliminar";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Location = new System.Drawing.Point(-4, 6);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1138, 42);
            this.materialTabSelector2.TabIndex = 0;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.materialTabControl3);
            this.tabPage6.Controls.Add(this.materialTabSelector3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1154, 643);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Ordenes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialTabControl3
            // 
            this.materialTabControl3.Controls.Add(this.tabPage8);
            this.materialTabControl3.Controls.Add(this.tabPage9);
            this.materialTabControl3.Depth = 0;
            this.materialTabControl3.Location = new System.Drawing.Point(25, 77);
            this.materialTabControl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl3.Name = "materialTabControl3";
            this.materialTabControl3.SelectedIndex = 0;
            this.materialTabControl3.Size = new System.Drawing.Size(1148, 518);
            this.materialTabControl3.TabIndex = 2;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.materialLabel5);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1140, 489);
            this.tabPage8.TabIndex = 0;
            this.tabPage8.Text = "Abastacimiento";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(495, 229);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(143, 24);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Abastecimiento";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.materialLabel7);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1140, 489);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Desabastecimiento";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(457, 213);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(173, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Desabastecimiento";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.BaseTabControl = this.materialTabControl3;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Location = new System.Drawing.Point(0, 22);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(1134, 42);
            this.materialTabSelector3.TabIndex = 1;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.materialLabel6);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1154, 643);
            this.tabPage7.TabIndex = 4;
            this.tabPage7.Text = "Reportes";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(446, 281);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 24);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Reportes";
            // 
            // Tab
            // 
            this.Tab.BaseTabControl = this.materialTabControl1;
            this.Tab.Depth = 0;
            this.Tab.Location = new System.Drawing.Point(30, 93);
            this.Tab.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tab.Name = "Tab";
            this.Tab.Size = new System.Drawing.Size(1138, 40);
            this.Tab.TabIndex = 1;
            this.Tab.Text = "materialTabSelector1";
            // 
            // LabelUser
            // 
            this.LabelUser.AutoSize = true;
            this.LabelUser.Depth = 0;
            this.LabelUser.Font = new System.Drawing.Font("Roboto", 11F);
            this.LabelUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LabelUser.Location = new System.Drawing.Point(1082, 39);
            this.LabelUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelUser.Name = "LabelUser";
            this.LabelUser.Size = new System.Drawing.Size(0, 24);
            this.LabelUser.TabIndex = 2;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(987, 39);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(89, 24);
            this.materialLabel9.TabIndex = 3;
            this.materialLabel9.Text = "Usuario : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 845);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.LabelUser);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTINV";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.materialTabControl3.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector Tab;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl3;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextId;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField stock;
        private MaterialSkin.Controls.MaterialSingleLineTextField precio;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField stockMin;
        private MaterialSkin.Controls.MaterialSingleLineTextField categoria;
        private MaterialSkin.Controls.MaterialLabel LabelUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
    }
}

