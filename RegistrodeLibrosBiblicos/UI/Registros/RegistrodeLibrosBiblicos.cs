using RegistrodeLibrosBiblicos.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistrodeLibrosBiblicos.UI.Registros
{
    public partial class RegistrodeLibrosBiblico : Form
    {
        public RegistrodeLibrosBiblico()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            libroIdNumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            descripcionTextBox.Clear();
            siglasTextBox.Clear();
            tipoTextBox.Clear();
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && libroIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(libroIdNumericUpDown, "Llenar  Libros ID");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                GeneralerrorProvider.SetError(descripcionTextBox, "Llene Descripcion");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(siglasTextBox.Text))
            {
                GeneralerrorProvider.SetError(siglasTextBox, "Llene Siglas");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(tipoTextBox.Text))
            {
                GeneralerrorProvider.SetError(tipoTextBox, "Llene Tipo");
                errores = true;
            }




            return errores;

        }


        private LibrosBiblicos Llenaclase()
        {
            LibrosBiblicos librosbiblicos = new LibrosBiblicos();


            librosbiblicos.LibroId = Convert.ToInt32(libroIdNumericUpDown.Value);
            librosbiblicos.Descripcion = descripcionTextBox.Text;
            librosbiblicos.Fecha = fechaDateTimePicker.Value;
            librosbiblicos.Siglas = siglasTextBox.Text;
            librosbiblicos.Tipo = tipoTextBox.Text;


            return librosbiblicos;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }



        private void BuscarButton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(libroIdNumericUpDown.Value);
                LibrosBiblicos librosbiblicos = BLL.LibrosBiblicosBLL.Buscar(id);

                if (librosbiblicos != null)
                {
                    libroIdNumericUpDown.Value = librosbiblicos.LibroId;
                    fechaDateTimePicker.Value = librosbiblicos.Fecha;
                    descripcionTextBox.Text = librosbiblicos.Descripcion;
                    siglasTextBox.Text = librosbiblicos.Siglas;
                    tipoTextBox.Text = librosbiblicos.Tipo;


                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(libroIdNumericUpDown.Value);

                if (BLL.LibrosBiblicosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            LibrosBiblicos librosbiblicos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (libroIdNumericUpDown.Value == 0)
                {
                    paso = BLL.LibrosBiblicosBLL.Guardar(librosbiblicos);
                }
                else
                {
                    var V = BLL.LibrosBiblicosBLL.Buscar(Convert.ToInt32(libroIdNumericUpDown.Value));

                    if (V != null)
                    {
                        paso = BLL.LibrosBiblicosBLL.Editar(librosbiblicos);
                    }
                }


                Limpiar();
                GeneralerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
}   }
