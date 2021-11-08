﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Martinez_Franco_2E_TpFinal
{
	public partial class FrmElegirCanal : Form
	{
		public string votoCanal;
		public FrmElegirCanal()
		{
			InitializeComponent();
			GenerateButtons();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{

			this.DialogResult = DialogResult.OK;
		}

		private void GenerateButtons()
		{
			try
			{
				Canal.VerificarArchivoCanal();
				List<Canal> canalList = Canal.GetList();

				int locationX = 70;
				int locationY = 50;
				int i = 1;
				bool flagX = false;

				foreach (Canal canal in canalList)
				{
					Button newButton = new Button();
					this.Controls.Add(newButton);
					newButton.Name = $"btn{canal.Nombre}";
					newButton.Text = $"{canal.Nombre}";
					newButton.ForeColor = Color.White;
					newButton.FlatStyle = FlatStyle.Flat;
					newButton.Size = new Size(97, 39);
					newButton.Click += this.RegistrarVoto;


					if (i % 2 != 0)
					{
						if (flagX)
						{
							locationX += 156;
							flagX = false;
						}

						newButton.Location = new Point(locationX, locationY);
						i++;
					}
					else
					{
						newButton.Location = new Point(locationX, locationY + 150);
						i++;
						flagX = true;

					}
				}
			}
			catch (Exception)
			{
				throw;
			}

		}

		public void RegistrarVoto(object sender, EventArgs e)
		{
			Button pressedButton = (Button)sender;
			votoCanal= pressedButton.Text;

		}


		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}