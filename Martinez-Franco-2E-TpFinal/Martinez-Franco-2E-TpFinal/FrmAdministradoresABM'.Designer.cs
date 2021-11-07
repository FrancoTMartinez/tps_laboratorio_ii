
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmAdministradoresABM_
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
			this.txtBoxDni = new System.Windows.Forms.TextBox();
			this.txtBoxUser = new System.Windows.Forms.TextBox();
			this.txtBoxPassword = new System.Windows.Forms.TextBox();
			this.lblDNI = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.lblInforme = new System.Windows.Forms.Label();
			this.lblInforme2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtBoxDni
			// 
			this.txtBoxDni.Location = new System.Drawing.Point(235, 85);
			this.txtBoxDni.Name = "txtBoxDni";
			this.txtBoxDni.Size = new System.Drawing.Size(100, 23);
			this.txtBoxDni.TabIndex = 1;
			// 
			// txtBoxUser
			// 
			this.txtBoxUser.Location = new System.Drawing.Point(235, 137);
			this.txtBoxUser.Name = "txtBoxUser";
			this.txtBoxUser.Size = new System.Drawing.Size(100, 23);
			this.txtBoxUser.TabIndex = 2;
			// 
			// txtBoxPassword
			// 
			this.txtBoxPassword.Location = new System.Drawing.Point(235, 184);
			this.txtBoxPassword.Name = "txtBoxPassword";
			this.txtBoxPassword.Size = new System.Drawing.Size(100, 23);
			this.txtBoxPassword.TabIndex = 3;
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblDNI.Location = new System.Drawing.Point(112, 85);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(33, 15);
			this.lblDNI.TabIndex = 3;
			this.lblDNI.Text = "DNI :";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblUser.Location = new System.Drawing.Point(112, 137);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(53, 15);
			this.lblUser.TabIndex = 4;
			this.lblUser.Text = "Usuario :";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblPassword.Location = new System.Drawing.Point(112, 184);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(63, 15);
			this.lblPassword.TabIndex = 5;
			this.lblPassword.Text = "Password :";
			// 
			// btnAgregar
			// 
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAgregar.Location = new System.Drawing.Point(173, 274);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(104, 23);
			this.btnAgregar.TabIndex = 4;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(283, 274);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(105, 23);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEliminar.Location = new System.Drawing.Point(220, 325);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(119, 23);
			this.btnEliminar.TabIndex = 6;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBuscar.Location = new System.Drawing.Point(350, 85);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(119, 23);
			this.btnBuscar.TabIndex = 7;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// lblInforme
			// 
			this.lblInforme.AutoSize = true;
			this.lblInforme.ForeColor = System.Drawing.Color.Black;
			this.lblInforme.Location = new System.Drawing.Point(235, 115);
			this.lblInforme.Name = "lblInforme";
			this.lblInforme.Size = new System.Drawing.Size(0, 15);
			this.lblInforme.TabIndex = 14;
			// 
			// lblInforme2
			// 
			this.lblInforme2.AutoSize = true;
			this.lblInforme2.Location = new System.Drawing.Point(13, 371);
			this.lblInforme2.Name = "lblInforme2";
			this.lblInforme2.Size = new System.Drawing.Size(0, 15);
			this.lblInforme2.TabIndex = 15;
			// 
			// FrmAdministradoresABM_
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(553, 398);
			this.Controls.Add(this.lblInforme2);
			this.Controls.Add(this.lblInforme);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.txtBoxPassword);
			this.Controls.Add(this.txtBoxUser);
			this.Controls.Add(this.txtBoxDni);
			this.Name = "FrmAdministradoresABM_";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmAdministradoresABM_";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBoxDni;
		private System.Windows.Forms.TextBox txtBoxUser;
		private System.Windows.Forms.TextBox txtBoxPassword;
		private System.Windows.Forms.Label lblDNI;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.Label lblPassword;
		protected System.Windows.Forms.Button btnAgregar;
		protected System.Windows.Forms.Button btnModificar;
		protected System.Windows.Forms.Button btnEliminar;
		protected System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Label lblInforme;
		private System.Windows.Forms.Label lblInforme2;
	}
}