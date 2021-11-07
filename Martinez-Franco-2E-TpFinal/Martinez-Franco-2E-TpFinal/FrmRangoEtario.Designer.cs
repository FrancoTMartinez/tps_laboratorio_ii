
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmRangoEtario
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
			this.txtEdadMin = new System.Windows.Forms.TextBox();
			this.lblEdad = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.lblErrorEdadMax = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblErrorEdadMin = new System.Windows.Forms.Label();
			this.txtEdadMax = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panelContenedor.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtEdadMin
			// 
			this.txtEdadMin.AccessibleDescription = "lblEdadMin";
			this.txtEdadMin.BackColor = System.Drawing.Color.LightGray;
			this.txtEdadMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEdadMin.Location = new System.Drawing.Point(119, 62);
			this.txtEdadMin.Name = "txtEdadMin";
			this.txtEdadMin.Size = new System.Drawing.Size(100, 23);
			this.txtEdadMin.TabIndex = 1;
			// 
			// lblEdad
			// 
			this.lblEdad.AccessibleDescription = "lblEdadMin";
			this.lblEdad.AutoSize = true;
			this.lblEdad.ForeColor = System.Drawing.Color.White;
			this.lblEdad.Location = new System.Drawing.Point(50, 64);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(63, 15);
			this.lblEdad.TabIndex = 8;
			this.lblEdad.Text = "Edad  Min:";
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(99, 195);
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
			this.btnAceptar.Location = new System.Drawing.Point(99, 166);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(119, 23);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Controls.Add(this.lblErrorEdadMax);
			this.panelContenedor.Controls.Add(this.label2);
			this.panelContenedor.Controls.Add(this.lblErrorEdadMin);
			this.panelContenedor.Controls.Add(this.txtEdadMax);
			this.panelContenedor.Controls.Add(this.label1);
			this.panelContenedor.Controls.Add(this.txtEdadMin);
			this.panelContenedor.Controls.Add(this.btnCancelar);
			this.panelContenedor.Controls.Add(this.lblEdad);
			this.panelContenedor.Controls.Add(this.btnAceptar);
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 0);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(428, 312);
			this.panelContenedor.TabIndex = 10;
			// 
			// lblErrorEdadMax
			// 
			this.lblErrorEdadMax.AutoSize = true;
			this.lblErrorEdadMax.Location = new System.Drawing.Point(119, 138);
			this.lblErrorEdadMax.Name = "lblErrorEdadMax";
			this.lblErrorEdadMax.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdadMax.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(155, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 15);
			this.label2.TabIndex = 13;
			// 
			// lblErrorEdadMin
			// 
			this.lblErrorEdadMin.AutoSize = true;
			this.lblErrorEdadMin.Location = new System.Drawing.Point(119, 85);
			this.lblErrorEdadMin.Name = "lblErrorEdadMin";
			this.lblErrorEdadMin.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdadMin.TabIndex = 12;
			// 
			// txtEdadMax
			// 
			this.txtEdadMax.AccessibleDescription = "lblEdadMax";
			this.txtEdadMax.BackColor = System.Drawing.Color.LightGray;
			this.txtEdadMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtEdadMax.Location = new System.Drawing.Point(118, 108);
			this.txtEdadMax.Name = "txtEdadMax";
			this.txtEdadMax.Size = new System.Drawing.Size(100, 23);
			this.txtEdadMax.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AccessibleDescription = "lblEdadMax";
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Edad  Max:";
			// 
			// FrmRangoEtario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(428, 312);
			this.Controls.Add(this.panelContenedor);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmRangoEtario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRangoEtario";
			this.panelContenedor.ResumeLayout(false);
			this.panelContenedor.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.TextBox txtEdadMin;
		protected System.Windows.Forms.Label lblEdad;
		protected System.Windows.Forms.Button btnCancelar;
		protected System.Windows.Forms.Button btnAceptar;
		protected System.Windows.Forms.Panel panelContenedor;
		public System.Windows.Forms.TextBox txtEdadMax;
		protected System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblErrorEdadMax;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblErrorEdadMin;
	}
}