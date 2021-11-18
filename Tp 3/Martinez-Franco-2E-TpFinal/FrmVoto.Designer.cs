
namespace Martinez_Franco_2E_TpFinal
{
	partial class FrmVoto
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVoto));
			this.lblDni = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.lblEdad = new System.Windows.Forms.Label();
			this.lblGenero = new System.Windows.Forms.Label();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnEligirCanal = new System.Windows.Forms.Button();
			this.btnBuscarPorDni = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.lblID = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.lblErrorDni = new System.Windows.Forms.Label();
			this.lblErrorNombre = new System.Windows.Forms.Label();
			this.lblErrorEdad = new System.Windows.Forms.Label();
			this.lblErrorApellido = new System.Windows.Forms.Label();
			this.lblGeneroError = new System.Windows.Forms.Label();
			this.lblErrorOperacion = new System.Windows.Forms.Label();
			this.lblErrorElegirCanal = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDni
			// 
			this.lblDni.AutoSize = true;
			this.lblDni.Location = new System.Drawing.Point(12, 94);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(33, 15);
			this.lblDni.TabIndex = 0;
			this.lblDni.Text = "DNI :";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(12, 141);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(57, 15);
			this.lblNombre.TabIndex = 1;
			this.lblNombre.Text = "Nombre :";
			// 
			// lblApellido
			// 
			this.lblApellido.AutoSize = true;
			this.lblApellido.Location = new System.Drawing.Point(12, 186);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(57, 15);
			this.lblApellido.TabIndex = 2;
			this.lblApellido.Text = "Apellido :";
			// 
			// lblEdad
			// 
			this.lblEdad.AutoSize = true;
			this.lblEdad.Location = new System.Drawing.Point(12, 232);
			this.lblEdad.Name = "lblEdad";
			this.lblEdad.Size = new System.Drawing.Size(39, 15);
			this.lblEdad.TabIndex = 3;
			this.lblEdad.Text = "Edad :";
			// 
			// lblGenero
			// 
			this.lblGenero.AutoSize = true;
			this.lblGenero.Location = new System.Drawing.Point(12, 277);
			this.lblGenero.Name = "lblGenero";
			this.lblGenero.Size = new System.Drawing.Size(51, 15);
			this.lblGenero.TabIndex = 4;
			this.lblGenero.Text = "Genero :";
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(120, 88);
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(100, 23);
			this.txtDNI.TabIndex = 1;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(120, 135);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 23);
			this.txtNombre.TabIndex = 2;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(120, 180);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(100, 23);
			this.txtApellido.TabIndex = 3;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(120, 226);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 23);
			this.txtEdad.TabIndex = 4;
			// 
			// cmbGenero
			// 
			this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbGenero.FormattingEnabled = true;
			this.cmbGenero.Items.AddRange(new object[] {
            "masculino",
            "femenino",
            "no binario"});
			this.cmbGenero.Location = new System.Drawing.Point(120, 274);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(100, 23);
			this.cmbGenero.TabIndex = 5;
			// 
			// btnAceptar
			// 
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAceptar.Location = new System.Drawing.Point(12, 405);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(60, 23);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Agregar";
			this.btnAceptar.UseMnemonic = false;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnCancelar.Location = new System.Drawing.Point(345, 406);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(72, 23);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnEligirCanal
			// 
			this.btnEligirCanal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btnEligirCanal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnEligirCanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEligirCanal.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEligirCanal.Location = new System.Drawing.Point(74, 319);
			this.btnEligirCanal.Name = "btnEligirCanal";
			this.btnEligirCanal.Size = new System.Drawing.Size(162, 29);
			this.btnEligirCanal.TabIndex = 6;
			this.btnEligirCanal.Text = "ElegirCanal";
			this.btnEligirCanal.UseVisualStyleBackColor = true;
			this.btnEligirCanal.Click += new System.EventHandler(this.btnEligirCanal_Click);
			// 
			// btnBuscarPorDni
			// 
			this.btnBuscarPorDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarPorDni.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnBuscarPorDni.Location = new System.Drawing.Point(291, 377);
			this.btnBuscarPorDni.Name = "btnBuscarPorDni";
			this.btnBuscarPorDni.Size = new System.Drawing.Size(126, 23);
			this.btnBuscarPorDni.TabIndex = 10;
			this.btnBuscarPorDni.Text = "Buscar por DNI";
			this.btnBuscarPorDni.UseVisualStyleBackColor = true;
			this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnModificar.Location = new System.Drawing.Point(78, 405);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(72, 23);
			this.btnModificar.TabIndex = 8;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(12, 76);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(17, 15);
			this.lblID.TabIndex = 16;
			this.lblID.Text = "id";
			this.lblID.Visible = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEliminar.Location = new System.Drawing.Point(156, 405);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(72, 23);
			this.btnEliminar.TabIndex = 9;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// lblErrorDni
			// 
			this.lblErrorDni.AutoSize = true;
			this.lblErrorDni.Location = new System.Drawing.Point(120, 114);
			this.lblErrorDni.Name = "lblErrorDni";
			this.lblErrorDni.Size = new System.Drawing.Size(0, 15);
			this.lblErrorDni.TabIndex = 18;
			// 
			// lblErrorNombre
			// 
			this.lblErrorNombre.AutoSize = true;
			this.lblErrorNombre.Location = new System.Drawing.Point(120, 159);
			this.lblErrorNombre.Name = "lblErrorNombre";
			this.lblErrorNombre.Size = new System.Drawing.Size(0, 15);
			this.lblErrorNombre.TabIndex = 19;
			// 
			// lblErrorEdad
			// 
			this.lblErrorEdad.AutoSize = true;
			this.lblErrorEdad.Location = new System.Drawing.Point(120, 256);
			this.lblErrorEdad.Name = "lblErrorEdad";
			this.lblErrorEdad.Size = new System.Drawing.Size(0, 15);
			this.lblErrorEdad.TabIndex = 20;
			// 
			// lblErrorApellido
			// 
			this.lblErrorApellido.AutoSize = true;
			this.lblErrorApellido.Location = new System.Drawing.Point(120, 208);
			this.lblErrorApellido.Name = "lblErrorApellido";
			this.lblErrorApellido.Size = new System.Drawing.Size(0, 15);
			this.lblErrorApellido.TabIndex = 21;
			// 
			// lblGeneroError
			// 
			this.lblGeneroError.AutoSize = true;
			this.lblGeneroError.Location = new System.Drawing.Point(120, 304);
			this.lblGeneroError.Name = "lblGeneroError";
			this.lblGeneroError.Size = new System.Drawing.Size(0, 15);
			this.lblGeneroError.TabIndex = 22;
			// 
			// lblErrorOperacion
			// 
			this.lblErrorOperacion.AutoSize = true;
			this.lblErrorOperacion.Location = new System.Drawing.Point(156, 384);
			this.lblErrorOperacion.Name = "lblErrorOperacion";
			this.lblErrorOperacion.Size = new System.Drawing.Size(0, 15);
			this.lblErrorOperacion.TabIndex = 23;
			// 
			// lblErrorElegirCanal
			// 
			this.lblErrorElegirCanal.AutoSize = true;
			this.lblErrorElegirCanal.Location = new System.Drawing.Point(74, 351);
			this.lblErrorElegirCanal.Name = "lblErrorElegirCanal";
			this.lblErrorElegirCanal.Size = new System.Drawing.Size(0, 15);
			this.lblErrorElegirCanal.TabIndex = 24;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(56, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 37);
			this.label1.TabIndex = 25;
			this.label1.Text = "Registro de Votacion";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(313, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// FrmVoto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(453, 442);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblErrorElegirCanal);
			this.Controls.Add(this.lblErrorOperacion);
			this.Controls.Add(this.lblGeneroError);
			this.Controls.Add(this.lblErrorApellido);
			this.Controls.Add(this.lblErrorEdad);
			this.Controls.Add(this.lblErrorNombre);
			this.Controls.Add(this.lblErrorDni);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnBuscarPorDni);
			this.Controls.Add(this.btnEligirCanal);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.cmbGenero);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.lblGenero);
			this.Controls.Add(this.lblEdad);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblDni);
			this.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVoto";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmVoto";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblEdad;
		private System.Windows.Forms.Label lblGenero;
		private System.Windows.Forms.TextBox txtDNI;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.ComboBox cmbGenero;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnEligirCanal;
		private System.Windows.Forms.Button btnBuscarPorDni;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label lblErrorDni;
		private System.Windows.Forms.Label lblErrorNombre;
		private System.Windows.Forms.Label lblErrorEdad;
		private System.Windows.Forms.Label lblErrorApellido;
		private System.Windows.Forms.Label lblGeneroError;
		private System.Windows.Forms.Label lblErrorOperacion;
		private System.Windows.Forms.Label lblErrorElegirCanal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}