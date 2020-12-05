namespace SistemaBiblioteca
{
    partial class Producto
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_producto = new System.Windows.Forms.DataGridView();
            this.btn_verProd = new System.Windows.Forms.Button();
            this.txt_buscarProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_idProveedor = new System.Windows.Forms.ComboBox();
            this.num_CantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.txt_precProd = new System.Windows.Forms.TextBox();
            this.txt_nomProd = new System.Windows.Forms.TextBox();
            this.txt_idProd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_enviar2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.dgv_producto);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(359, 88);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 283);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // dgv_producto
            // 
            this.dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_producto.Location = new System.Drawing.Point(15, 23);
            this.dgv_producto.Name = "dgv_producto";
            this.dgv_producto.Size = new System.Drawing.Size(266, 254);
            this.dgv_producto.TabIndex = 0;
            this.dgv_producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_producto_CellContentClick);
            // 
            // btn_verProd
            // 
            this.btn_verProd.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verProd.Location = new System.Drawing.Point(385, 62);
            this.btn_verProd.Name = "btn_verProd";
            this.btn_verProd.Size = new System.Drawing.Size(75, 23);
            this.btn_verProd.TabIndex = 5;
            this.btn_verProd.Text = "Ver Productos";
            this.btn_verProd.UseVisualStyleBackColor = true;
            this.btn_verProd.Click += new System.EventHandler(this.btn_verProd_Click);
            // 
            // txt_buscarProducto
            // 
            this.txt_buscarProducto.Location = new System.Drawing.Point(481, 62);
            this.txt_buscarProducto.Name = "txt_buscarProducto";
            this.txt_buscarProducto.Size = new System.Drawing.Size(93, 20);
            this.txt_buscarProducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(227, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "FORMULARIO DE PRODUCTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.cbx_idProveedor);
            this.groupBox1.Controls.Add(this.num_CantidadProducto);
            this.groupBox1.Controls.Add(this.txt_precProd);
            this.groupBox1.Controls.Add(this.txt_nomProd);
            this.groupBox1.Controls.Add(this.txt_idProd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(46, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 219);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // cbx_idProveedor
            // 
            this.cbx_idProveedor.FormattingEnabled = true;
            this.cbx_idProveedor.Location = new System.Drawing.Point(25, 166);
            this.cbx_idProveedor.Name = "cbx_idProveedor";
            this.cbx_idProveedor.Size = new System.Drawing.Size(121, 25);
            this.cbx_idProveedor.TabIndex = 10;
            this.cbx_idProveedor.SelectedIndexChanged += new System.EventHandler(this.cbx_idProveedor_SelectedIndexChanged);
            // 
            // num_CantidadProducto
            // 
            this.num_CantidadProducto.Location = new System.Drawing.Point(116, 122);
            this.num_CantidadProducto.Name = "num_CantidadProducto";
            this.num_CantidadProducto.Size = new System.Drawing.Size(120, 28);
            this.num_CantidadProducto.TabIndex = 9;
            // 
            // txt_precProd
            // 
            this.txt_precProd.Location = new System.Drawing.Point(25, 124);
            this.txt_precProd.Name = "txt_precProd";
            this.txt_precProd.Size = new System.Drawing.Size(64, 28);
            this.txt_precProd.TabIndex = 8;
            // 
            // txt_nomProd
            // 
            this.txt_nomProd.Location = new System.Drawing.Point(25, 78);
            this.txt_nomProd.Name = "txt_nomProd";
            this.txt_nomProd.Size = new System.Drawing.Size(181, 28);
            this.txt_nomProd.TabIndex = 6;
            // 
            // txt_idProd
            // 
            this.txt_idProd.Location = new System.Drawing.Point(25, 34);
            this.txt_idProd.Name = "txt_idProd";
            this.txt_idProd.Size = new System.Drawing.Size(100, 28);
            this.txt_idProd.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "ID Proveedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID ";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(60, 313);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(141, 313);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 12;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(222, 313);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 13;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_enviar2
            // 
            this.btn_enviar2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar2.Location = new System.Drawing.Point(536, 377);
            this.btn_enviar2.Name = "btn_enviar2";
            this.btn_enviar2.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar2.TabIndex = 14;
            this.btn_enviar2.Text = "Enviar";
            this.btn_enviar2.UseVisualStyleBackColor = true;
            this.btn_enviar2.Click += new System.EventHandler(this.btn_enviar2_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaBiblioteca.Properties.Resources._37926803_cafetería_plantilla_de_diseño_del_logotipo_emblema_café_retro_vector_el_arte_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 420);
            this.Controls.Add(this.btn_enviar2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscarProducto);
            this.Controls.Add(this.btn_verProd);
            this.Controls.Add(this.groupBox4);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_CantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_producto;
        private System.Windows.Forms.Button btn_verProd;
        private System.Windows.Forms.TextBox txt_buscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precProd;
        private System.Windows.Forms.TextBox txt_nomProd;
        private System.Windows.Forms.TextBox txt_idProd;
        private System.Windows.Forms.ComboBox cbx_idProveedor;
        private System.Windows.Forms.NumericUpDown num_CantidadProducto;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_enviar2;
    }
}