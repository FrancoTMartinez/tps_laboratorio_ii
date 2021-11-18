using Entidades;
using Excepciones;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Martinez_Franco_2E_TpFinal
{
	public delegate void ExportarArchivos();
	
	public partial class FrmAdministradoresABM_ : Form
	{
		
		Admin admin;
		ExportarArchivos expArchivos;
		Archivos<string> archivos;

		public FrmAdministradoresABM_()
		{
			InitializeComponent();
			archivos = new Archivos<string>();
			expArchivos = archivos.ExportarArchivos;
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			try
			{
				if (Validar.ValidarDNI(this.txtBoxDni.Text))
				{
					if (Admin.ValidateExistingDNI(this.txtBoxDni.Text))
					{
						admin = new Admin(this.txtBoxDni.Text, this.txtBoxUser.Text, this.txtBoxPassword.Text);

						if (Validar.ValidateExistingUserAdmin(admin))
						{
							if (admin.AddToDB(admin))
							{
								this.lblInforme2.ForeColor = Color.Green;
								this.lblInforme2.Text = "Se agrego correctamente.";
								Clear();
							}
							else
							{
								this.lblInforme.ForeColor = Color.Red;
								this.lblInforme.Text = "Ocurrio un error.";
							}
						}
						else
						{
							this.lblInforme.ForeColor = Color.Red;
							this.lblInforme.Text = "El nombre de usuario ya se encuentra registrado.";
						}
					}
					else
					{
						this.lblInforme.ForeColor = Color.Red;
						this.lblInforme.Text = "El dni ingresado ya se encuentra registrado.";
					}
				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "El dni ingresado es invalido.";
				}

			}
			catch (AdminUserException ex)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = ex.Message;
			}
			catch (AdminPasswordExceptioncs ex)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = ex.Message;
			}
			catch (Exception ex)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = ex.Message;
			}

		}

		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (this.txtBoxUser.Text != string.Empty && this.txtBoxPassword.Text != string.Empty)
			{
				if (Validar.ValidarCadenaTexto(this.txtBoxUser.Text))
				{
					if (Validar.ValidarDNI(this.txtBoxDni.Text))
					{
						try
						{
							admin.Dni = this.txtBoxDni.Text;
							admin.User = this.txtBoxUser.Text;
							admin.Password = this.txtBoxPassword.Text;

							if (Validar.ValidateExistingAdminDNI(admin))
							{
								if (Validar.ValidateExistingUserAdmin(admin))
								{
									if (admin.UpdateFromDB(admin))
									{
										this.lblInforme2.ForeColor = Color.Green;
										this.lblInforme2.Text = "Se modifico correctamente.";
										this.lblInforme.Text = string.Empty;
										Clear();
									}
									else
									{
										this.lblInforme.ForeColor = Color.Red;
										this.lblInforme.Text = "Ocurrio un error.";
									}
								}
								else
								{
									this.lblInforme.ForeColor = Color.Red;
									this.lblInforme.Text = "El usuario ingresado ya se encuentra registrado.";
								}

							}
							else
							{
								this.lblInforme.ForeColor = Color.Red;
								this.lblInforme.Text = "El dni ingresado ya se encuentra registrado.";
							}
						}
						catch (Exception ex)
						{

							this.lblInforme.ForeColor = Color.Red;
							this.lblInforme.Text = "Datos invalidos.";
							this.lblInforme.Text = ex.Message;
						}
					}

				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "El usuario debe contener solo letras.";
				}

			}
			else
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Complete los campos antes de Modificar.";
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			try
			{
				if (admin.DeleteFromDB(admin.Id))
				{
					this.lblInforme2.ForeColor = Color.Green;
					this.lblInforme2.Text = "Se Elimino correctamente.";
					Clear();
				}
				else
				{
					this.lblInforme.ForeColor = Color.Red;
					this.lblInforme.Text = "Datos invalidos.";
				}
			}
			catch (NullReferenceException)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Complete los campos antes de Eliminar.";
			}
			catch (Exception)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme.Text = "Ocurrio un error al querer acceder al archivo.";
			}


		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			admin = Admin.GetAdminByDNI(this.txtBoxDni.Text);

			if (admin == null)
			{
				this.lblInforme.ForeColor = Color.Red;
				this.lblInforme2.Text = string.Empty;
				this.lblInforme.Text = "No se encontro un administrador con ese dni.";
				Clear();
			}
			else
			{

				this.lblInforme.Text = string.Empty;
				this.txtBoxUser.Text = admin.User;
				this.txtBoxPassword.Text = admin.Password;
			}

		}

		private void Clear()
		{
			this.txtBoxUser.Text = string.Empty;
			this.txtBoxPassword.Text = string.Empty;
			this.txtBoxDni.Text = string.Empty;
		}

		private void btnExportarAdmins_Click(object sender, EventArgs e)
		{
			try
			{
				Task exportarArchivos = Task.Run(() =>
				{
					expArchivos.Invoke();
				});

				exportarArchivos.Wait();

				this.lblInforme2.ForeColor = Color.Green;
				this.lblInforme2.Text = "Archivos generados correctamente.";

				Console.Beep();
			}
			catch (Exception)
			{
				this.lblInforme2.ForeColor = Color.Red;
				this.lblInforme2.Text = "No se pudo generar el archivo.";
			}
		}
	}
}

