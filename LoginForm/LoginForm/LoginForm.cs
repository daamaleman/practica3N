using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using LoginForm.Services;
using LoginForm.Models;


namespace LoginForm
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUser.Text.Trim()) || string.IsNullOrWhiteSpace(TxtPw.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Ingrese un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario
            {
                User = TxtUser.Text,
                Password = TxtPw.Text
            };

            UserService userService = new UserService();

            if (userService.ValidateUser(usuario.User, usuario.Password))
            {
                MetroMessageBox.Show(this, "Bienvenido", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroMessageBox.Show(this, "Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}