namespace LoginForm
{
    partial class LoginForm
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
            this.TxtUser = new MetroFramework.Controls.MetroTextBox();
            this.LblPw = new MetroFramework.Controls.MetroLabel();
            this.TxtPw = new MetroFramework.Controls.MetroTextBox();
            this.BtnIniciar = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(347, 96);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(59, 20);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Usuario:";
            // 
            // TxtUser
            // 
            // 
            // 
            // 
            this.TxtUser.CustomButton.Image = null;
            this.TxtUser.CustomButton.Location = new System.Drawing.Point(144, 1);
            this.TxtUser.CustomButton.Name = "";
            this.TxtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUser.CustomButton.TabIndex = 1;
            this.TxtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUser.CustomButton.UseSelectable = true;
            this.TxtUser.CustomButton.Visible = false;
            this.TxtUser.Lines = new string[0];
            this.TxtUser.Location = new System.Drawing.Point(417, 93);
            this.TxtUser.MaxLength = 32767;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.PasswordChar = '\0';
            this.TxtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUser.SelectedText = "";
            this.TxtUser.SelectionLength = 0;
            this.TxtUser.SelectionStart = 0;
            this.TxtUser.ShortcutsEnabled = true;
            this.TxtUser.Size = new System.Drawing.Size(166, 23);
            this.TxtUser.TabIndex = 1;
            this.TxtUser.UseSelectable = true;
            this.TxtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LblPw
            // 
            this.LblPw.AutoSize = true;
            this.LblPw.Location = new System.Drawing.Point(329, 160);
            this.LblPw.Name = "LblPw";
            this.LblPw.Size = new System.Drawing.Size(82, 20);
            this.LblPw.TabIndex = 2;
            this.LblPw.Text = "Contraseña:";
            // 
            // TxtPw
            // 
            // 
            // 
            // 
            this.TxtPw.CustomButton.Image = null;
            this.TxtPw.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.TxtPw.CustomButton.Name = "";
            this.TxtPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPw.CustomButton.TabIndex = 1;
            this.TxtPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPw.CustomButton.UseSelectable = true;
            this.TxtPw.CustomButton.Visible = false;
            this.TxtPw.Lines = new string[0];
            this.TxtPw.Location = new System.Drawing.Point(417, 160);
            this.TxtPw.MaxLength = 32767;
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '$';
            this.TxtPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPw.SelectedText = "";
            this.TxtPw.SelectionLength = 0;
            this.TxtPw.SelectionStart = 0;
            this.TxtPw.ShortcutsEnabled = true;
            this.TxtPw.Size = new System.Drawing.Size(163, 23);
            this.TxtPw.TabIndex = 3;
            this.TxtPw.UseSelectable = true;
            this.TxtPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.BackgroundImage = global::LoginForm.Properties.Resources.okbuttom;
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnIniciar.Location = new System.Drawing.Point(414, 236);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(151, 99);
            this.BtnIniciar.TabIndex = 4;
            this.BtnIniciar.UseSelectable = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Cyan;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(238, 348);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 428);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.LblPw);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.LblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Inicio de Sesion";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroTextBox TxtUser;
        private MetroFramework.Controls.MetroLabel LblPw;
        private MetroFramework.Controls.MetroTextBox TxtPw;
        private MetroFramework.Controls.MetroButton BtnIniciar;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}

