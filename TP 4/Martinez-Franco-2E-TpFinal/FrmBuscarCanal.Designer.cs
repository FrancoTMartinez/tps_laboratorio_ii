
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmBuscarCanal
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
			this.txtCanalABuscar = new System.Windows.Forms.TextBox();
			this.lblCanalNuevo = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.lblInforme = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtCanalABuscar
			// 
			this.txtCanalABuscar.BackColor = System.Drawing.Color.LightGray;
			this.txtCanalABuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCanalABuscar.Location = new System.Drawing.Point(136, 77);
			this.txtCanalABuscar.Name = "txtCanalABuscar";
			this.txtCanalABuscar.Size = new System.Drawing.Size(100, 23);
			this.txtCanalABuscar.TabIndex = 1;
			// 
			// lblCanalNuevo
			// 
			this.lblCanalNuevo.AutoSize = true;
			this.lblCanalNuevo.ForeColor = System.Drawing.Color.White;
			this.lblCanalNuevo.Location = new System.Drawing.Point(77, 80);
			this.lblCanalNuevo.Name = "lblCanalNuevo";
			this.lblCanalNuevo.Size = new System.Drawing.Size(43, 15);
			this.lblCanalNuevo.TabIndex = 9;
			this.lblCanalNuevo.Text = "Canal :";
			// 
			// btnBuscar
			// 
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBuscar.Location = new System.Drawing.Point(260, 77);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(85, 23);
			this.btnBuscar.TabIndex = 4;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.FlatAppearance.BorderSize = 0;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(93, 175);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(85, 23);
			this.btnModificar.TabIndex = 2;
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
			this.btnEliminar.Location = new System.Drawing.Point(200, 175);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(85, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(151, 228);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 23);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// lblInforme
			// 
			this.lblInforme.AutoSize = true;
			this.lblInforme.Location = new System.Drawing.Point(136, 107);
			this.lblInforme.Name = "lblInforme";
			this.lblInforme.Size = new System.Drawing.Size(0, 15);
			this.lblInforme.TabIndex = 13;
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(363, 3);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(38, 15);
			this.lblId.TabIndex = 14;
			this.lblId.Text = "label1";
			this.lblId.Visible = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTitulo.Location = new System.Drawing.Point(127, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(121, 25);
			this.lblTitulo.TabIndex = 15;
			this.lblTitulo.Text = "Buscar Canal";
			// 
			// FrmBuscarCanal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(413, 310);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.lblInforme);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.txtCanalABuscar);
			this.Controls.Add(this.lblCanalNuevo);
			this.Controls.Add(this.btnBuscar);
			this.Name = "FrmBuscarCanal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Buscar Canal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtCanalABuscar;
		protected System.Windows.Forms.Label lblCanalNuevo;
		protected System.Windows.Forms.Button btnBuscar;
		protected System.Windows.Forms.Button btnModificar;
		protected System.Windows.Forms.Button btnEliminar;
		protected System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label lblInforme;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label lblTitulo;
	}
}