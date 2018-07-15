using RegistrodeLibrosBiblicos.UI.Consultas;
using RegistrodeLibrosBiblicos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistrodeLibrosBiblicos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroDeLibrosBiblicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeLibrosBiblico registrodeLibrosBiblico = new RegistrodeLibrosBiblico();
            registrodeLibrosBiblico.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void librosBiblicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultadeLibrosBiblicos consulta = new ConsultadeLibrosBiblicos();
            consulta.Show();
        }
    }
}
