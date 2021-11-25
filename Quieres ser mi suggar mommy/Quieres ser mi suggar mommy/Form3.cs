using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quieres_ser_mi_suggar_mommy
{
    public partial class Frmlogin : Form
    {
        String Usuario = "KSF_MAAC";
        String Contraseña = "141999";
    
    
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != Usuario || txtContraseña.Text != Contraseña)
            {
                if (txtUsuario.Text != Usuario)
                {
                    MessageBox.Show("Tu no eres karen >:c");
                    txtUsuario.Clear();
                    txtUsuario.Focus();
                    return;
                }
                if (txtContraseña.Text != Contraseña)
                {
                    MessageBox.Show("Tu no eres Karen >:c");
                    txtContraseña.Clear();
                    txtContraseña.Focus();
                    return;
                }
            }
            else
            {
                txtUsuario.Clear();
                txtContraseña.Clear();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }
    }
}
