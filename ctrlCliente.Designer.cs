namespace Facturacion
{
    partial class ctrlCliente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlCliente));
            this.tbTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregarCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTelefono
            // 
            this.tbTelefono.Depth = 0;
            this.tbTelefono.ForeColor = System.Drawing.Color.White;
            this.tbTelefono.Hint = "Telefono";
            this.tbTelefono.Location = new System.Drawing.Point(19, 275);
            this.tbTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.PasswordChar = '\0';
            this.tbTelefono.SelectedText = "";
            this.tbTelefono.SelectionLength = 0;
            this.tbTelefono.SelectionStart = 0;
            this.tbTelefono.Size = new System.Drawing.Size(241, 23);
            this.tbTelefono.TabIndex = 2;
            this.tbTelefono.UseSystemPasswordChar = false;
            // 
            // tbApellido
            // 
            this.tbApellido.Depth = 0;
            this.tbApellido.ForeColor = System.Drawing.Color.White;
            this.tbApellido.Hint = "Apellido";
            this.tbApellido.Location = new System.Drawing.Point(19, 221);
            this.tbApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.PasswordChar = '\0';
            this.tbApellido.SelectedText = "";
            this.tbApellido.SelectionLength = 0;
            this.tbApellido.SelectionStart = 0;
            this.tbApellido.Size = new System.Drawing.Size(241, 23);
            this.tbApellido.TabIndex = 1;
            this.tbApellido.UseSystemPasswordChar = false;
            // 
            // tbNombre
            // 
            this.tbNombre.Depth = 0;
            this.tbNombre.ForeColor = System.Drawing.Color.White;
            this.tbNombre.Hint = "Nombre";
            this.tbNombre.Location = new System.Drawing.Point(19, 168);
            this.tbNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.PasswordChar = '\0';
            this.tbNombre.SelectedText = "";
            this.tbNombre.SelectionLength = 0;
            this.tbNombre.SelectionStart = 0;
            this.tbNombre.Size = new System.Drawing.Size(241, 23);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.UseSystemPasswordChar = false;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Atras";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(160, 321);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(112, 48);
            this.bunifuFlatButton2.TabIndex = 4;
            this.bunifuFlatButton2.Text = "Atras";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAgregarCliente.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarCliente.BorderRadius = 0;
            this.btnAgregarCliente.ButtonText = "Agregar";
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregarCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregarCliente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCliente.Iconimage")));
            this.btnAgregarCliente.Iconimage_right = null;
            this.btnAgregarCliente.Iconimage_right_Selected = null;
            this.btnAgregarCliente.Iconimage_Selected = null;
            this.btnAgregarCliente.IconMarginLeft = 0;
            this.btnAgregarCliente.IconMarginRight = 0;
            this.btnAgregarCliente.IconRightVisible = true;
            this.btnAgregarCliente.IconRightZoom = 0D;
            this.btnAgregarCliente.IconVisible = true;
            this.btnAgregarCliente.IconZoom = 90D;
            this.btnAgregarCliente.IsTab = false;
            this.btnAgregarCliente.Location = new System.Drawing.Point(19, 321);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Normalcolor = System.Drawing.Color.Silver;
            this.btnAgregarCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregarCliente.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.selected = false;
            this.btnAgregarCliente.Size = new System.Drawing.Size(112, 48);
            this.btnAgregarCliente.TabIndex = 3;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.Textcolor = System.Drawing.Color.White;
            this.btnAgregarCliente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbTelefono);
            this.Name = "ctrlCliente";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(297, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField tbTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbApellido;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregarCliente;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
