using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtLastName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()) || string.IsNullOrWhiteSpace(TxtPw.Text.Trim()) || string.IsNullOrWhiteSpace(TxtPw2.Text.Trim())|| string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TxtEmail.Text.Contains("@"))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtPw.Text != TxtPw2.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MetroFramework.MetroMessageBox.Show(this, "Usuario registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
