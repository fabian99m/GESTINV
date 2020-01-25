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
            this.TextNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextTel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TextEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // TextNombre
            // 
            this.TextNombre.Depth = 0;
            this.TextNombre.Hint = "Nombre";
            this.TextNombre.Location = new System.Drawing.Point(63, 112);
            this.TextNombre.MaxLength = 32767;
            this.TextNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.PasswordChar = '\0';
            this.TextNombre.SelectedText = "";
            this.TextNombre.SelectionLength = 0;
            this.TextNombre.SelectionStart = 0;
            this.TextNombre.Size = new System.Drawing.Size(274, 28);
            this.TextNombre.TabIndex = 0;
            this.TextNombre.TabStop = false;
            this.TextNombre.UseSystemPasswordChar = false;
            // 
            // TextTel
            // 
            this.TextTel.Depth = 0;
            this.TextTel.Hint = "Teléfono";
            this.TextTel.Location = new System.Drawing.Point(63, 190);
            this.TextTel.MaxLength = 32767;
            this.TextTel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextTel.Name = "TextTel";
            this.TextTel.PasswordChar = '\0';
            this.TextTel.SelectedText = "";
            this.TextTel.SelectionLength = 0;
            this.TextTel.SelectionStart = 0;
            this.TextTel.Size = new System.Drawing.Size(274, 28);
            this.TextTel.TabIndex = 1;
            this.TextTel.TabStop = false;
            this.TextTel.UseSystemPasswordChar = false;
            this.TextTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextTel_KeyPress);
            // 
            // TextEmail
            // 
            this.TextEmail.Depth = 0;
            this.TextEmail.Hint = "Email";
            this.TextEmail.Location = new System.Drawing.Point(63, 259);
            this.TextEmail.MaxLength = 32767;
            this.TextEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.PasswordChar = '\0';
            this.TextEmail.SelectedText = "";
            this.TextEmail.SelectionLength = 0;
            this.TextEmail.SelectionStart = 0;
            this.TextEmail.Size = new System.Drawing.Size(274, 28);
            this.TextEmail.TabIndex = 2;
            this.TextEmail.TabStop = false;
            this.TextEmail.UseSystemPasswordChar = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Icon = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Icon")));
            this.btnGuardar.Location = new System.Drawing.Point(112, 338);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(128, 36);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Proveedor_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 465);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.TextTel);
            this.Controls.Add(this.TextNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Proveedor_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField TextNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextTel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TextEmail;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
    }
}