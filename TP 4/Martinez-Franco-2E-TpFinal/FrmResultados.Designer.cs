
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmResultados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultados));
			this.panelMenuLateral = new System.Windows.Forms.Panel();
			this.panelCanal = new System.Windows.Forms.Panel();
			this.btnUnSoloCanal = new System.Windows.Forms.Button();
			this.btnTodos = new System.Windows.Forms.Button();
			this.panelLavel = new System.Windows.Forms.Panel();
			this.btnCanal = new System.Windows.Forms.Button();
			this.panelEdad = new System.Windows.Forms.Panel();
			this.btnRangoEtario = new System.Windows.Forms.Button();
			this.btnEdadEspecifica = new System.Windows.Forms.Button();
			this.btnEdad = new System.Windows.Forms.Button();
			this.panelGenero = new System.Windows.Forms.Panel();
			this.btnNoBinario = new System.Windows.Forms.Button();
			this.btnFemenino = new System.Windows.Forms.Button();
			this.btnMasculino = new System.Windows.Forms.Button();
			this.btnGenero = new System.Windows.Forms.Button();
			this.panelResultados = new System.Windows.Forms.Panel();
			this.btnRecargarArchivos = new System.Windows.Forms.Button();
			this.lblInforme = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.panelMenuLateral.SuspendLayout();
			this.panelCanal.SuspendLayout();
			this.panelEdad.SuspendLayout();
			this.panelGenero.SuspendLayout();
			this.panelResultados.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMenuLateral
			// 
			this.panelMenuLateral.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelMenuLateral.Controls.Add(this.panelCanal);
			this.panelMenuLateral.Controls.Add(this.panelLavel);
			this.panelMenuLateral.Controls.Add(this.btnCanal);
			this.panelMenuLateral.Controls.Add(this.panelEdad);
			this.panelMenuLateral.Controls.Add(this.btnEdad);
			this.panelMenuLateral.Controls.Add(this.panelGenero);
			this.panelMenuLateral.Controls.Add(this.btnGenero);
			this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
			this.panelMenuLateral.Name = "panelMenuLateral";
			this.panelMenuLateral.Size = new System.Drawing.Size(173, 463);
			this.panelMenuLateral.TabIndex = 0;
			// 
			// panelCanal
			// 
			this.panelCanal.BackColor = System.Drawing.SystemColors.GrayText;
			this.panelCanal.Controls.Add(this.btnUnSoloCanal);
			this.panelCanal.Controls.Add(this.btnTodos);
			this.panelCanal.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCanal.Location = new System.Drawing.Point(0, 425);
			this.panelCanal.Name = "panelCanal";
			this.panelCanal.Size = new System.Drawing.Size(173, 87);
			this.panelCanal.TabIndex = 7;
			// 
			// btnUnSoloCanal
			// 
			this.btnUnSoloCanal.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnUnSoloCanal.FlatAppearance.BorderSize = 0;
			this.btnUnSoloCanal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnUnSoloCanal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnUnSoloCanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUnSoloCanal.Location = new System.Drawing.Point(0, 40);
			this.btnUnSoloCanal.Name = "btnUnSoloCanal";
			this.btnUnSoloCanal.Size = new System.Drawing.Size(173, 40);
			this.btnUnSoloCanal.TabIndex = 5;
			this.btnUnSoloCanal.Text = "Un Solo Canal";
			this.btnUnSoloCanal.UseVisualStyleBackColor = true;
			this.btnUnSoloCanal.Click += new System.EventHandler(this.btnUnSoloCanal_Click);
			// 
			// btnTodos
			// 
			this.btnTodos.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnTodos.FlatAppearance.BorderSize = 0;
			this.btnTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTodos.Location = new System.Drawing.Point(0, 0);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(173, 40);
			this.btnTodos.TabIndex = 4;
			this.btnTodos.Text = "Todos";
			this.btnTodos.UseVisualStyleBackColor = true;
			this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
			// 
			// panelLavel
			// 
			this.panelLavel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelLavel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLavel.Location = new System.Drawing.Point(0, 363);
			this.panelLavel.Name = "panelLavel";
			this.panelLavel.Size = new System.Drawing.Size(173, 100);
			this.panelLavel.TabIndex = 3;
			// 
			// btnCanal
			// 
			this.btnCanal.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnCanal.FlatAppearance.BorderSize = 0;
			this.btnCanal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnCanal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnCanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCanal.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCanal.Location = new System.Drawing.Point(0, 355);
			this.btnCanal.Name = "btnCanal";
			this.btnCanal.Size = new System.Drawing.Size(173, 70);
			this.btnCanal.TabIndex = 6;
			this.btnCanal.Text = "Canal";
			this.btnCanal.UseVisualStyleBackColor = true;
			this.btnCanal.Click += new System.EventHandler(this.btnCanal_Click);
			// 
			// panelEdad
			// 
			this.panelEdad.BackColor = System.Drawing.SystemColors.GrayText;
			this.panelEdad.Controls.Add(this.btnRangoEtario);
			this.panelEdad.Controls.Add(this.btnEdadEspecifica);
			this.panelEdad.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelEdad.Location = new System.Drawing.Point(0, 264);
			this.panelEdad.Name = "panelEdad";
			this.panelEdad.Size = new System.Drawing.Size(173, 91);
			this.panelEdad.TabIndex = 5;
			// 
			// btnRangoEtario
			// 
			this.btnRangoEtario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnRangoEtario.FlatAppearance.BorderSize = 0;
			this.btnRangoEtario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnRangoEtario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnRangoEtario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRangoEtario.Location = new System.Drawing.Point(0, 40);
			this.btnRangoEtario.Name = "btnRangoEtario";
			this.btnRangoEtario.Size = new System.Drawing.Size(173, 40);
			this.btnRangoEtario.TabIndex = 1;
			this.btnRangoEtario.Text = "Rango Etario";
			this.btnRangoEtario.UseVisualStyleBackColor = true;
			this.btnRangoEtario.Click += new System.EventHandler(this.btnRangoEtario_Click);
			// 
			// btnEdadEspecifica
			// 
			this.btnEdadEspecifica.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdadEspecifica.FlatAppearance.BorderSize = 0;
			this.btnEdadEspecifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnEdadEspecifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnEdadEspecifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdadEspecifica.Location = new System.Drawing.Point(0, 0);
			this.btnEdadEspecifica.Name = "btnEdadEspecifica";
			this.btnEdadEspecifica.Size = new System.Drawing.Size(173, 40);
			this.btnEdadEspecifica.TabIndex = 0;
			this.btnEdadEspecifica.Text = "Especifica";
			this.btnEdadEspecifica.UseVisualStyleBackColor = true;
			this.btnEdadEspecifica.Click += new System.EventHandler(this.btnEdadEspecifica_Click);
			// 
			// btnEdad
			// 
			this.btnEdad.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdad.FlatAppearance.BorderSize = 0;
			this.btnEdad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnEdad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnEdad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdad.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEdad.Location = new System.Drawing.Point(0, 194);
			this.btnEdad.Name = "btnEdad";
			this.btnEdad.Size = new System.Drawing.Size(173, 70);
			this.btnEdad.TabIndex = 2;
			this.btnEdad.Text = "Edad";
			this.btnEdad.UseVisualStyleBackColor = true;
			this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
			// 
			// panelGenero
			// 
			this.panelGenero.BackColor = System.Drawing.SystemColors.GrayText;
			this.panelGenero.Controls.Add(this.btnNoBinario);
			this.panelGenero.Controls.Add(this.btnFemenino);
			this.panelGenero.Controls.Add(this.btnMasculino);
			this.panelGenero.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelGenero.ForeColor = System.Drawing.SystemColors.Desktop;
			this.panelGenero.Location = new System.Drawing.Point(0, 70);
			this.panelGenero.Name = "panelGenero";
			this.panelGenero.Size = new System.Drawing.Size(173, 124);
			this.panelGenero.TabIndex = 3;
			// 
			// btnNoBinario
			// 
			this.btnNoBinario.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnNoBinario.FlatAppearance.BorderSize = 0;
			this.btnNoBinario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnNoBinario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnNoBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNoBinario.Location = new System.Drawing.Point(0, 80);
			this.btnNoBinario.Name = "btnNoBinario";
			this.btnNoBinario.Size = new System.Drawing.Size(173, 38);
			this.btnNoBinario.TabIndex = 6;
			this.btnNoBinario.Text = "No Binario";
			this.btnNoBinario.UseVisualStyleBackColor = true;
			this.btnNoBinario.Click += new System.EventHandler(this.btnNoBinario_Click);
			// 
			// btnFemenino
			// 
			this.btnFemenino.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnFemenino.FlatAppearance.BorderSize = 0;
			this.btnFemenino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnFemenino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFemenino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFemenino.Location = new System.Drawing.Point(0, 40);
			this.btnFemenino.Name = "btnFemenino";
			this.btnFemenino.Size = new System.Drawing.Size(173, 40);
			this.btnFemenino.TabIndex = 5;
			this.btnFemenino.Text = "Femenino";
			this.btnFemenino.UseVisualStyleBackColor = true;
			this.btnFemenino.Click += new System.EventHandler(this.btnFemenino_Click);
			// 
			// btnMasculino
			// 
			this.btnMasculino.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMasculino.FlatAppearance.BorderSize = 0;
			this.btnMasculino.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnMasculino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnMasculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMasculino.Location = new System.Drawing.Point(0, 0);
			this.btnMasculino.Name = "btnMasculino";
			this.btnMasculino.Size = new System.Drawing.Size(173, 40);
			this.btnMasculino.TabIndex = 4;
			this.btnMasculino.Text = "Masculino";
			this.btnMasculino.UseVisualStyleBackColor = true;
			this.btnMasculino.Click += new System.EventHandler(this.btnMasculino_Click);
			// 
			// btnGenero
			// 
			this.btnGenero.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnGenero.FlatAppearance.BorderSize = 0;
			this.btnGenero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.btnGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGenero.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnGenero.Location = new System.Drawing.Point(0, 0);
			this.btnGenero.Name = "btnGenero";
			this.btnGenero.Size = new System.Drawing.Size(173, 70);
			this.btnGenero.TabIndex = 1;
			this.btnGenero.Text = "Genero";
			this.btnGenero.UseVisualStyleBackColor = true;
			this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
			// 
			// panelResultados
			// 
			this.panelResultados.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelResultados.Controls.Add(this.btnRecargarArchivos);
			this.panelResultados.Controls.Add(this.lblInforme);
			this.panelResultados.Controls.Add(this.lblResultado);
			this.panelResultados.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelResultados.Location = new System.Drawing.Point(173, 0);
			this.panelResultados.Name = "panelResultados";
			this.panelResultados.Size = new System.Drawing.Size(670, 463);
			this.panelResultados.TabIndex = 1;
			// 
			// btnRecargarArchivos
			// 
			this.btnRecargarArchivos.Location = new System.Drawing.Point(525, 410);
			this.btnRecargarArchivos.Name = "btnRecargarArchivos";
			this.btnRecargarArchivos.Size = new System.Drawing.Size(131, 23);
			this.btnRecargarArchivos.TabIndex = 2;
			this.btnRecargarArchivos.Text = "Recargar Archivos";
			this.btnRecargarArchivos.UseVisualStyleBackColor = true;
			this.btnRecargarArchivos.Visible = false;
			this.btnRecargarArchivos.Click += new System.EventHandler(this.btnRecargarArchivos_Click);
			// 
			// lblInforme
			// 
			this.lblInforme.AutoSize = true;
			this.lblInforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.lblInforme.Location = new System.Drawing.Point(15, 438);
			this.lblInforme.Name = "lblInforme";
			this.lblInforme.Size = new System.Drawing.Size(0, 15);
			this.lblInforme.TabIndex = 1;
			// 
			// lblResultado
			// 
			this.lblResultado.AutoSize = true;
			this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblResultado.Location = new System.Drawing.Point(15, 16);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(0, 30);
			this.lblResultado.TabIndex = 0;
			// 
			// FrmResultados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 463);
			this.Controls.Add(this.panelResultados);
			this.Controls.Add(this.panelMenuLateral);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(859, 502);
			this.Name = "FrmResultados";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resultados";
			this.Load += new System.EventHandler(this.FrmResultados_Load);
			this.panelMenuLateral.ResumeLayout(false);
			this.panelCanal.ResumeLayout(false);
			this.panelEdad.ResumeLayout(false);
			this.panelGenero.ResumeLayout(false);
			this.panelResultados.ResumeLayout(false);
			this.panelResultados.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenuLateral;
		private System.Windows.Forms.Panel panelGenero;
		private System.Windows.Forms.Button btnGenero;
		private System.Windows.Forms.Panel panelLavel;
		private System.Windows.Forms.Button btnMasculino;
		private System.Windows.Forms.Button btnFemenino;
		private System.Windows.Forms.Button btnNoBinario;
		private System.Windows.Forms.Panel panelEdad;
		private System.Windows.Forms.Button btnEdad;
		private System.Windows.Forms.Panel panelCanal;
		private System.Windows.Forms.Button btnUnSoloCanal;
		private System.Windows.Forms.Button btnTodos;
		private System.Windows.Forms.Button btnCanal;
		private System.Windows.Forms.Button btnRangoEtario;
		private System.Windows.Forms.Button btnEdadEspecifica;
		private System.Windows.Forms.Panel panelResultados;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblInforme;
		private System.Windows.Forms.Button btnRecargarArchivos;
	}
}