
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmModificar
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
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.lblDni = new System.Windows.Forms.Label();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(181, 74);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(133, 23);
			this.txtDNI.TabIndex = 1;
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.Location = new System.Drawing.Point(9, 77);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(166, 15);
			this.lblDni.TabIndex = 6;
			this.lblDni.Text = "DNI de la persona a modificar:";
			// 
			// btnAceptar
			// 
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAceptar.Location = new System.Drawing.Point(156, 163);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(100, 23);
			this.btnAceptar.TabIndex = 2;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(181, 100);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(0, 15);
			this.lblError.TabIndex = 13;
			this.lblError.Visible = false;
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(172, 192);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(71, 23);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// FrmModificar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(452, 234);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.lblDni);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.Name = "FrmModificar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Persona";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Button btnCancelar;
	}
}