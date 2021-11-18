
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmLogIn
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblInforme = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsuario.Location = new System.Drawing.Point(137, 94);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 23);
			this.txtUsuario.TabIndex = 1;
			// 
			// lblUsuario
			// 
			this.lblUsuario.AutoSize = true;
			this.lblUsuario.ForeColor = System.Drawing.Color.White;
			this.lblUsuario.Location = new System.Drawing.Point(78, 97);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(53, 15);
			this.lblUsuario.TabIndex = 6;
			this.lblUsuario.Text = "Usuario :";
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(127, 257);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(119, 23);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAceptar.Location = new System.Drawing.Point(127, 228);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(119, 23);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.LightGray;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPassword.Location = new System.Drawing.Point(137, 140);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(100, 23);
			this.txtPassword.TabIndex = 2;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.ForeColor = System.Drawing.Color.White;
			this.lblPassword.Location = new System.Drawing.Point(72, 143);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(63, 15);
			this.lblPassword.TabIndex = 8;
			this.lblPassword.Text = "Password :";
			// 
			// lblInforme
			// 
			this.lblInforme.AutoSize = true;
			this.lblInforme.Location = new System.Drawing.Point(137, 184);
			this.lblInforme.Name = "lblInforme";
			this.lblInforme.Size = new System.Drawing.Size(20, 15);
			this.lblInforme.TabIndex = 10;
			this.lblInforme.Text = "lbl";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(108, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 21);
			this.label1.TabIndex = 11;
			this.label1.Text = "Ingrese Credenciales";
			// 
			// FrmLogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(384, 308);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblInforme);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Name = "FrmLogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LogIn Administradores";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtUsuario;
		protected System.Windows.Forms.Label lblUsuario;
		protected System.Windows.Forms.Button btnCancelar;
		protected System.Windows.Forms.Button btnAceptar;
		public System.Windows.Forms.TextBox txtPassword;
		protected System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Label lblInforme;
		private System.Windows.Forms.Label label1;
	}
}