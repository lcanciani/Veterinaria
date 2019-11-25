using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaMenu
{
    public partial class FormReporteMascotas : Form
    {
        public FormReporteMascotas()
        {
            InitializeComponent();
        }

        private void FormReporteMascotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.mascotas' Puede moverla o quitarla según sea necesario.
            this.mascotasTableAdapter.todoMascota(this.DataSet1.mascotas);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
