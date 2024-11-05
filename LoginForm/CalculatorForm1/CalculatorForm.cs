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
using MetroFramework.Controls;

namespace CalculatorForm1
{
    public partial class CalculatorForm : MetroFramework.Forms.MetroForm
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TxtNum1.Text);
            int num2 = int.Parse(TxtNum2.Text);
            int sum = num1 + num2;

            MetroMessageBox.Show(this, $"La suma de {num1} + {num2} es {sum}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtNum1.Focus();
        }

        private void BtnSubs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNum1.Text) || string.IsNullOrEmpty(TxtNum2.Text))
            {
                MessageBox.Show("Ingrese los 2 numeros");
                return;
            }

            int num1 = int.Parse(TxtNum1.Text);
            int num2 = int.Parse(TxtNum2.Text);
            int subs = num1 - num2;

            MetroMessageBox.Show(this, $"La resta de {num1} - {num2} es {subs}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtNum1.Focus();
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNum1.Text) || string.IsNullOrEmpty(TxtNum2.Text))
            {
                MessageBox.Show("Ingrese los 2 numeros");
                return;
            }

            int num1 = int.Parse(TxtNum1.Text);
            int num2 = int.Parse(TxtNum2.Text);
            int mult = num1 * num2;

            MetroMessageBox.Show(this, $"La multiplicacion de {num1} * {num2} es {mult}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtNum1.Focus();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNum1.Text) || string.IsNullOrEmpty(TxtNum2.Text))
            {
                MessageBox.Show("Ingrese los 2 numeros");
                return;
            }

            int num1 = int.Parse(TxtNum1.Text);
            int num2 = int.Parse(TxtNum2.Text);

            if (num2 == 0)
            {
                MetroMessageBox.Show(this, "No se puede dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int mult = num1 / num2;

            MetroMessageBox.Show(this, $"La division de {num1} / {num2} es {mult}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TxtNum1.Focus();
        }

        private bool ValidarNumeros(MetroTextBox metroText)
        {
            if (string.IsNullOrEmpty(metroText.Text))
            {
                MessageBox.Show("Ingrese un numero");
                return false;
            }

            if (!int.TryParse(metroText.Text, out int num))
            {
                MessageBox.Show("Ingrese un numero valido");
                return false;
            }

            return true;
        }
    }
}
