namespace Vista.Proveedor
{
    partial class Proveedor_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedor_view));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.OpcProveedor = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TextEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefrescar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TextConsulta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbproveedor = new MaterialSkin.Controls.MaterialListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TablaProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OpcProveedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.OpcProveedor;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(28, 84);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(700, 34);
            this.materialTabSelector1.TabIndex = 4;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // OpcProveedor
            // 
            this.OpcProveedor.Controls.Add(this.tabPage1);
            this.OpcProveedor.Controls.Add(this.tabPage2);
            this.OpcProveedor.Depth = 0;
            this.OpcProveedor.Location = new System.Drawing.Point(28, 124);
            this.OpcProveedor.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpcProveedor.Name = "OpcProveedor";
            this.OpcProveedor.SelectedIndex = 0;
            this.OpcProveedor.Size = new System.Drawing.Size(700, 461);
            this.OpcProveedor.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.TextEmail);
            this.tabPage1.Controls.Add(this.TextTel);
            this.tabPage1.Controls.Add(this.TextNombre);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Añadir";
            // 
            // TextEmail
            // 
            this.TextEmail.Depth = 0;
            this.TextEmail.Hint = "Email";
            this.TextEmail.Location = new System.Drawing.Point(179, 211);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.Size = new System.Drawing.Size(381, 28);
            this.TextEmail.TabIndex = 6;
            this.TextEmail.TabStop = false;
            this.TextEmail.UseSystemPasswordChar = false;
            // 
            // TextTel
            // 
            this.TextTel.Depth = 0;
            this.TextTel.Hint = "Teléfono";
            this.TextTel.Location = new System.Drawing.Point(179, 146);
            this.TextTel.MaxLength = 32767;
            this.TextTel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextTel.Name = "TextTel";
            this.TextTel.PasswordChar = '\0';
            this.TextTel.SelectedText = "";
            this.TextTel.SelectionLength = 0;
            this.TextTel.SelectionStart = 0;
            this.TextTel.Size = new System.Drawing.Size(381, 28);
            this.TextTel.TabIndex = 5;
            this.TextTel.TabStop = false;
            this.TextTel.UseSystemPasswordChar = false;
            this.TextTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTel_KeyPress);
            // 
            // TextNombre
            // 
            this.TextNombre.Depth = 0;
            this.TextNombre.Hint = "Nombre";
            this.TextNombre.Location = new System.Drawing.Point(179, 78);
            this.TextNombre.MaxLength = 32767;
            this.TextNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.PasswordChar = '\0';
            this.TextNombre.SelectedText = "";
            this.TextNombre.SelectionLength = 0;
            this.TextNombre.SelectionStart = 0;
            this.TextNombre.Size = new System.Drawing.Size(372, 28);
            this.TextNombre.TabIndex = 4;
            this.TextNombre.TabStop = false;
            this.TextNombre.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Icon")));
            this.btnGuardar.Location = new System.Drawing.Point(256, 295);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(128, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnRefrescar);
            this.tabPage2.Controls.Add(this.materialRaisedButton1);
            this.tabPage2.Controls.Add(this.TextConsulta);
            this.tabPage2.Controls.Add(this.tbproveedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.AutoSize = true;
            this.btnRefrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefrescar.Depth = 0;
            this.btnRefrescar.Icon = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Icon")));
            this.btnRefrescar.Location = new System.Drawing.Point(6, 390);
            this.btnRefrescar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Primary = true;
            this.btnRefrescar.Size = new System.Drawing.Size(144, 36);
            this.btnRefrescar.TabIndex = 3;
            this.btnRefrescar.Text = "refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.Icon")));
            this.materialRaisedButton1.Location = new System.Drawing.Point(215, 9);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(149, 36);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.Text = "Consultar";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // TextConsulta
            // 
            this.TextConsulta.Depth = 0;
            this.TextConsulta.Hint = "Nombre";
            this.TextConsulta.Location = new System.Drawing.Point(18, 17);
            this.TextConsulta.MaxLength = 32767;
            this.TextConsulta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextConsulta.Name = "TextConsulta";
            this.TextConsulta.PasswordChar = '\0';
            this.TextConsulta.SelectedText = "";
            this.TextConsulta.SelectionLength = 0;
            this.TextConsulta.SelectionStart = 0;
            this.TextConsulta.Size = new System.Drawing.Size(173, 28);
            this.TextConsulta.TabIndex = 1;
            this.TextConsulta.TabStop = false;
            this.TextConsulta.UseSystemPasswordChar = false;
            // 
            // tbproveedor
            // 
            this.tbproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbproveedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.columnHeader1,
            this.TablaProveedor});
            this.tbproveedor.Depth = 0;
            this.tbproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.tbproveedor.FullRowSelect = true;
            this.tbproveedor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.tbproveedor.HideSelection = false;
            this.tbproveedor.Location = new System.Drawing.Point(18, 64);
            this.tbproveedor.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tbproveedor.MouseState = MaterialSkin.MouseState.OUT;
            this.tbproveedor.Name = "tbproveedor";
            this.tbproveedor.OwnerDraw = true;
            this.tbproveedor.Size = new System.Drawing.Size(667, 285);
            this.tbproveedor.TabIndex = 0;
            this.tbproveedor.UseCompatibleStateImageBehavior = false;
            this.tbproveedor.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Teléfono";
            this.columnHeader1.Width = 160;
            // 
            // TablaProveedor
            // 
            this.TablaProveedor.Text = "Email";
            this.TablaProveedor.Width = 160;
            // 
            // Proveedor_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 597);
            this.Controls.Add(this.OpcProveedor);
            this.Controls.Add(this.materialTabSelector1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proveedor_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.OpcProveedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl OpcProveedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialListView tbproveedor;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader TablaProveedor;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextConsulta;
        private MaterialSkin.Controls.MaterialRaisedButton btnRefrescar;
    }
}