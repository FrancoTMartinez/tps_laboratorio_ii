
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmElegirCanal
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(116, 325);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(119, 23);
			this.btnCancelar.TabIndex = 9;
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
			this.btnAceptar.Location = new System.Drawing.Point(363, 325);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(119, 23);
			this.btnAceptar.TabIndex = 8;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTitulo.Location = new System.Drawing.Point(223, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(142, 21);
			this.lblTitulo.TabIndex = 10;
			this.lblTitulo.Text = "Seleccione el Canal";
			// 
			// FrmElegirCanal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(664, 395);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimumSize = new System.Drawing.Size(680, 434);
			this.Name = "FrmElegirCanal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Elegir Canal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		protected System.Windows.Forms.Button btnCancelar;
		protected System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblTitulo;
	}
}