
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmEdad
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
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblEdad = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.lblErrorEdad = new System.Windows.Forms.Label();
			this.panelContenedor.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAceptar
			// 
			this.btnAceptar.FlatAppearance.BorderSize = 0;
			this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAceptar.Location = new System.Drawing.Point(84, 128);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(119, 23);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(84, 157);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(119, 23);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.ForeColor = System.Drawing.Color.White;
			this.lblEdad.Location = new System.Drawing.Point(34, 61);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(39, 15);
			this.lblEdad.TabIndex = 2;
			this.lblEdad.Text = "Edad :";
			// 
			// txtEdad
			// 
			this.txtEdad.BackColor = System.Drawing.Color.LightGray;
			this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEdad.Location = new System.Drawing.Point(93, 58);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 23);
			this.txtEdad.TabIndex = 1;
			this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Controls.Add(this.lblErrorEdad);
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 0);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(287, 196);
			this.panelContenedor.TabIndex = 5;
			this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
			// 
			// lblErrorEdad
			// 
			this.lblErrorEdad.AutoSize = true;
			this.lblErrorEdad.Location = new System.Drawing.Point(93, 88);
			this.lblErrorEdad.Name = "lblErrorEdad";
			this.lblErrorEdad.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdad.TabIndex = 0;
			// 
			// FrmEdad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(287, 196);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.lblEdad);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.panelContenedor);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmEdad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmEdad";
			this.panelContenedor.ResumeLayout(false);
			this.panelContenedor.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.TextBox txtEdad;
		protected System.Windows.Forms.Panel panelContenedor;
		protected System.Windows.Forms.Button btnAceptar;
		protected System.Windows.Forms.Button btnCancelar;
		protected System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.Label lblErrorEdad;
	}
}