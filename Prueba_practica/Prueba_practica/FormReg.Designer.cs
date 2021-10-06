
namespace Prueba_practica
{
    partial class FormReg
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
            this.lbltotal = new System.Windows.Forms.Label();
            this.btndomicilio = new System.Windows.Forms.Button();
            this.btnllevar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblenvio = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.btnfin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(458, 275);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(12, 275);
            this.btnmenu.Text = "Regresar a Menú";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.Text = "Total actual: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(290, 37);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 19);
            this.lbltotal.TabIndex = 3;
            // 
            // btndomicilio
            // 
            this.btndomicilio.BackColor = System.Drawing.Color.DarkCyan;
            this.btndomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndomicilio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndomicilio.Location = new System.Drawing.Point(101, 131);
            this.btndomicilio.Name = "btndomicilio";
            this.btndomicilio.Size = new System.Drawing.Size(159, 33);
            this.btndomicilio.TabIndex = 4;
            this.btndomicilio.Text = "A domicilio";
            this.btndomicilio.UseVisualStyleBackColor = false;
            this.btndomicilio.Click += new System.EventHandler(this.btndomicilio_Click);
            // 
            // btnllevar
            // 
            this.btnllevar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnllevar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnllevar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnllevar.Location = new System.Drawing.Point(364, 131);
            this.btnllevar.Name = "btnllevar";
            this.btnllevar.Size = new System.Drawing.Size(159, 33);
            this.btnllevar.TabIndex = 5;
            this.btnllevar.Text = "Para llevar";
            this.btnllevar.UseVisualStyleBackColor = false;
            this.btnllevar.Click += new System.EventHandler(this.btnllevar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione método de entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(59, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio de envio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(98, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total final:";
            // 
            // lblenvio
            // 
            this.lblenvio.AutoSize = true;
            this.lblenvio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenvio.ForeColor = System.Drawing.Color.Maroon;
            this.lblenvio.Location = new System.Drawing.Point(255, 189);
            this.lblenvio.Name = "lblenvio";
            this.lblenvio.Size = new System.Drawing.Size(0, 19);
            this.lblenvio.TabIndex = 9;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.ForeColor = System.Drawing.Color.Maroon;
            this.lblfinal.Location = new System.Drawing.Point(255, 234);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(0, 19);
            this.lblfinal.TabIndex = 10;
            // 
            // btnfin
            // 
            this.btnfin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnfin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfin.Location = new System.Drawing.Point(319, 275);
            this.btnfin.Name = "btnfin";
            this.btnfin.Size = new System.Drawing.Size(133, 53);
            this.btnfin.TabIndex = 11;
            this.btnfin.Text = "Finalizar compra";
            this.btnfin.UseVisualStyleBackColor = false;
            this.btnfin.Click += new System.EventHandler(this.btnfin_Click);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(603, 340);
            this.Controls.Add(this.btnfin);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.lblenvio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnllevar);
            this.Controls.Add(this.btndomicilio);
            this.Controls.Add(this.lbltotal);
            this.Name = "FormReg";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.Controls.SetChildIndex(this.lbltotal, 0);
            this.Controls.SetChildIndex(this.btndomicilio, 0);
            this.Controls.SetChildIndex(this.btnllevar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.lblenvio, 0);
            this.Controls.SetChildIndex(this.lblfinal, 0);
            this.Controls.SetChildIndex(this.btnsalir, 0);
            this.Controls.SetChildIndex(this.btnmenu, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnfin, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btndomicilio;
        private System.Windows.Forms.Button btnllevar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblenvio;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.Button btnfin;
    }
}
