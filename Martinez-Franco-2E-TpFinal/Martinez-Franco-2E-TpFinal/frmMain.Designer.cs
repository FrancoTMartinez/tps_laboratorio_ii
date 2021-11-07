
namespace Martinez_Franco_2E_TpFinal
{
	partial class frmMain
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
			this.btnResultados = new System.Windows.Forms.Button();
			this.btnVotar = new System.Windows.Forms.Button();
			this.btnAdmin = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnResultados
			// 
			this.btnResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnResultados.Location = new System.Drawing.Point(131, 208);
			this.btnResultados.Name = "btnResultados";
			this.btnResultados.Size = new System.Drawing.Size(75, 23);
			this.btnResultados.TabIndex = 0;
			this.btnResultados.Text = "Resultados";
			this.btnResultados.UseVisualStyleBackColor = true;
			this.btnResultados.Click += new System.EventHandler(this.btnResultados_Click);
			// 
			// btnVotar
			// 
			this.btnVotar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVotar.Location = new System.Drawing.Point(300, 207);
			this.btnVotar.Name = "btnVotar";
			this.btnVotar.Size = new System.Drawing.Size(75, 23);
			this.btnVotar.TabIndex = 1;
			this.btnVotar.Text = "Votar";
			this.btnVotar.UseVisualStyleBackColor = true;
			this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
			// 
			// btnAdmin
			// 
			this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdmin.Location = new System.Drawing.Point(406, 365);
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.Size = new System.Drawing.Size(99, 23);
			this.btnAdmin.TabIndex = 2;
			this.btnAdmin.Text = "Administrador";
			this.btnAdmin.UseVisualStyleBackColor = true;
			this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitulo.Location = new System.Drawing.Point(131, 46);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(239, 22);
			this.lblTitulo.TabIndex = 3;
			this.lblTitulo.Text = "Encuesta Nacional de Television";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(506, 389);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnAdmin);
			this.Controls.Add(this.btnVotar);
			this.Controls.Add(this.btnResultados);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.MaximumSize = new System.Drawing.Size(522, 428);
			this.MinimumSize = new System.Drawing.Size(522, 428);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnResultados;
		private System.Windows.Forms.Button btnVotar;
		private System.Windows.Forms.Button btnAdmin;
		private System.Windows.Forms.Label lblTitulo;
	}
}

