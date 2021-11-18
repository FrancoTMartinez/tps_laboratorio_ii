
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
			this.btnAceptar = new System.Windows.Forms.Button();
			this.lblEdad = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblErrorEdadMin = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblErrorEdadMax = new System.Windows.Forms.Label();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.cmBoxEdadMax = new System.Windows.Forms.ComboBox();
			this.cmBoxEdadMin = new System.Windows.Forms.ComboBox();
			this.lblTitulo = new System.Windows.Forms.Label();
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
			this.btnAceptar.Location = new System.Drawing.Point(99, 185);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(119, 23);
			this.btnAceptar.TabIndex = 3;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// lblEdad
			// 
			this.lblEdad.AccessibleDescription = "lblEdadMin";
			this.lblEdad.AutoSize = true;
			this.lblEdad.ForeColor = System.Drawing.Color.White;
			this.lblEdad.Location = new System.Drawing.Point(50, 83);
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
			this.btnCancelar.Location = new System.Drawing.Point(99, 214);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(119, 23);
			this.btnCancelar.TabIndex = 4;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// label1
			// 
			this.label1.AccessibleDescription = "lblEdadMax";
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(49, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Edad  Max:";
			// 
			// lblErrorEdadMin
			// 
			this.lblErrorEdadMin.AutoSize = true;
			this.lblErrorEdadMin.Location = new System.Drawing.Point(119, 104);
			this.lblErrorEdadMin.Name = "lblErrorEdadMin";
			this.lblErrorEdadMin.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdadMin.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(155, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 15);
			this.label2.TabIndex = 13;
			// 
			// lblErrorEdadMax
			// 
			this.lblErrorEdadMax.AutoSize = true;
			this.lblErrorEdadMax.Location = new System.Drawing.Point(119, 157);
			this.lblErrorEdadMax.Name = "lblErrorEdadMax";
			this.lblErrorEdadMax.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdadMax.TabIndex = 14;
			// 
			// panelContenedor
			// 
			this.panelContenedor.Controls.Add(this.lblTitulo);
			this.panelContenedor.Controls.Add(this.cmBoxEdadMin);
			this.panelContenedor.Controls.Add(this.cmBoxEdadMax);
			this.panelContenedor.Controls.Add(this.lblErrorEdadMax);
			this.panelContenedor.Controls.Add(this.label2);
			this.panelContenedor.Controls.Add(this.lblErrorEdadMin);
			this.panelContenedor.Controls.Add(this.label1);
			this.panelContenedor.Controls.Add(this.btnCancelar);
			this.panelContenedor.Controls.Add(this.lblEdad);
			this.panelContenedor.Controls.Add(this.btnAceptar);
			this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContenedor.Location = new System.Drawing.Point(0, 0);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(428, 312);
			this.panelContenedor.TabIndex = 10;
			// 
			// cmBoxEdadMax
			// 
			this.cmBoxEdadMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmBoxEdadMax.FormattingEnabled = true;
			this.cmBoxEdadMax.Items.AddRange(new object[] {
            "30",
            "35",
            "37",
            "48",
            "50"});
			this.cmBoxEdadMax.Location = new System.Drawing.Point(117, 126);
			this.cmBoxEdadMax.Name = "cmBoxEdadMax";
			this.cmBoxEdadMax.Size = new System.Drawing.Size(101, 23);
			this.cmBoxEdadMax.TabIndex = 15;
			// 
			// cmBoxEdadMin
			// 
			this.cmBoxEdadMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmBoxEdadMin.FormattingEnabled = true;
			this.cmBoxEdadMin.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21"});
			this.cmBoxEdadMin.Location = new System.Drawing.Point(117, 80);
			this.cmBoxEdadMin.Name = "cmBoxEdadMin";
			this.cmBoxEdadMin.Size = new System.Drawing.Size(101, 23);
			this.cmBoxEdadMin.TabIndex = 16;
			// 
			// lblTitulo
			// 
			this.lblTitulo.AutoSize = true;
			this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblTitulo.Location = new System.Drawing.Point(99, 19);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(238, 25);
			this.lblTitulo.TabIndex = 17;
			this.lblTitulo.Text = "Seleccione un rango etario";
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

		protected System.Windows.Forms.Button btnAceptar;
		protected System.Windows.Forms.Label lblEdad;
		protected System.Windows.Forms.Button btnCancelar;
		protected System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblErrorEdadMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblErrorEdadMax;
		protected System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.Label lblTitulo;
		public System.Windows.Forms.ComboBox cmBoxEdadMax;
		public System.Windows.Forms.ComboBox cmBoxEdadMin;
	}
}