namespace SistemaBiblioteca
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_telCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dirCli = new System.Windows.Forms.TextBox();
            this.txt_apeCli = new System.Windows.Forms.TextBox();
            this.txt_nomCli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dniCli = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_lectores = new System.Windows.Forms.DataGridView();
            this.btn_CargarLector = new System.Windows.Forms.Button();
            this.txt_buscarNombre = new System.Windows.Forms.TextBox();
            this.btn_buscarNombre = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lectores)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Controls.Add(this.txt_telCli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dirCli);
            this.groupBox1.Controls.Add(this.txt_apeCli);
            this.groupBox1.Controls.Add(this.txt_nomCli);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_dniCli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txt_telCli
            // 
            this.txt_telCli.Location = new System.Drawing.Point(12, 164);
            this.txt_telCli.Name = "txt_telCli";
            this.txt_telCli.Size = new System.Drawing.Size(72, 25);
            this.txt_telCli.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefono";
            // 
            // txt_dirCli
            // 
            this.txt_dirCli.Location = new System.Drawing.Point(12, 120);
            this.txt_dirCli.Name = "txt_dirCli";
            this.txt_dirCli.Size = new System.Drawing.Size(215, 25);
            this.txt_dirCli.TabIndex = 7;
            // 
            // txt_apeCli
            // 
            this.txt_apeCli.Location = new System.Drawing.Point(124, 76);
            this.txt_apeCli.Name = "txt_apeCli";
            this.txt_apeCli.Size = new System.Drawing.Size(100, 25);
            this.txt_apeCli.TabIndex = 6;
            // 
            // txt_nomCli
            // 
            this.txt_nomCli.Location = new System.Drawing.Point(12, 77);
            this.txt_nomCli.Name = "txt_nomCli";
            this.txt_nomCli.Size = new System.Drawing.Size(100, 25);
            this.txt_nomCli.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txt_dniCli
            // 
            this.txt_dniCli.Location = new System.Drawing.Point(9, 33);
            this.txt_dniCli.Name = "txt_dniCli";
            this.txt_dniCli.Size = new System.Drawing.Size(100, 25);
            this.txt_dniCli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Nuevo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(235, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "FORMULARIO DEL CLIENTE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_lectores);
            this.groupBox4.Location = new System.Drawing.Point(335, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 283);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // dgv_lectores
            // 
            this.dgv_lectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lectores.Location = new System.Drawing.Point(6, 19);
            this.dgv_lectores.Name = "dgv_lectores";
            this.dgv_lectores.Size = new System.Drawing.Size(266, 254);
            this.dgv_lectores.TabIndex = 0;
            this.dgv_lectores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_lectores_CellContentClick);
            // 
            // btn_CargarLector
            // 
            this.btn_CargarLector.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarLector.Location = new System.Drawing.Point(335, 56);
            this.btn_CargarLector.Name = "btn_CargarLector";
            this.btn_CargarLector.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarLector.TabIndex = 4;
            this.btn_CargarLector.Text = "Ver Clientes";
            this.btn_CargarLector.UseVisualStyleBackColor = true;
            this.btn_CargarLector.Click += new System.EventHandler(this.btn_CargarLector_Click);
            // 
            // txt_buscarNombre
            // 
            this.txt_buscarNombre.Location = new System.Drawing.Point(416, 56);
            this.txt_buscarNombre.Name = "txt_buscarNombre";
            this.txt_buscarNombre.Size = new System.Drawing.Size(93, 20);
            this.txt_buscarNombre.TabIndex = 7;
            this.txt_buscarNombre.TextChanged += new System.EventHandler(this.txt_buscarNombre_TextChanged);
            // 
            // btn_buscarNombre
            // 
            this.btn_buscarNombre.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarNombre.Location = new System.Drawing.Point(515, 56);
            this.btn_buscarNombre.Name = "btn_buscarNombre";
            this.btn_buscarNombre.Size = new System.Drawing.Size(92, 23);
            this.btn_buscarNombre.TabIndex = 8;
            this.btn_buscarNombre.Text = "Buscar Nombre";
            this.btn_buscarNombre.UseVisualStyleBackColor = true;
            this.btn_buscarNombre.Click += new System.EventHandler(this.btn_buscarNombre_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(335, 374);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(9, 59);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(99, 59);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_guardar);
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(9, 19);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(490, 374);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 9;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::SistemaBiblioteca.Properties.Resources._37926803_cafetería_plantilla_de_diseño_del_logotipo_emblema_café_retro_vector_el_arte_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 454);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_buscarNombre);
            this.Controls.Add(this.txt_buscarNombre);
            this.Controls.Add(this.btn_CargarLector);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lectores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dirCli;
        private System.Windows.Forms.TextBox txt_apeCli;
        private System.Windows.Forms.TextBox txt_nomCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dniCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_lectores;
        private System.Windows.Forms.Button btn_CargarLector;
        private System.Windows.Forms.TextBox txt_buscarNombre;
        private System.Windows.Forms.Button btn_buscarNombre;
        private System.Windows.Forms.TextBox txt_telCli;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_enviar;
    }
}

