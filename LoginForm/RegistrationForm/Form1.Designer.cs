namespace RegistrationForm
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
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblLastName = new MetroFramework.Controls.MetroLabel();
            this.LblEmail = new MetroFramework.Controls.MetroLabel();
            this.LblPw = new MetroFramework.Controls.MetroLabel();
            this.TxtName = new MetroFramework.Controls.MetroTextBox();
            this.TxtLastName = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtPw = new MetroFramework.Controls.MetroTextBox();
            this.BtnLogin = new MetroFramework.Controls.MetroButton();
            this.LblPw2 = new MetroFramework.Controls.MetroLabel();
            this.TxtPw2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(141, 107);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(62, 19);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Nombre:";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Location = new System.Drawing.Point(142, 150);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(61, 19);
            this.LblLastName.TabIndex = 1;
            this.LblLastName.Text = "Apellido:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(81, 193);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(122, 19);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Correo Electrónico:";
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(125, 241);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(78, 19);
            this.LblPw.TabIndex = 3;
            this.LblPw.Text = "Contraseña:";
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.CustomButton.Image = null;
            this.TxtName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TxtName.CustomButton.Name = "";
            this.TxtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtName.CustomButton.TabIndex = 1;
            this.TxtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtName.CustomButton.UseSelectable = true;
            this.TxtName.CustomButton.Visible = false;
            this.TxtName.Lines = new string[0];
            this.TxtName.Location = new System.Drawing.Point(209, 107);
            this.TxtName.MaxLength = 32767;
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtName.SelectedText = "";
            this.TxtName.SelectionLength = 0;
            this.TxtName.SelectionStart = 0;
            this.TxtName.ShortcutsEnabled = true;
            this.TxtName.Size = new System.Drawing.Size(246, 23);
            this.TxtName.TabIndex = 4;
            this.TxtName.UseSelectable = true;
            this.TxtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtLastName
            // 
            // 
            // 
            // 
            this.TxtLastName.CustomButton.Image = null;
            this.TxtLastName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TxtLastName.CustomButton.Name = "";
            this.TxtLastName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtLastName.CustomButton.TabIndex = 1;
            this.TxtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtLastName.CustomButton.UseSelectable = true;
            this.TxtLastName.CustomButton.Visible = false;
            this.TxtLastName.Lines = new string[0];
            this.TxtLastName.Location = new System.Drawing.Point(209, 150);
            this.TxtLastName.MaxLength = 32767;
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.PasswordChar = '\0';
            this.TxtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtLastName.SelectedText = "";
            this.TxtLastName.SelectionLength = 0;
            this.TxtLastName.SelectionStart = 0;
            this.TxtLastName.ShortcutsEnabled = true;
            this.TxtLastName.Size = new System.Drawing.Size(246, 23);
            this.TxtLastName.TabIndex = 5;
            this.TxtLastName.UseSelectable = true;
            this.TxtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtLastName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(209, 193);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(246, 23);
            this.TxtEmail.TabIndex = 6;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPw
            // 
            // 
            // 
            // 
            this.TxtPw.CustomButton.Image = null;
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(209, 237);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '\0';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(246, 23);
            this.TxtPw.TabIndex = 7;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(245, 329);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(150, 74);
            this.BtnLogin.TabIndex = 8;
            this.BtnLogin.Text = "Registrarse";
            this.BtnLogin.UseSelectable = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblPw2
            // 
            this.LblPw2.AutoSize = true;
            this.LblPw2.Location = new System.Drawing.Point(61, 283);
            this.LblPw2.Name = "LblPw2";
            this.LblPw2.Size = new System.Drawing.Size(142, 19);
            this.LblPw2.TabIndex = 9;
            this.LblPw2.Text = "Confirmar Contraseña:";
            // 
            // TxtPw2
            // 
            // 
            // 
            // 
            this.TxtPw2.CustomButton.Image = null;
            this.TxtPw2.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.TxtPw2.CustomButton.Name = "";
            this.TxtPw2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPw2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw2.CustomButton.TabIndex = 1;
            this.TxtPw2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw2.CustomButton.UseSelectable = true;
            this.TxtPw2.CustomButton.Visible = false;
            this.TxtPw2.Lines = new string[0];
            this.TxtPw2.Location = new System.Drawing.Point(209, 283);
            this.TxtPw2.MaxLength = 32767;
            this.TxtPw2.Name = "TxtPw2";
            this.TxtPw2.PasswordChar = '\0';
            this.TxtPw2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw2.SelectedText = "";
            this.TxtPw2.SelectionLength = 0;
            this.TxtPw2.SelectionStart = 0;
            this.TxtPw2.ShortcutsEnabled = true;
            this.TxtPw2.Size = new System.Drawing.Size(246, 23);
            this.TxtPw2.TabIndex = 10;
            this.TxtPw2.UseSelectable = true;
            this.TxtPw2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 424);
            this.Controls.Add(this.TxtPw2);
            this.Controls.Add(this.LblPw2);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblPw);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblLastName);
            this.Controls.Add(this.LblName);
            this.Name = "Form1";
            this.Text = "Registrarse";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblLastName;
        private MetroFramework.Controls.MetroLabel LblEmail;
        private MetroFramework.Controls.MetroLabel LblPw;
        private MetroFramework.Controls.MetroTextBox TxtName;
        private MetroFramework.Controls.MetroTextBox TxtLastName;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtPw;
        private MetroFramework.Controls.MetroButton BtnLogin;
        private MetroFramework.Controls.MetroLabel LblPw2;
        private MetroFramework.Controls.MetroTextBox TxtPw2;
    }
}

