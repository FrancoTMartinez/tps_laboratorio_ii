using Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmVoto : Form
	{
		private string voto;
		public FrmVoto()
		{
			InitializeComponent();
			Persona.VerificarArchivoPersona();
			Canal.VerificarArchivoCanal();
		}

		private void btnEligirCanal_Click(object sender, EventArgs e)
		{
			try
			{
				FrmElegirCanal frmElegirCanal = new FrmElegirCanal();
				voto = string.Empty;
				if (frmElegirCanal.ShowDialog() == DialogResult.OK)
				{

					voto = frmElegirCanal.votoCanal;
				}
			}
			catch (Exception)
			{
				this.lblErrorElegirCanal.ForeColor = Color.Red;
				this.lblErrorElegirCanal.Text = "Ocurrio un error al querer acceder al archivo.\nRevise que el mimso existe.";
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

			if (Validar.ValidarDNI(this.txtDNI.Text))
			{
				if (Validar.ValidateExistingDNI(this.txtDNI.Text))
				{
					if (this.txtNombre.Text != string.Empty && Validar.ValidarCadenaTexto(this.txtNombre.Text))
					{
						if (this.txtApellido.Text != string.Empty && Validar.ValidarCadenaTexto(this.txtApellido.Text))
						{
							try
							{
								if (Validar.Edades(int.Parse(this.txtEdad.Text)))
								{
									if (this.cmbGenero.SelectedIndex >= 0)
									{
										if (voto != null)
										{
											Persona persona = new Persona(this.txtDNI.Text, this.txtNombre.Text, this.txtApellido.Text, voto, int.Parse(this.txtEdad.Text), this.cmbGenero.SelectedItem.ToString());
											persona.AddToList(persona);
											Console.Beep();

											this.DialogResult = DialogResult.OK;
										}
										else {
											this.lblGeneroError.ForeColor = Color.Red;
											this.lblGeneroError.Text = "Debe seleccionar un canal."; 
											this.lblErrorEdad.Text = string.Empty;
											this.lblErrorApellido.Text = string.Empty;
											this.lblErrorNombre.Text = string.Empty;
											this.lblErrorDni.Text = string.Empty;
										}

									}
									else
									{
										this.lblGeneroError.ForeColor = Color.Red;
										this.lblGeneroError.Text = "Debe seleccionar un genero."; 
										this.lblErrorEdad.Text = string.Empty;
										this.lblErrorApellido.Text = string.Empty;
										this.lblErrorNombre.Text = string.Empty;
										this.lblErrorDni.Text = string.Empty;
									}


								}
								else
								{
									this.lblErrorEdad.ForeColor = Color.Red;
									this.lblErrorEdad.Text = "La edad ingresada es invalida.Debe ser mayor a 18 anios.";
									this.lblErrorApellido.Text = string.Empty;
									this.lblErrorNombre.Text = string.Empty;
									this.lblErrorDni.Text = string.Empty;

								}
							}
							catch (Exception ex)
							{
								this.lblErrorEdad.ForeColor = Color.Red;
								this.lblErrorEdad.Text = "Ingrese numeros en vez de texto.";
								this.lblErrorApellido.Text = string.Empty;
								this.lblErrorNombre.Text = string.Empty;
								this.lblErrorDni.Text = string.Empty;
							}

						}
						else
						{
							this.lblErrorApellido.ForeColor = Color.Red;
							this.lblErrorApellido.Text = "El apellido ingresado es invalido.";
							this.lblErrorNombre.Text = string.Empty;
							this.lblErrorDni.Text = string.Empty;
						}
					}
					else
					{
						this.lblErrorNombre.ForeColor = Color.Red;
						this.lblErrorNombre.Text = "El nombre ingresado es invalido.";
						this.lblErrorDni.Text = string.Empty;
					}
				}
				else
				{
					this.lblErrorDni.ForeColor = Color.Red;
					this.lblErrorDni.Text = "El DNI ingresado ya se encuentra registrado.";

				}
			}
			else
			{
				this.lblErrorDni.ForeColor = Color.Red;
				this.lblErrorDni.Text = "DNI invalido.";
			}
		}

		private void btnBuscarPorDni_Click(object sender, EventArgs e)
		{

			FrmModificar frmModificar = new FrmModificar();

			if (frmModificar.ShowDialog() == DialogResult.OK)
			{
				Persona persona = frmModificar.persona;

				this.lblID.Text = persona.Id.ToString();
				this.txtDNI.Text = persona.Dni;
				this.txtNombre.Text = persona.Nombre;
				this.txtApellido.Text = persona.Apellido;
				this.txtEdad.Text = persona.Edad.ToString();
				this.cmbGenero.SelectedItem = persona.Genero;
				voto = persona.Voto;

			}


		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (Validar.ValidarDNI(this.txtDNI.Text))
			{
				if (this.txtNombre.Text != string.Empty && Validar.ValidarCadenaTexto(this.txtNombre.Text))
				{
					if (this.txtApellido.Text != string.Empty && Validar.ValidarCadenaTexto(this.txtApellido.Text))
					{
						try
						{
							if (Validar.Edades(int.Parse(this.txtEdad.Text)))
							{
								if (this.cmbGenero.SelectedIndex > 0)
								{
									Persona personaAModificar = new Persona();
									personaAModificar.Id = int.Parse(this.lblID.Text);
									personaAModificar.Dni = this.txtDNI.Text;
									personaAModificar.Nombre = this.txtNombre.Text;
									personaAModificar.Apellido = this.txtApellido.Text;
									personaAModificar.Edad = int.Parse(this.txtEdad.Text);
									personaAModificar.Genero = this.cmbGenero.SelectedItem.ToString();
									personaAModificar.Voto = voto;


									if (personaAModificar.UpdateFromList(personaAModificar))
									{
										Console.Beep();
										this.DialogResult = DialogResult.OK;
									}
									else
									{
										this.lblErrorDni.ForeColor = Color.Red;
										this.lblErrorDni.Text = "El DNI ingresado ya se encuentra registrado.";
									}
								}
								else
								{
									this.lblGeneroError.ForeColor = Color.Red;
									this.lblGeneroError.Text = "Debe seleccionar un genero."; this.lblErrorEdad.Text = string.Empty;
									this.lblErrorApellido.Text = string.Empty;
									this.lblErrorNombre.Text = string.Empty;
									this.lblErrorDni.Text = string.Empty;
								}

							}
							else
							{
								this.lblErrorEdad.ForeColor = Color.Red;
								this.lblErrorEdad.Text = "La edad ingresada es invalida.";
								this.lblErrorApellido.Text = string.Empty;
								this.lblErrorNombre.Text = string.Empty;
								this.lblErrorDni.Text = string.Empty;
							}
						}
						catch (Exception ex)
						{
							this.lblErrorEdad.ForeColor = Color.Red;
							this.lblErrorEdad.Text = "Ingrese numeros en vez de texto.";
							this.lblErrorApellido.Text = string.Empty;
							this.lblErrorNombre.Text = string.Empty;
							this.lblErrorDni.Text = string.Empty;
						}
					}
					else
					{
						this.lblErrorApellido.ForeColor = Color.Red;
						this.lblErrorApellido.Text = "El apellido ingresado es invalido.";
						this.lblErrorNombre.Text = string.Empty;
						this.lblErrorDni.Text = string.Empty;
					}
				}
				else
				{
					this.lblErrorNombre.ForeColor = Color.Red;
					this.lblErrorNombre.Text = "El nombre ingresado es invalido.";
					this.lblErrorDni.Text = string.Empty;
				}
			}
			else
			{

				this.lblErrorDni.ForeColor = Color.Red;
				this.lblErrorDni.Text = "DNI invalido.";
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				Persona personaAEliminar = new Persona();
				personaAEliminar.Id = int.Parse(this.lblID.Text);
				if (personaAEliminar.DeleteFromList(personaAEliminar.Id))
				{

					Console.Beep();
					this.DialogResult = DialogResult.OK;

				}
				else
				{
					this.lblErrorOperacion.ForeColor = Color.Red;
					this.lblErrorOperacion.Text = "Ocurrio un error al querer eliminar. Reintente";
				}
			}
			catch (Exception)
			{

				this.lblErrorOperacion.ForeColor = Color.Red;
				this.lblErrorOperacion.Text = "Las casillas deben contener informacion para poder realizar la operacion.";
			}


		}
	}
}
