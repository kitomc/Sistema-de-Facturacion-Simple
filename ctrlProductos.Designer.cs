namespace Facturacion
{
    partial class ctrlProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlProductos));
            this.tbDescripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCosto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAtrasProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCrearProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Depth = 0;
            this.tbDescripcion.Hint = "Descripcion";
            this.tbDescripcion.Location = new System.Drawing.Point(17, 175);
            this.tbDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.PasswordChar = '\0';
            this.tbDescripcion.SelectedText = "";
            this.tbDescripcion.SelectionLength = 0;
            this.tbDescripcion.SelectionStart = 0;
            this.tbDescripcion.Size = new System.Drawing.Size(260, 23);
            this.tbDescripcion.TabIndex = 1;
            this.tbDescripcion.UseSystemPasswordChar = false;
            // 
            // tbCosto
            // 
            this.tbCosto.Depth = 0;
            this.tbCosto.Hint = "Costo";
            this.tbCosto.Location = new System.Drawing.Point(17, 263);
            this.tbCosto.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.PasswordChar = '\0';
            this.tbCosto.SelectedText = "";
            this.tbCosto.SelectionLength = 0;
            this.tbCosto.SelectionStart = 0;
            this.tbCosto.Size = new System.Drawing.Size(260, 23);
            this.tbCosto.TabIndex = 2;
            this.tbCosto.UseSystemPasswordChar = false;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Depth = 0;
            this.tbCantidad.Hint = "Cantidad";
            this.tbCantidad.Location = new System.Drawing.Point(17, 220);
            this.tbCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.PasswordChar = '\0';
            this.tbCantidad.SelectedText = "";
            this.tbCantidad.SelectionLength = 0;
            this.tbCantidad.SelectionStart = 0;
            this.tbCantidad.Size = new System.Drawing.Size(260, 23);
            this.tbCantidad.TabIndex = 3;
            this.tbCantidad.UseSystemPasswordChar = false;
            // 
            // btnAtrasProducto
            // 
            this.btnAtrasProducto.Activecolor = System.Drawing.Color.White;
            this.btnAtrasProducto.BackColor = System.Drawing.Color.Silver;
            this.btnAtrasProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtrasProducto.BorderRadius = 0;
            this.btnAtrasProducto.ButtonText = "Atras";
            this.btnAtrasProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnAtrasProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAtrasProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAtrasProducto.Iconimage")));
            this.btnAtrasProducto.Iconimage_right = null;
            this.btnAtrasProducto.Iconimage_right_Selected = null;
            this.btnAtrasProducto.Iconimage_Selected = null;
            this.btnAtrasProducto.IconMarginLeft = 0;
            this.btnAtrasProducto.IconMarginRight = 0;
            this.btnAtrasProducto.IconRightVisible = true;
            this.btnAtrasProducto.IconRightZoom = 0D;
            this.btnAtrasProducto.IconVisible = true;
            this.btnAtrasProducto.IconZoom = 90D;
            this.btnAtrasProducto.IsTab = false;
            this.btnAtrasProducto.Location = new System.Drawing.Point(155, 318);
            this.btnAtrasProducto.Name = "btnAtrasProducto";
            this.btnAtrasProducto.Normalcolor = System.Drawing.Color.Silver;
            this.btnAtrasProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAtrasProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAtrasProducto.selected = false;
            this.btnAtrasProducto.Size = new System.Drawing.Size(115, 48);
            this.btnAtrasProducto.TabIndex = 5;
            this.btnAtrasProducto.Text = "Atras";
            this.btnAtrasProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasProducto.Textcolor = System.Drawing.Color.White;
            this.btnAtrasProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasProducto.Click += new System.EventHandler(this.BtnAtrasProducto_Click);
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Activecolor = System.Drawing.Color.White;
            this.btnCrearProducto.BackColor = System.Drawing.Color.Silver;
            this.btnCrearProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearProducto.BorderRadius = 0;
            this.btnCrearProducto.ButtonText = "Crear";
            this.btnCrearProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnCrearProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCrearProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCrearProducto.Iconimage")));
            this.btnCrearProducto.Iconimage_right = null;
            this.btnCrearProducto.Iconimage_right_Selected = null;
            this.btnCrearProducto.Iconimage_Selected = null;
            this.btnCrearProducto.IconMarginLeft = 0;
            this.btnCrearProducto.IconMarginRight = 0;
            this.btnCrearProducto.IconRightVisible = true;
            this.btnCrearProducto.IconRightZoom = 0D;
            this.btnCrearProducto.IconVisible = true;
            this.btnCrearProducto.IconZoom = 90D;
            this.btnCrearProducto.IsTab = false;
            this.btnCrearProducto.Location = new System.Drawing.Point(17, 318);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Normalcolor = System.Drawing.Color.Silver;
            this.btnCrearProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCrearProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCrearProducto.selected = false;
            this.btnCrearProducto.Size = new System.Drawing.Size(115, 48);
            this.btnCrearProducto.TabIndex = 4;
            this.btnCrearProducto.Text = "Crear";
            this.btnCrearProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearProducto.Textcolor = System.Drawing.Color.White;
            this.btnCrearProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearProducto.Click += new System.EventHandler(this.BtnCrearProducto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ctrlProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAtrasProducto);
            this.Controls.Add(this.btnCrearProducto);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrlProductos";
            this.Size = new System.Drawing.Size(297, 383);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCosto;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbCantidad;
        private Bunifu.Framework.UI.BunifuFlatButton btnCrearProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnAtrasProducto;
    }
}
