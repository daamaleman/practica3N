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
    public partial class RegistrationForm : MetroFramework.Forms.MetroForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtLastName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()) || string.IsNullOrWhiteSpace(TxtPw.Text.Trim()) || string.IsNullOrWhiteSpace(TxtPw2.Text.Trim()) || string.IsNullOrWhiteSpace(TxtEmail.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Debe llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!TxtEmail.Text.Contains("@"))
            {
                MetroFramework.MetroMessageBox.Show(this, "El correo no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ValidarPw();

            MetroFramework.MetroMessageBox.Show(this, "Usuario registrado exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtPw.Text.Length > 0)  
            {
                TxtPw2.Visible = true;
                LblPw2.Visible = true;
                CbxSee2.Visible = true;
            }
            else
            {
                TxtPw2.Visible = false;
                LblPw2.Visible = false;
                CbxSee2.Visible = false;
            }
        }

        private void CbxSee1_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSee1.Checked)
            {
                TxtPw.PasswordChar = '\0';
                CbxSee1.Text = "Ocultar";
            }
            else
            {
                TxtPw.PasswordChar = '*';
                CbxSee1.Text = "Ver";
            }
        }

        private void CbxSee2_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxSee2.Checked)
            {
                TxtPw2.PasswordChar = '\0';
                CbxSee2.Text = "Ocultar";
            }
            else
            {
                TxtPw2.PasswordChar = '*';
                CbxSee2.Text = "Ver";
            }
        }

        private void ValidarPw()
        {
            if (TxtPw.Text != TxtPw2.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool ValidarPassword(string pw1, string pw2)
        {
            return pw1 == pw2;
        }

        private void TxtPw2_KeyUp(object sender, KeyEventArgs e)
        {
            if (ValidarPassword(TxtPw.Text, TxtPw2.Text))
            {
                TxtPw2.ForeColor = Color.Green;
            }
            else
            {
                TxtPw2.ForeColor = Color.Red;
            }
        }

    }
}
