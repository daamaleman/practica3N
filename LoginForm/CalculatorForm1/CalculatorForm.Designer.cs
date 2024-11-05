namespace CalculatorForm1
{
    partial class CalculatorForm
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
            this.BtnSum = new MetroFramework.Controls.MetroButton();
            this.BtnSubs = new MetroFramework.Controls.MetroButton();
            this.BtnMult = new MetroFramework.Controls.MetroButton();
            this.BtnDiv = new MetroFramework.Controls.MetroButton();
            this.TxtNum1 = new System.Windows.Forms.NumericUpDown();
            this.TxtNum2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNum2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSum
            // 
            this.BtnSum.Location = new System.Drawing.Point(63, 251);
            this.BtnSum.Name = "BtnSum";
            this.BtnSum.Size = new System.Drawing.Size(86, 50);
            this.BtnSum.TabIndex = 2;
            this.BtnSum.Text = "Suma";
            this.BtnSum.UseSelectable = true;
            this.BtnSum.Click += new System.EventHandler(this.BtnSum_Click);
            // 
            // BtnSubs
            // 
            this.BtnSubs.Location = new System.Drawing.Point(190, 251);
            this.BtnSubs.Name = "BtnSubs";
            this.BtnSubs.Size = new System.Drawing.Size(86, 50);
            this.BtnSubs.TabIndex = 3;
            this.BtnSubs.Text = "Resta";
            this.BtnSubs.UseSelectable = true;
            this.BtnSubs.Click += new System.EventHandler(this.BtnSubs_Click);
            // 
            // BtnMult
            // 
            this.BtnMult.Location = new System.Drawing.Point(63, 334);
            this.BtnMult.Name = "BtnMult";
            this.BtnMult.Size = new System.Drawing.Size(86, 50);
            this.BtnMult.TabIndex = 4;
            this.BtnMult.Text = "Multiplicacion";
            this.BtnMult.UseSelectable = true;
            this.BtnMult.Click += new System.EventHandler(this.BtnMult_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(190, 334);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(86, 50);
            this.BtnDiv.TabIndex = 5;
            this.BtnDiv.Text = "Division";
            this.BtnDiv.UseSelectable = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(116, 108);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(120, 20);
            this.TxtNum1.TabIndex = 6;
            this.TxtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(116, 165);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(120, 20);
            this.TxtNum2.TabIndex = 7;
            this.TxtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 460);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMult);
            this.Controls.Add(this.BtnSubs);
            this.Controls.Add(this.BtnSum);
            this.Name = "CalculatorForm";
            this.Text = "Calculadora";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.TxtNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNum2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BtnSum;
        private MetroFramework.Controls.MetroButton BtnSubs;
        private MetroFramework.Controls.MetroButton BtnMult;
        private MetroFramework.Controls.MetroButton BtnDiv;
        private System.Windows.Forms.NumericUpDown TxtNum1;
        private System.Windows.Forms.NumericUpDown TxtNum2;
    }
}

