using RegistrodeLibrosBiblicos.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace RegistrodeLibrosBiblicos.UI.Consultas
{
    public partial class ConsultadeLibrosBiblicos : Form
    {
        public ConsultadeLibrosBiblicos()
        {
            InitializeComponent();
        }



        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<LibrosBiblicos, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                    

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.LibroId == id && (DesdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.LibroId == id;
                        }


                        if (BLL.LibrosBiblicosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://Descripcion

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar una Descripcion!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Descripcion.Contains(CriteriotextBox.Text) && (DesdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);
                        }

                        if (BLL.LibrosBiblicosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Descripcion, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://Siglas

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar Caracteres!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        
                    

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Siglas.Equals(CriteriotextBox.Text) && (DesdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.Siglas.Equals(CriteriotextBox.Text);
                        }


                        if (BLL.LibrosBiblicosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://Tipo

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar Caracteres!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                     
                      
                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Tipo.Equals(CriteriotextBox.Text) && (DesdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.Tipo.Equals(CriteriotextBox.Text);
                        }



                        if (BLL.LibrosBiblicosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }



                    break;

                case 4://TODO

                    filtro = x => true;
                    break;

            }
            ConsultadataGridView.DataSource = BLL.LibrosBiblicosBLL.GetList(filtro);
            CriteriotextBox.Clear();
            GeneralerrorProvider.Clear();


        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
        }
    }
}
