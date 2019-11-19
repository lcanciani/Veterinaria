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
    public partial class ReporteVeterinarios : Form
    {
        AccesoDatos conn = new AccesoDatos();
        public ReporteVeterinarios()
        {
            InitializeComponent();
        }

        private void ReporteVeterinarios_Load(object sender, EventArgs e)
        {
            string consultaSql = "select * from ciudades ";
            veterinariosBindingSource.DataSource = conn.guardarTabla(consultaSql);
            this.reportViewer1.RefreshReport();

            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
