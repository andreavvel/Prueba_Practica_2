using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba_practica
{
    public partial class FormRegistro : Prueba_practica.FormBase
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                ("¿Desea salir de la aplicación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            { this.Close(); }
        }
    }
}
