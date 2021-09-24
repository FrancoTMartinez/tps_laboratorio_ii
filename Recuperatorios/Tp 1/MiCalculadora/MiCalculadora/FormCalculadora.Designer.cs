
namespace MiCalculadora
{
	partial class FormCalculadora
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbBoxOperando = new System.Windows.Forms.ComboBox();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnOperar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnConvertirABinaro = new System.Windows.Forms.Button();
			this.btnConvertirADecimal = new System.Windows.Forms.Button();
			this.listBoxHistorial = new System.Windows.Forms.ListBox();
			this.lblResultado = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbBoxOperando
			// 
			this.cmbBoxOperando.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
			this.cmbBoxOperando.AllowDrop = true;
			this.cmbBoxOperando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBoxOperando.FormattingEnabled = true;
			this.cmbBoxOperando.ItemHeight = 15;
			this.cmbBoxOperando.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
			this.cmbBoxOperando.Location = new System.Drawing.Point(166, 50);
			this.cmbBoxOperando.Name = "cmbBoxOperando";
			this.cmbBoxOperando.Size = new System.Drawing.Size(71, 23);
			this.cmbBoxOperando.TabIndex = 2;
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(33, 50);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 23);
			this.txtNumero1.TabIndex = 1;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(278, 50);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(99, 23);
			this.txtNumero2.TabIndex = 3;
			// 
			// btnOperar
			// 
			this.btnOperar.Location = new System.Drawing.Point(33, 95);
			this.btnOperar.Name = "btnOperar";
			this.btnOperar.Size = new System.Drawing.Size(99, 28);
			this.btnOperar.TabIndex = 4;
			this.btnOperar.Text = "Operar";
			this.btnOperar.UseVisualStyleBackColor = true;
			this.btnOperar.Click += new System.EventHandler(this.OperarNumeros);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(153, 95);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(99, 28);
			this.btnLimpiar.TabIndex = 5;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.Limpiar);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Location = new System.Drawing.Point(278, 95);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(99, 28);
			this.btnCerrar.TabIndex = 6;
			this.btnCerrar.Text = "Cerrar";
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.Cerrar);
			// 
			// btnConvertirABinaro
			// 
			this.btnConvertirABinaro.Location = new System.Drawing.Point(33, 148);
			this.btnConvertirABinaro.Name = "btnConvertirABinaro";
			this.btnConvertirABinaro.Size = new System.Drawing.Size(166, 28);
			this.btnConvertirABinaro.TabIndex = 7;
			this.btnConvertirABinaro.Text = "Convertir a Binario";
			this.btnConvertirABinaro.UseVisualStyleBackColor = true;
			this.btnConvertirABinaro.Click += new System.EventHandler(this.ConvertirABinario);
			// 
			// btnConvertirADecimal
			// 
			this.btnConvertirADecimal.Location = new System.Drawing.Point(205, 148);
			this.btnConvertirADecimal.Name = "btnConvertirADecimal";
			this.btnConvertirADecimal.Size = new System.Drawing.Size(171, 28);
			this.btnConvertirADecimal.TabIndex = 8;
			this.btnConvertirADecimal.Text = "Converitr a Decimal";
			this.btnConvertirADecimal.UseVisualStyleBackColor = true;
			this.btnConvertirADecimal.Click += new System.EventHandler(this.ConvertirADecimal);
			// 
			// listBoxHistorial
			// 
			this.listBoxHistorial.FormattingEnabled = true;
			this.listBoxHistorial.ItemHeight = 15;
			this.listBoxHistorial.Location = new System.Drawing.Point(400, 19);
			this.listBoxHistorial.Name = "listBoxHistorial";
			this.listBoxHistorial.Size = new System.Drawing.Size(211, 154);
			this.listBoxHistorial.TabIndex = 8;
			this.listBoxHistorial.TabStop = false;
			this.listBoxHistorial.UseTabStops = false;
			// 
			// lblResultado
			// 
			this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblResultado.Location = new System.Drawing.Point(33, 9);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblResultado.Size = new System.Drawing.Size(343, 25);
			this.lblResultado.TabIndex = 9;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormCalculadora
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 214);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.listBoxHistorial);
			this.Controls.Add(this.btnConvertirADecimal);
			this.Controls.Add(this.btnConvertirABinaro);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnOperar);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.cmbBoxOperando);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCalculadora";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculadora de Franco Tobias Martinez 2E";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCalculadora_FormClosing);
			this.Load += new System.EventHandler(this.Limpiar);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbBoxOperando;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.Button btnOperar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnConvertirABinaro;
		private System.Windows.Forms.Button btnConvertirADecimal;
		private System.Windows.Forms.ListBox listBoxHistorial;
		private System.Windows.Forms.Label lblResultado;
	}
}

