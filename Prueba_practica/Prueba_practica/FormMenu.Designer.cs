
namespace Prueba_practica
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnagregar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmboxhambu = new System.Windows.Forms.ComboBox();
            this.cmboxpapas = new System.Windows.Forms.ComboBox();
            this.cmboxbebida = new System.Windows.Forms.ComboBox();
            this.btnagregar2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsig = new System.Windows.Forms.Button();
            this.btnagregar0 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvpedido = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(508, 499);
            this.btnsalir.Size = new System.Drawing.Size(133, 41);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(617, 313);
            this.btnmenu.Size = new System.Drawing.Size(10, 10);
            this.btnmenu.Text = "Actual";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.Text = "Menú: seleccione su pedido";
            // 
            // btnagregar1
            // 
            this.btnagregar1.BackColor = System.Drawing.Color.DarkCyan;
            this.btnagregar1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar1.Location = new System.Drawing.Point(508, 142);
            this.btnagregar1.Name = "btnagregar1";
            this.btnagregar1.Size = new System.Drawing.Size(133, 34);
            this.btnagregar1.TabIndex = 1;
            this.btnagregar1.Text = "Agregar";
            this.btnagregar1.UseVisualStyleBackColor = false;
            this.btnagregar1.Click += new System.EventHandler(this.btnagregar1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // cmboxhambu
            // 
            this.cmboxhambu.FormattingEnabled = true;
            this.cmboxhambu.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmboxhambu.Location = new System.Drawing.Point(394, 72);
            this.cmboxhambu.Name = "cmboxhambu";
            this.cmboxhambu.Size = new System.Drawing.Size(68, 21);
            this.cmboxhambu.TabIndex = 6;
            // 
            // cmboxpapas
            // 
            this.cmboxpapas.FormattingEnabled = true;
            this.cmboxpapas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmboxpapas.Location = new System.Drawing.Point(396, 150);
            this.cmboxpapas.Name = "cmboxpapas";
            this.cmboxpapas.Size = new System.Drawing.Size(68, 21);
            this.cmboxpapas.TabIndex = 7;
            // 
            // cmboxbebida
            // 
            this.cmboxbebida.FormattingEnabled = true;
            this.cmboxbebida.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cmboxbebida.Location = new System.Drawing.Point(394, 235);
            this.cmboxbebida.Name = "cmboxbebida";
            this.cmboxbebida.Size = new System.Drawing.Size(68, 21);
            this.cmboxbebida.TabIndex = 8;
            // 
            // btnagregar2
            // 
            this.btnagregar2.BackColor = System.Drawing.Color.DarkCyan;
            this.btnagregar2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar2.Location = new System.Drawing.Point(506, 228);
            this.btnagregar2.Name = "btnagregar2";
            this.btnagregar2.Size = new System.Drawing.Size(133, 34);
            this.btnagregar2.TabIndex = 9;
            this.btnagregar2.Text = "Agregar";
            this.btnagregar2.UseVisualStyleBackColor = false;
            this.btnagregar2.Click += new System.EventHandler(this.btnagregar2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hamburguesa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Papitas fritas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Bebida del día";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Prueba_practica.Properties.Resources.restaurante_tinjo_bebidas;
            this.pictureBox3.Location = new System.Drawing.Point(19, 228);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Prueba_practica.Properties.Resources.R;
            this.pictureBox2.Location = new System.Drawing.Point(19, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(95, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pictureBox1.BackgroundImage = global::Prueba_practica.Properties.Resources.hamburguesa_completa_nestle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnsig
            // 
            this.btnsig.BackColor = System.Drawing.Color.DarkCyan;
            this.btnsig.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsig.Location = new System.Drawing.Point(360, 499);
            this.btnsig.Name = "btnsig";
            this.btnsig.Size = new System.Drawing.Size(133, 41);
            this.btnsig.TabIndex = 19;
            this.btnsig.Text = "Siguiente";
            this.btnsig.UseVisualStyleBackColor = false;
            this.btnsig.Click += new System.EventHandler(this.btnsig_Click);
            // 
            // btnagregar0
            // 
            this.btnagregar0.BackColor = System.Drawing.Color.DarkCyan;
            this.btnagregar0.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar0.Location = new System.Drawing.Point(506, 59);
            this.btnagregar0.Name = "btnagregar0";
            this.btnagregar0.Size = new System.Drawing.Size(133, 34);
            this.btnagregar0.TabIndex = 20;
            this.btnagregar0.Text = "Agregar";
            this.btnagregar0.UseVisualStyleBackColor = false;
            this.btnagregar0.Click += new System.EventHandler(this.btnagregar0_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "$3.25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(232, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "$1.99";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(232, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "$1.50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(296, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 24;
            this.label11.Text = "Su pedido es:";
            // 
            // dgvpedido
            // 
            this.dgvpedido.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvpedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvpedido.Location = new System.Drawing.Point(29, 313);
            this.dgvpedido.Name = "dgvpedido";
            this.dgvpedido.Size = new System.Drawing.Size(487, 174);
            this.dgvpedido.TabIndex = 25;
            this.dgvpedido.DoubleClick += new System.EventHandler(this.dgvpedido_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(522, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 57);
            this.button1.TabIndex = 26;
            this.button1.Text = "Eliminar selección";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(522, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "*Seleccione el item que ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(542, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "desea eliminar";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(651, 552);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvpedido);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnagregar0);
            this.Controls.Add(this.btnsig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnagregar2);
            this.Controls.Add(this.cmboxbebida);
            this.Controls.Add(this.cmboxpapas);
            this.Controls.Add(this.cmboxhambu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnagregar1);
            this.Name = "FormMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnagregar1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cmboxhambu, 0);
            this.Controls.SetChildIndex(this.cmboxpapas, 0);
            this.Controls.SetChildIndex(this.cmboxbebida, 0);
            this.Controls.SetChildIndex(this.btnagregar2, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btnsig, 0);
            this.Controls.SetChildIndex(this.btnagregar0, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.dgvpedido, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Button btnagregar1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox cmboxhambu;
        protected System.Windows.Forms.ComboBox cmboxpapas;
        protected System.Windows.Forms.ComboBox cmboxbebida;
        protected System.Windows.Forms.Button btnagregar2;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.PictureBox pictureBox1;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.PictureBox pictureBox3;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Button btnagregar0;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Button btnsig;
        public System.Windows.Forms.Label label11;
        protected System.Windows.Forms.DataGridView dgvpedido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
