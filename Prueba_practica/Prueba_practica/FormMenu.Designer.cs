
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(508, 308);
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(506, 58);
            this.btnmenu.Size = new System.Drawing.Size(133, 34);
            this.btnmenu.Text = "Agregar";
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
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
            this.label2.Location = new System.Drawing.Point(316, 70);
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
            this.cmboxhambu.Location = new System.Drawing.Point(394, 67);
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
            this.btnsig.Location = new System.Drawing.Point(369, 308);
            this.btnsig.Name = "btnsig";
            this.btnsig.Size = new System.Drawing.Size(133, 53);
            this.btnsig.TabIndex = 19;
            this.btnsig.Text = "Siguiente";
            this.btnsig.UseVisualStyleBackColor = false;
            this.btnsig.Click += new System.EventHandler(this.btnsig_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(651, 373);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnagregar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmboxhambu;
        private System.Windows.Forms.ComboBox cmboxpapas;
        private System.Windows.Forms.ComboBox cmboxbebida;
        private System.Windows.Forms.Button btnagregar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsig;
    }
}
